﻿// <auto-generated />
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ProductoContext))]
    partial class ProductoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("Color", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ColorProducto", b =>
                {
                    b.Property<int>("ColorProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorProductoId"));

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("ColorProductoId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ColorProducto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductoId"));

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.HasKey("ProductoId");

                    b.ToTable("Producto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Talle", b =>
                {
                    b.Property<int>("TalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TalleId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TalleId");

                    b.ToTable("Talle", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TalleProducto", b =>
                {
                    b.Property<int>("TalleProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TalleProductoId"));

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("TalleId")
                        .HasColumnType("int");

                    b.HasKey("TalleProductoId");

                    b.HasIndex("ProductoId");

                    b.HasIndex("TalleId");

                    b.ToTable("TalleProducto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ColorProducto", b =>
                {
                    b.HasOne("Domain.Entities.Color", "Color")
                        .WithMany("ColoresProductos")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Producto", "Producto")
                        .WithMany("ColoresProductos")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Domain.Entities.TalleProducto", b =>
                {
                    b.HasOne("Domain.Entities.Producto", "Producto")
                        .WithMany("TallesProductos")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Talle", "Talle")
                        .WithMany("TallesProductos")
                        .HasForeignKey("TalleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Talle");
                });

            modelBuilder.Entity("Domain.Entities.Color", b =>
                {
                    b.Navigation("ColoresProductos");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Navigation("ColoresProductos");

                    b.Navigation("TallesProductos");
                });

            modelBuilder.Entity("Domain.Entities.Talle", b =>
                {
                    b.Navigation("TallesProductos");
                });
#pragma warning restore 612, 618
        }
    }
}