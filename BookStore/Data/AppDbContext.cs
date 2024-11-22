using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the relationship between Order and User
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User) // One Order has one User
                .WithMany()          // One User can have many Orders
                .HasForeignKey(o => o.UserId) // FK in Order
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when User is deleted

            // Configure the relationship between Order and OrderItem
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order) // One OrderItem has one Order
                .WithMany(o => o.OrderItems) // One Order can have many OrderItems
                .HasForeignKey(oi => oi.OrderId) // FK in OrderItem
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Order is deleted

            // Configure the relationship between OrderItem and Product
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product) // One OrderItem has one Product
                .WithMany() // Products are not dependent on OrderItems
                .HasForeignKey(oi => oi.ProductId) // FK in OrderItem
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of Product if it is linked to an OrderItem

            // Configure additional constraints if necessary
        }
    }
}
