using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        // It will create Categories table in DB
        public DbSet<Category> Categories { get; set; }

        // To insert data to table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { id = 1, name = "Action", displayOrder = 1},
                new Category { id = 2, name = "Action", displayOrder = 2},
                new Category { id = 3, name = "Action", displayOrder = 3}
                );
        }

    }
}

/*
    Steps to create tables in DB using Entity framework :
    1) Create a "abc" model in Models folder & inside that create properties.
    2) In ApplicationDbContext.cs, create DbSet for respective table.
    3) Open console manager, add migration (cmd : add-migration migrationName) and 
       update DB(cmd : update-database), it will push migration to DB.
 */
