using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
    public class ShopDbContext : DbContext
    {
        
        public ShopDbContext(DbContextOptions<ShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ánh xạ các seed dữ liệu
            DataSeeder.Seed(modelBuilder);
        }

        public List<Product>GetProducts()=>Products.ToList();
        public List<Category>GetCategories()=>Categories.ToList();
    }

}
