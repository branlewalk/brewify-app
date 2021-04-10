using System.Collections.Generic;

namespace shire_project.Models
{

    public class Malt
    {
        //Attributes
        public int MaltID { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public int Lovibond { get; set; }
        public double PPG { get; set; }

        //M:1
        public virtual ICollection<MaltIngredient> MaltIngredients { get; set; }

        public Malt() { }
    }
}