using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Scolar.Data.Entity;
using Results = Scolar.Data.Entity.Results;
using System.Security.Cryptography.X509Certificates;

namespace Scolar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }
        public DbSet<User> users { get; set; }

        public DbSet<Schools> schools { get; set; }

        public DbSet<Questions> questions { get; set; }

        public DbSet<Results> results { get; set; }
        
        public DbSet<Role> role { get; set; }
        
        public DbSet<Answers> answers { get; set; }

        public DbSet<Category> category { get; set; }



    }
}