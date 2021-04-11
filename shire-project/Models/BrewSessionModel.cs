using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{
    public class BrewSession
    {

        //Attributes
        public int BrewSessionID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime Start { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime End { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime Created { get; set; }

        //1:M
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        //M:1
        public virtual ICollection<BrewSessionStep> BrewSessionSteps { get; set; }

        public BrewSession() { }
    }
}