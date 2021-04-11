using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{
    public class HopIngredient
    {

        //Attributes
        public int HopIngredientID { get; set; }
        public double Quantity { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Use { get; set; }
        // Time in minutes...Maybe eeed a different data structure here
        public int Time { get; set; }

        //1:M
        public int HopID { get; set; }
        public Hop Hop { get; set; }
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        public HopIngredient() { }
    }
}