using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
