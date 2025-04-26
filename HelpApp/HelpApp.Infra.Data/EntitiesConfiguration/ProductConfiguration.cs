using HelpApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpApp.Infra.Data.EntitiesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Price).HasPrecision(10, 2);

            builder.HasOne(e => e.Category).WithMany(e => e.Products)
                .HasForeignKey(e => e.CategoryId);

            builder.HasData(
                new Product(1, "Caderno", "Caderno Espiral 100 folhas", 9.45m, 50, "caderno.jpg")
                {
                    CategoryId = 1
                },
                new Product(2, "Borracha", "Borracha branca pequena", 3.75m, 80, "borracha.jpg")
                {
                    CategoryId = 1
                },
                new Product(3, "Smartphone", "Smartphone 128GB", 1299.99m, 10, "smartphone.jpg")
                {
                    CategoryId = 2
                }
            );
        }
    }
}
