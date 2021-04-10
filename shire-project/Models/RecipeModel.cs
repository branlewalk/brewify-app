using System;
using System.Collections.Generic;

namespace shire_project.Models
{
    public class Recipe
    {

        // Attributes
        public long RecipeID { get; set; }
        public string Name { get; set; }
        public string Method { get; set; }
        public double BatchSize { get; set; }
        public int Rating { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }

        // 1:M Relationships - having both the ID and the Class makes the ID notNull
        public int StyleID { get; set; }
        public Style Style { get; set; }
        public int BrewImageID { get; set; }
        public BrewImage BrewImage { get; set; }
        public int NotesID { get; set; }
        public Note Note { get; set; }

        // M:1 Relationships - use 'virtual'
        public virtual ICollection<MaltIngredient> MaltIngedients { get; set; }
        public virtual ICollection<HopIngredient> HopIngredients { get; set; }
        public virtual ICollection<YeastIngredient> YeastIngredients { get; set; }
        public virtual ICollection<OtherIngredient> OtherIngredients { get; set; }
        public virtual ICollection<BrewSession> BrewSessions { get; set; }
        public virtual ICollection<Step> Steps { get; set; }

        public Recipe(){}

        public override string ToString()
        {
            return $"ID is {RecipeID}, Name is {Name}";
        }

    }
}
