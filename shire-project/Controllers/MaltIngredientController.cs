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
    public class MaltIngredientController : Controller
    {
        private readonly ILogger<MaltIngredientController> _logger;
        private readonly BrewingContext _context;

        public MaltIngredientController(ILogger<MaltIngredientController> logger, BrewingContext context)
        {
            _logger = logger;
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        { 
            var viewModel = new CreateMaltIngredientViewModel();
            viewModel.Malts = _context.Malts;
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(CreateMaltIngredientViewModel miViewModel)
        {
            _logger.LogInformation($"Form contains: {HttpContext.Request.Form}");

            _logger.LogInformation($"Malt Ingredient: Malt ID: {miViewModel.MaltIngredient.MaltID}, " +
                                                   $"Quantity: {miViewModel.MaltIngredient.Quantity}, " +
                                                   $"RecipeID: {miViewModel.MaltIngredient.RecipeID}");

            MaltIngredient mi = new MaltIngredient();

            mi.MaltID = miViewModel.MaltIngredient.MaltID;
            mi.Quantity = miViewModel.MaltIngredient.Quantity;
            mi.RecipeID = miViewModel.MaltIngredient.RecipeID;

            _context.MaltIngredients.Add(mi);
            _context.SaveChanges();
            return RedirectToRoute("~/Recipes/Index");
        }

        [HttpPost]
        public ActionResult Delete(MaltIngredient mIngredient)
        {
            _context.MaltIngredients.Remove(mIngredient);
            _context.SaveChanges();
            return RedirectToRoute("~/Recipes/Index");
        }
    }
}

