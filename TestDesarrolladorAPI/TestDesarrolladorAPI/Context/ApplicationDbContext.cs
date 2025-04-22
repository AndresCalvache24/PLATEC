using Microsoft.EntityFrameworkCore;
using TestDesarrolladorAPI.Models;

namespace TestDesarrolladorAPI.Context
{

        public class ApplicationDbContext : DbContext
        {
            public DbSet<Products> Product { get; set; }


            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

        }
    }
