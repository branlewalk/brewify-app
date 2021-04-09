using Microsoft.EntityFrameworkCore;
using shire_project.Models;

namespace shire_project
{
    public class BrewingContext : DbContext
    {
        public DbSet<Recipes> Recipe { get; set; }

        public BrewingContext(DbContextOptions<BrewingContext>options) : base(options)
        {
            //Database.EnsureCreated();
        }
    }
}