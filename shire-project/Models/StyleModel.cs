namespace shire_project.Models
{
    public class Style
    {
        //Attributes
        public int StyleID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string BJCP { get; set; }
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
        public int BrewImageID { get; set; }
        public BrewImage BrewImage { get; set; }

        public Style() { }
    }
}