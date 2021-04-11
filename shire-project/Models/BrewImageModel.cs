using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{
    public class BrewImage
    {
        //Attributes
        public int BrewImageID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR(250)")]
        public string Location { get; set; }
        [Column(TypeName = "VARCHAR(250)")]
        public string? Description { get; set; }

        //M:1
        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<Style> Styles { get; set; }
        public virtual ICollection<Step> Steps { get; set; }

        public BrewImage() { }
    }
}