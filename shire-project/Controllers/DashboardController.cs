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
using Microsoft.Extensions.Logging;

namespace shire_project.Controllers
{

    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string Temp()
        {
            _logger.LogInformation("Starting Temp");

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
                _logger.LogInformation("No message available");
                // No message available
            }
            else
            {
                var body = result.Body.ToArray();
                _logger.LogInformation($"Retrieving body from RabbitMQ, body is {Encoding.UTF8.GetString(body)}");

                var data = new decimal[3] { 0.0M, 0.0M, 0.0M };
                try
                {
                    data = JsonSerializer.Deserialize<decimal[]>(body);
                }
                catch (JsonException e)
                {
                    _logger.LogInformation($"Could Not Deserialize {Encoding.UTF8.GetString(body)}");
                    _logger.LogWarning($"Throwing exception {e}");
                }
               
                var temps = new Temps() {
                    hlt=Math.Round(data[0], 1),
                    mlt=Math.Round(data[1], 1),
                    bk=Math.Round(data[2], 1)};
                var json = JsonSerializer.Serialize(temps);

                _logger.LogInformation($"Ending Temp, returning json: {json}");
                return json;
            }

            _logger.LogInformation($"Ending Temp, returning 'Cannot read temperatures'");
            return "Cannot read temperatures";
        }
    }

    public class Temps
    {
        public decimal hlt { get; set; }
        public decimal mlt { get; set; }
        public decimal bk { get; set; }

        public override string ToString()
        {
            return $" hlt: {hlt}, mlt: {mlt}, bk: {bk}";
        }
    }
}
