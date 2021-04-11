using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{
    public class Step
    {

        //Attributes
        public int StepID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Kettle { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public double Temp { get; set; }
        public int Timer { get; set; }

        //1:1
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        //1:M
        public virtual ICollection<BrewSessionStep> BrewSessionSteps { get; set; }

        public Step() { }
    }
}