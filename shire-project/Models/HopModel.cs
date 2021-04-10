using System.Collections.Generic;

namespace shire_project.Models
{
    public class Hop
    {

        //Attributes
        public int HopID { get; set; }
        public string Variety { get; set; }
        public string AlphaAcids { get; set; }

        //M:1
        public virtual ICollection<HopIngredient> HopIngredients { get; set; }

        public Hop() { }
    }
}