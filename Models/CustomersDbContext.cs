
using Microsoft.EntityFrameworkCore;

 

namespace CustomersApi.Models
{
    public class CustomersDbContext : DbContext
    {
        public CustomersDbContext(DbContextOptions<CustomersDbContext> options)
        : base(options)
        { }
        public DbSet<Customer> Customers { set; get; }
   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasData(
            new Customer { Name = "Emily Brie", Email = "Email@Email.com",id=1 },
            new Customer { Name = "John Tien", Email = "Tien@abc.com",id=2 }
            );
        }
    }




}


