namespace Chapter5DataAccess.Data
{
    using Chapter5DataAccess.Models;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure entity properties and relationships
        }

        public static void Seed(ApplicationDbContext context)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            // Check if there are any entities in the database
            if (context.Products.Any())
            {
                return;   // Database has been seeded
            }

            // Create some initial entities
            var entities = new List<Product>()
            {
                new() { Id = 1, ProductName = "Product 1", Price = 10.99m },
                new() { Id = 2, ProductName = "Product 2", Price = 20.99m },
                new() { Id = 3, ProductName = "Product 3", Price = 30.99m },
                new() { Id = 4, ProductName = "Product 4", Price = 40.99m },
                new() { Id = 5, ProductName = "Product 5", Price = 50.99m },
                new() { Id = 6, ProductName = "Product 6", Price = 60.99m },
                new() { Id = 7, ProductName = "Product 7", Price = 70.99m },
                new() { Id = 8, ProductName = "Product 8", Price = 80.99m },
                new() { Id = 9, ProductName = "Product 9", Price = 90.99m },
                new() { Id = 10, ProductName = "Product 10", Price = 100.99m }
            };

            // Add entities to the context
            context.Products.AddRange(entities);

            // Save changes to the database
            context.SaveChanges();
        }
    }

}
