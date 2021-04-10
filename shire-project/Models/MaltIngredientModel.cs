namespace shire_project.Models
{
    public class MaltIngredient
    {
        //Attributes
        public int MaltIngredientID { get; set; }
        public double Quantity { get; set; }

        //1:M
        public int MaltID { get; set; }
        public Malt Malt { get; set; }
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        public MaltIngredient() { }
    } 
}