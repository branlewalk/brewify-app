using System;
using System.Collections.Generic;
using shire_project.Models;

namespace shire_project.ViewModels
{
    public class RecipeIndexData
    {
        public IEnumerable<Recipe> Recipes { get; set; }
        public IEnumerable<MaltIngredient> MaltIngredients { get; set; }
        public IEnumerable<HopIngredient> HopIngredients { get; set; }
        public IEnumerable<YeastIngredient> YeastIngredients { get; set; }
        public IEnumerable<OtherIngredient> OtherIngredients { get; set; }
    }
}
