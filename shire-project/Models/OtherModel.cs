using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{
    public class Other
    {

        //Attributes
        public int OtherID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Type { get; set; }

        //M:1
        public virtual ICollection<OtherIngredient> OtherIngredients { get; set; }

        public Other() { }
    }
}