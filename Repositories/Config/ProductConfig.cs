using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config;
public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {

        builder.HasKey(p => p.ProductId);
        builder.Property(p => p.ProductName).IsRequired();
        builder.Property(p => p.Price).IsRequired();

        builder.HasData(
            new Product(){ ProductId=1, ProductName="Monitor", Price=19_000, CategoryId=1, ImageUrl="/images/MSI_MAG_274URFW.webp", ShowCase = false},
            new Product(){ ProductId=2, ProductName="Adjustable Desk", Price=11_000, CategoryId=2, ImageUrl="/images/adjustable_desk.webp", ShowCase = true},
            new Product(){ ProductId=3, ProductName="Gaming Chair", Price=7_999, CategoryId=2, ImageUrl="/images/Rampage_Gaming_Chair.webp", ShowCase = false},
            new Product(){ ProductId=4, ProductName="Keyboard and Mouse Set", Price=2_400, CategoryId=1, ImageUrl="/images/MSI_keyboard_mouse.webp", ShowCase = false},
            new Product(){ ProductId=5, ProductName="Case", Price=6_100, CategoryId=1, ImageUrl="/images/MSI_MAG_Case.webp", ShowCase = false},
            new Product(){ ProductId=6, ProductName="Curtain", Price=15_000, CategoryId=2, ImageUrl="/images/curtain.webp", ShowCase = false},
            new Product(){ ProductId=7, ProductName="Earbuds", Price=1_500, CategoryId=1, ImageUrl="/images/earbuds.webp", ShowCase = false},
            new Product(){ ProductId=8, ProductName="Vacuum cleaner", Price=25_000, CategoryId=1, ImageUrl="/images/supurge.jpg", ShowCase = false},
            new Product(){ ProductId=9, ProductName="Sofa", Price=50_0000, CategoryId=2, ImageUrl="/images/sofa.webp", ShowCase = true},
            new Product(){ ProductId=10, ProductName="Wardrobe", Price=14_999, CategoryId=2, ImageUrl="/images/wardrobe.jpg", ShowCase = true}
        );
    }
}