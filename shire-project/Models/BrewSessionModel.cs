using System;
using System.Collections.Generic;

namespace shire_project.Models
{
    public class BrewSession
    {

        //Attributes
        public int BrewSessionID { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime Created { get; set; }

        //1:M
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        //M:1
        public virtual ICollection<BrewSessionStep> BrewSessionSteps { get; set; }

        public BrewSession() { }
    }
}