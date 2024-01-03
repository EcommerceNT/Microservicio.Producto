using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class TalleProductoConfig : IEntityTypeConfiguration<TalleProducto>
    {
        public void Configure(EntityTypeBuilder<TalleProducto> entityBuilder)
        {
            entityBuilder.ToTable("TalleProducto");
            entityBuilder.HasKey(e => new { e.TalleProductoId });

            entityBuilder.Property(m => m.TalleProductoId).ValueGeneratedOnAdd();
        }
    }
}
