using System.Collections.Generic;

namespace shire_project.Models
{
    public class Yeast
    {

        //Attributes
        public int YeastID { get; set; }
        public string Strain { get; set; }
        public string Lab { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Floccuation { get; set; }
        public double Attenuation { get; set; }
        public double MinTemp { get; set; }
        public double MaxTemp { get; set; }

        //1:M
        public virtual ICollection<YeastIngredient> YeastIngredients { get; set; }

        public Yeast() { }

    }
}