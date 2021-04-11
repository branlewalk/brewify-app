using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{
    public class Style
    {
        //Attributes
        public int StyleID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Category { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string BJCP { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public int MinIBU { get; set; }
        public int MaxIBU { get; set; }
        public int MinABV { get; set; }
        public int MaxABV { get; set; }
        public double MinFinalGravity { get; set; }
        public double MaxFinalGravity { get; set; }
        public double MinCO2 { get; set; }
        public double MaxCO2 { get; set; }
        public int Lovibond { get; set; }

        //1:1
        public int? BrewImageID { get; set; }
        public BrewImage BrewImage { get; set; }

        public Style() { }
    }
}