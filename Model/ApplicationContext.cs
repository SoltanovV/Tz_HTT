using Microsoft.EntityFrameworkCore;
using Tz_HTT.Model.Entity;

namespace Tz_HTT.Model;

public class ApplicationContext : DbContext
{
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Заполнение данными по умолчанию
        var product1 = new Product()
        {
            Id = 1,
            Name = "Iphone 12 Pro Max",
            Price = 120000,
            CategoryId = 1
        };
        var product2 = new Product()
        {
            Id = 2,
            Name = "Sony PlayStation 5",
            Price = 55000,
            CategoryId = 2
        };
        var product3 = new Product()
        {
            Id = 3,
            Name = "Audi RS7 Sportback",
            Price = 3300000,
            CategoryId = 3
        };
        #endregion

        var products = new List<Product>(){ product1, product2, product3 };

        #region Заполнение данными по умолчанию
        var category1 = new Category()
        {
            Id = 1,
            NameCategory = "Айфоны",
            ProductId = 1,
        };

        var category2 = new Category()
        {
            Id = 2,
            NameCategory = "Консоли",
            ProductId = 2,
        };

        var category3 = new Category()
        {
            Id = 3,
            NameCategory = "Автомобили",
            ProductId = 3
        };
        #endregion

        var categories = new List<Category>() { category1, category2, category3 };

        //Заполнение таблиц данными по умолчанию
        modelBuilder.Entity<Product>().HasData(products);
        modelBuilder.Entity<Category>().HasData(categories);

        // Создание свази один ко многим
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Product)
            .HasForeignKey(p => p.Id);
    }
}
