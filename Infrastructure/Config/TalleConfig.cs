using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
