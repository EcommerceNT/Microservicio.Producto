using Application.Interfaces.ICommand;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Command
{
    public class ProductoCommand : IProductoCommand
    {
        private readonly ProductoContext _context;

        public ProductoCommand(ProductoContext context)
        {
            _context = context;
        }

        public Producto InsertProducto(Producto producto)
        {
            _context.Add(producto);
            _context.SaveChanges();

            return producto;
        }

        public Producto RemoveProducto(int productoId)
        {
            var producto = _context.Productos
            .FirstOrDefault(x => x.ProductoId == productoId);

            _context.Remove(producto);
            _context.SaveChanges();

            return producto;
        }

        public Producto UpdateProducto(Producto producto)
        {
            _context.Update(producto);
            _context.SaveChanges();

            return producto;
        }
    }
}
