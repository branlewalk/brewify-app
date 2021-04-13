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

        public ActionResult Index(int? id)
        {
            var viewModel = new RecipeIndexData();
            viewModel.Recipes = _context.Recipes
                .Include(i => i.HopIngredients)
                .Include(i => i.MaltIngredients)
                .Include(i => i.YeastIngredients)
                .Include(i => i.OtherIngredients)
                .Include(i => i.Style)
                .OrderBy(i => i.Name);

            //if (id != null)
            //{
            //    ViewBag.InstructorID = id.Value;
            //    viewModel.Courses = viewModel.Recipes.Where(
            //        i => i.ID == id.Value).Single().Courses;
            //}

            //if (courseID != null)
            //{
            //    ViewBag.CourseID = courseID.Value;
            //    viewModel.Enrollments = viewModel.Courses.Where(
            //        x => x.CourseID == courseID).Single().Enrollments;
            //}

            return View(viewModel);
        }
    }
}
