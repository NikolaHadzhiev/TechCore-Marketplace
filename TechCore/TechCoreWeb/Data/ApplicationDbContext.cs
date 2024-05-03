using Microsoft.EntityFrameworkCore;
using TechCoreWeb.Models;

namespace TechCoreWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "CPU", DisplayOrder = 1 },
                new Category { Id = 2, Name = "GPU", DisplayOrder = 2 },
                new Category { Id = 3, Name = "RAM", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Motherboard", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Storage", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Cooling", DisplayOrder = 6 },    
                new Category { Id = 7, Name = "Power Supply", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Case", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Peripherals", DisplayOrder = 9 }
           );
        }
    }
}
