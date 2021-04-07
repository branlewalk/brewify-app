using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Threading.Channels;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;


namespace shire_project.Controllers
{
    public class DashboardController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string Temp()
        {
            // Connection Settings...need to change...
            ConnectionFactory factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://guest:guest@192.168.1.49:5672/");


            IConnection conn = factory.CreateConnection();
            IModel channel = conn.CreateModel();
            var queueName = "current-temps";
            var exchangeName = "temps";

            channel.QueueDeclare(queueName, false, false, false, null);
            channel.QueueBind(queueName, exchangeName, "", null);

            bool noAck = false;
            BasicGetResult result = channel.BasicGet(queueName, noAck);
            if (result == null)
            {
                // No message available
            }
            else
            {
                var body = JsonSerializer.Deserialize<double[]>(result.Body.ToArray());
                var temps = new Temps() {
                    hlt=Math.Round(body[0], 1),
                    mlt=Math.Round(body[1], 1),
                    bk=Math.Round(body[2], 1)};
                var json = JsonSerializer.Serialize(temps);
                return json;
            }
            return "Cannot read temperatures ";
        }
    }

    public class Temps
    {
        public double hlt { get; set; }
        public double mlt { get; set; }
        public double bk { get; set; }

        public override string ToString()
        {
            return $" hlt: {hlt}, mlt: {mlt}, bk: {bk}";
        }
    }
}
