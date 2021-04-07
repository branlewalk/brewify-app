using Microsoft.EntityFrameworkCore;
using shire_project.Models;

namespace shire_project
{
    internal class RecipesContext : DbContext
    {
        public DbSet<Recipes> Recipe { get; set; }

        public RecipesContext(DbContextOptions<RecipesContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}