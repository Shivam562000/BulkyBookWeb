using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        // It will create Categories table in DB
        public DbSet<Category> Categories { get; set; }
    }
}

/*
    Steps to create tables in DB using Entity framework :
    1) Create a "abc" model in Models folder & inside that create properties.
    2) In ApplicationDbContext.cs, create DbSet for respective table.
    3) Open console manager, add migration (cmd : add-migration migrationName) and 
       update DB(cmd : update-database), it will push migration to DB.
 */
