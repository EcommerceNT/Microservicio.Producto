using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class ColorConfig : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> entityBuilder)
        {
            entityBuilder.ToTable("Color");
            entityBuilder.HasKey(e => e.ColorId);

            entityBuilder.HasMany(m => m.ColoresProductos)
            .WithOne(cm => cm.Color)
            .HasForeignKey(cm => cm.ColorId);
        }
    }
}
