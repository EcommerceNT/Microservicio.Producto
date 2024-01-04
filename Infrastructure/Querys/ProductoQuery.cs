using Application.Interfaces.IQuerys;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Querys
{
    public class ProductoQuery : IProductoQuery
    {
        private readonly ProductoContext _context;

        public ProductoQuery(ProductoContext context)
        {
            _context = context;
        }

        public Producto GetProductoById(int productoId)
        {
            var producto = _context.Productos.FirstOrDefault(x => x.ProductoId == productoId);

            return producto;
        }

        public List<Producto> GetProductoList()
        {
            var productoList = _context.Productos.ToList();

            return productoList;
        }
    }
}
