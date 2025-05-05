using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.Entities;

namespace PointOfSale.DataAccessLayer
{
    public class ECommerceDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasKey(p => p.Id);
            modelBuilder.Entity<Employee>().HasKey(p => p.Id);
            modelBuilder.Entity<Category>().HasKey(cat => cat.Id);
            modelBuilder.Entity<Product>().HasKey(prod => prod.Id);

            modelBuilder.Entity<Category>()
                .HasMany(prod => prod.Products)
                .WithOne(prod => prod.Category)
                .HasForeignKey(prod => prod.Id)
                .HasPrincipalKey(Cat => Cat.Id);
        }
    }
}
