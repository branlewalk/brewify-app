using System.Collections.Generic;

namespace shire_project.Models
{
    public class Other
    {
        //      other_id INT NOT NULL AUTO_INCREMENT,
        //other_name VARCHAR(45) NOT NULL,
        //other_type VARCHAR(10) NOT NULL,
        //other_use VARCHAR(10) NOT NULL,

        //Attributes
        public int OtherID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        //M:1
        public virtual ICollection<OtherIngredient> OtherIngredients { get; set; }

        public Other() { }
    }
}