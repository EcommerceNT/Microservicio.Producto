using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

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
