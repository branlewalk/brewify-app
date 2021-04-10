using System.Collections.Generic;

namespace shire_project.Models
{
    public class Step
    {

        //Attributes
        public int StepID { get; set; }
        public string Name { get; set; }
        public string Kettle { get; set; }
        public string Temp { get; set; }
        public int Timer { get; set; }

        //1:1
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        //1:M
        public virtual ICollection<BrewSessionStep> BrewSessionSteps { get; set; }

        public Step() { }
    }
}