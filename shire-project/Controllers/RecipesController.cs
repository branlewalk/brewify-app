using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace shire_project.Controllers
{
    public class RecipesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //TODO: Create POST method to handle serving data from form in View to DB

        //TODO: Create GET method to handle filling data from DB to View
    }
}
