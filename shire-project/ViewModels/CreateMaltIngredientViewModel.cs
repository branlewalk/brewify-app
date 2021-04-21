using System;
using System.Collections.Generic;
using shire_project.Models;

namespace shire_project.ViewModels
{
    public class CreateMaltIngredientViewModel
    {
        public IEnumerable<Malt> Malts { get; set; }
        public MaltIngredient MaltIngredient { get; set; }
    }
}
