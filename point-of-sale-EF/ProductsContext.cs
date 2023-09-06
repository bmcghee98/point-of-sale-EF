using Microsoft.EntityFrameworkCore;

namespace point_of_sale_EF;

internal class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite($"Data Source = products.db");
}
