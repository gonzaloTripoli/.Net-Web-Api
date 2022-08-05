using Microsoft.EntityFrameworkCore;
using PrototypeApp.DAL.Model;

namespace Prototype.DAL
{
    public class PrototypeDbContext:DbContext
    {
        public PrototypeDbContext(DbContextOptions<PrototypeDbContext> options)
       : base(options)
        { }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}