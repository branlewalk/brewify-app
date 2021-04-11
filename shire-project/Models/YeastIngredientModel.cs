using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{
    public class YeastIngredient
    {

        //Attributes
        public int YeastIngredientID { get; set; }
        public double Quantity { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Starter { get; set; }

        //M:1
        public int YeastID { get; set; }
        public Yeast Yeast { get; set; }
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        public YeastIngredient() { }
    }
}