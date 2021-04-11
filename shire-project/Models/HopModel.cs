using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{
    public class Hop
    {

        //Attributes
        public int HopID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Variety { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Type { get; set; }
        public double AlphaAcids { get; set; }

        //M:1
        public virtual ICollection<HopIngredient> HopIngredients { get; set; }

        public Hop() { }
    }
}