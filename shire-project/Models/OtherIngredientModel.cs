namespace shire_project.Models
{
    public class OtherIngredient
    {

        //Attributes
        public int OtherIngredientID { get; set; }
        public double Quantity { get; set; }
        public string Use { get; set; }

        //1:M
        public int OtherID { get; set; }
        public Other Other { get; set; }
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        public OtherIngredient() { }
    }
}