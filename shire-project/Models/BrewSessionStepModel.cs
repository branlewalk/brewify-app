using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{
    public class BrewSessionStep
    {

        //Attributes
        public int BrewSessionStepID { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime Start { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime End { get; set; }

        //1:M
        public int BrewSessionID { get; set; }
        public BrewSession BrewSession { get; set; }
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        public BrewSessionStep() { }
    }
}