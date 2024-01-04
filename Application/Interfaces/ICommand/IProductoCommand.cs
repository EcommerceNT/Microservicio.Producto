using Domain.Entities;

namespace Application.Interfaces.ICommand
{
    public interface IProductoCommand
    {
        Producto InsertProducto(Producto producto);
        Producto RemoveProducto(int productoId);
        Producto UpdateProducto(Producto producto);
    }
}
