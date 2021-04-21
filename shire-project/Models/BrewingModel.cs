using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{
    public class BrewImage
    {
        //Attributes
        public int BrewImageID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR(250)")]
        public string Location { get; set; }
        [Column(TypeName = "VARCHAR(250)")]
        public string? Description { get; set; }

        //M:1
        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<Style> Styles { get; set; }
        public virtual ICollection<Step> Steps { get; set; }

        public BrewImage() { }
    }

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

    public class Hop
    {

        //Attributes
        public int HopID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Variety { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Type { get; set; }
        public double AlphaAcids { get; set; }

        //M:1
        public virtual ICollection<HopIngredient> HopIngredients { get; set; }

        public Hop() { }
    }

    public class HopIngredient
    {

        //Attributes
        public int HopIngredientID { get; set; }
        public double Quantity { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Use { get; set; }
        // Time in minutes...Maybe eeed a different data structure here
        public int Time { get; set; }

        //1:M
        public int HopID { get; set; }
        public Hop Hop { get; set; }
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        public HopIngredient() { }
    }

    public class Malt
    {
        //Attributes
        public int MaltID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Origin { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Category { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Type { get; set; }
        public int Lovibond { get; set; }
        public double PPG { get; set; }

        //M:1
        public virtual ICollection<MaltIngredient> MaltIngredients { get; set; }

        public Malt() { }
    }

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

    public class Note
    {
        public int NoteID { get; set; }
        [Column(TypeName = "VARCHAR(250)")]
        public string Body { get; set; }
        [Column(TypeName = "TIMESTAMP")]
        public DateTime? Created { get; set; }

        public Note() { }
    }

    public class OtherIngredient
    {

        //Attributes
        public int OtherIngredientID { get; set; }
        public double Quantity { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Use { get; set; }

        //1:M
        public int OtherID { get; set; }
        public Other Other { get; set; }
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        public OtherIngredient() { }
    }

    public class Other
    {

        //Attributes
        public int OtherID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Type { get; set; }

        //M:1
        public virtual ICollection<OtherIngredient> OtherIngredients { get; set; }

        public Other() { }
    }

    public class Recipe
    {

        // Attributes
        public long RecipeID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Method { get; set; }
        public double BatchSize { get; set; }
        public int Rating { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime Created { get; set; }
        [Column(TypeName = "VARCHAR(250)")]
        public string Description { get; set; }

        // 1:M Relationships - having both the ID and the Class makes the ID notNull
        public int? StyleID { get; set; }
        public Style Style { get; set; }
        public int? BrewImageID { get; set; }
        public BrewImage BrewImage { get; set; }
        public int? NoteID { get; set; }
        public Note Note { get; set; }

        // M:1 Relationships - use 'virtual'
        public virtual ICollection<MaltIngredient> MaltIngredients { get; set; }
        public virtual ICollection<HopIngredient> HopIngredients { get; set; }
        public virtual ICollection<YeastIngredient> YeastIngredients { get; set; }
        public virtual ICollection<OtherIngredient> OtherIngredients { get; set; }
        public virtual ICollection<BrewSession> BrewSessions { get; set; }
        public virtual ICollection<Step> Steps { get; set; }

        public Recipe() { }

        public override string ToString()
        {
            return $"ID is {RecipeID}, Name is {Name}";
        }
    }

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

    public class YeastIngredient
    {
        //Attributes
        public int YeastIngredientID { get; set; }
        public double Quantity { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Starter { get; set; }

        //M:1
        public int YeastID { get; set; }
        public Yeast Yeast { get; set; }
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        public YeastIngredient() { }
    }

    public class Yeast
    {
        //Attributes
        public int YeastID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Strain { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Lab { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Code { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Type { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Floccuation { get; set; }
        public double Attenuation { get; set; }
        public double MinTemp { get; set; }
        public double MaxTemp { get; set; }

        //1:M
        public virtual ICollection<YeastIngredient> YeastIngredients { get; set; }

        public Yeast() { }

    }
}
