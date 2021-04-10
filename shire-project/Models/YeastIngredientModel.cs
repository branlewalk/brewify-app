namespace shire_project.Models
{
    public class YeastIngredient
    {

        //Attributes
        public int YeastIngredientID { get; set; }
        public double Quantity { get; set; }
        public string Starter { get; set; }

        //M:1
        public int YeastID { get; set; }
        public Yeast Yeast { get; set; }
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        public YeastIngredient() { }
    }
}