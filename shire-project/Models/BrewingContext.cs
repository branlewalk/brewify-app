using Microsoft.EntityFrameworkCore;
using shire_project.Models;

namespace shire_project
{
    public class BrewingContext : DbContext
    {
        //The Main Tables
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<BrewSession> Sessions { get; set; }

        //Recipe Related
        public DbSet<MaltIngredient> MaltIngredients { get; set; }
        public DbSet<HopIngredient> HopIngredients { get; set; }
        public DbSet<YeastIngredient> YeastIngredients { get; set; }
        public DbSet<OtherIngredient> OtherIngredients { get; set; }
        public DbSet<Malt> Malts { get; set; }
        public DbSet<Hop> Hops { get; set; }
        public DbSet<Yeast> Yeasts { get; set; }
        public DbSet<Other> Others { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<BrewImage> BrewImages { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Step> RecipeSteps { get; set; }

        //Session Related
        public DbSet<Temp> Temps { get; set; }
        public DbSet<BrewSessionStep> BrewSessionSteps { get; set; }

        //User Tables--TBD

        public BrewingContext(DbContextOptions<BrewingContext>options) : base(options)
        {
            //Database.EnsureCreated();
        }
    }
}