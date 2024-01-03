using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class ProductoConfig : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> entityBuilder)
        {
            entityBuilder.ToTable("Producto");
            entityBuilder.HasKey(e => e.ProductoId);

            entityBuilder.HasMany(m => m.ColoresProductos)
            .WithOne(cm => cm.Producto)
            .HasForeignKey(cm => cm.ProductoId);
        }
    }
}
