using Domain.Entities;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ProductoContext : DbContext
    {
        public DbSet<Color> Colores { get; set; }
        public DbSet<ColorProducto> ColoresProductos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Talle> Talles { get; set; }
        public DbSet<TalleProducto> TallesProductos { get; set; }

        public ProductoContext(DbContextOptions<ProductoContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ColorConfig());
            modelBuilder.ApplyConfiguration(new ColorProductoConfig());
            modelBuilder.ApplyConfiguration(new ProductoConfig());
            modelBuilder.ApplyConfiguration(new TalleConfig());
            modelBuilder.ApplyConfiguration(new TalleProductoConfig());
        }
    }
}
