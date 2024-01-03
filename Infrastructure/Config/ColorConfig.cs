using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
