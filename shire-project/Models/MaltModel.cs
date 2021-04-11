using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{

    public class Malt
    {
        //Attributes
        public int MaltID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Origin { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Category { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Type { get; set; }
        public int Lovibond { get; set; }
        public double PPG { get; set; }

        //M:1
        public virtual ICollection<MaltIngredient> MaltIngredients { get; set; }

        public Malt() { }
    }
}