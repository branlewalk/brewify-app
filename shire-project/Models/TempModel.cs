using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{
    public class Temp
    {
        public int TempID { get; set; }
        public decimal hlt { get; set; }
        public decimal mlt { get; set; }
        public decimal bk { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime Created { get; set; }

        //1:M
        public int BrewSessionID { get; set; }
        public BrewSession BrewSession { get; set; }

        public Temp() { }

        public override string ToString()
        {
            return $" hlt: {hlt}, mlt: {mlt}, bk: {bk}";
        }
    }
}