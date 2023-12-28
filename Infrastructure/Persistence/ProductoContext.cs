using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
            modelBuilder.ApplyConfiguration(new TipoMercaderiaConfig());
            modelBuilder.ApplyConfiguration(new TipoMercaderiaData());

            modelBuilder.ApplyConfiguration(new MercaderiaConfig());
            modelBuilder.ApplyConfiguration(new MercaderiaData());

            modelBuilder.ApplyConfiguration(new ComandaMercaderiaConfig());

            modelBuilder.ApplyConfiguration(new ComandaConfig());

            modelBuilder.ApplyConfiguration(new FormaEntregaConfig());
            modelBuilder.ApplyConfiguration(new FormaEntregaData());
        }
    }
}
