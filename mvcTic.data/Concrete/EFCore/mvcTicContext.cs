using mvcGiris.entity;
using Microsoft.EntityFrameworkCore;

namespace mvcTic.data.Concrete.EFCore
{
    public class mvcTicContext:DbContext
    {
        public DbSet<Product> Products {get; set;}
        public DbSet<Category> Categories {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=mvcTicDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasKey(c=>new{c.CategoryId, c.ProductId});
        }
    }
}