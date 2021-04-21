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
        public IEnumerable<BrewSession> BrewSessions { get; set; }
        public IEnumerable<Step> Steps { get; set; }

        public IEnumerable<Malt> Malts { get; set; }
        public IEnumerable<Hop> Hops { get; set; }
        public IEnumerable<Yeast> Yeasts { get; set; }
        public IEnumerable<Other> Others { get; set; }
    }
}
