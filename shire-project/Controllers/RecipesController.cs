using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using shire_project.Models;
using shire_project.ViewModels;

namespace shire_project.Controllers
{
    public class RecipesController : Controller
    {
        private readonly ILogger<RecipesController> _logger;
        private readonly BrewingContext _context;

        public RecipesController(ILogger<RecipesController> logger, BrewingContext context)
        {
            _logger = logger;
            _context = context;
        }

        public ActionResult Index()
        {
            var viewModel = new RecipeIndexData();
            viewModel.Recipes = _context.Recipes
                .OrderBy(i => i.Name);
            return View(viewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Malt malt)
        {
            return RedirectToAction("Index");
        }
    }
}

