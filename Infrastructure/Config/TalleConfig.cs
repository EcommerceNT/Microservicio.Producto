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
    public class TalleConfig : IEntityTypeConfiguration<Talle>
    {
        public void Configure(EntityTypeBuilder<Talle> entityBuilder)
        {
            entityBuilder.ToTable("Talle");
            entityBuilder.HasKey(e => e.TalleId);

            entityBuilder.HasMany(m => m.TallesProductos)
            .WithOne(cm => cm.Talle)
            .HasForeignKey(cm => cm.TalleId);
        }
    }
}
