using Domain.Entities;

namespace Application.Interfaces.IQuerys
{
    public interface IProductoQuery
    {
        Producto GetProductoById(int productoId);
        List<Producto> GetProductoList();
    }
}
