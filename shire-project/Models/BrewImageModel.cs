using System.Collections.Generic;

namespace shire_project.Models
{
    public class BrewImage
    {
        //Attributes
        public int BrewImageID { get; set; }
        public string BrewImageName { get; set; }
        public string BrewImageLocation { get; set; }
        public string BrewImageDescription { get; set; }

        //M:1
        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<Style> Styles { get; set; }
        public virtual ICollection<Step> Steps { get; set; }

        public BrewImage() { }
    }
}