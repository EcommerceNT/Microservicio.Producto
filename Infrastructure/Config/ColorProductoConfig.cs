using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class ColorProductoConfig : IEntityTypeConfiguration<ColorProducto>
    {
        public void Configure(EntityTypeBuilder<ColorProducto> entityBuilder)
        {
            entityBuilder.ToTable("ColorProducto");
            entityBuilder.HasKey(e => new { e.ColorProductoId });

            entityBuilder.Property(m => m.ColorProductoId).ValueGeneratedOnAdd();
        }
    }
}
