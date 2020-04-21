namespace Vidly.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Bogus;

    public class ApplicationDbContext : DbContext
    {  
        static ApplicationDbContext()
        {
            System.Data.Entity.Database.SetInitializer(new MyContextInitialize());
        }
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
          
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; } 
        public DbSet<Genre> Genres { get; set; }
        
    }

}