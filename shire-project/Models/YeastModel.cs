using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{
    public class Yeast
    {

        //Attributes
        public int YeastID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Strain { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Lab { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Code { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Type { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Floccuation { get; set; }
        public double Attenuation { get; set; }
        public double MinTemp { get; set; }
        public double MaxTemp { get; set; }

        //1:M
        public virtual ICollection<YeastIngredient> YeastIngredients { get; set; }

        public Yeast() { }

    }
}