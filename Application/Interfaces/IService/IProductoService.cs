using Application.Request;
using Application.Response;

namespace Application.Interfaces.IService
{
    public interface IProductoService
    {
        ProductoResponse GetProductoById(int productoId);
        List<ProductoResponse> GetProductoList();
        ProductoResponse CreateProducto(ProductoRequest request);
        ProductoResponse RemoveProducto(int productoId);
        ProductoResponse UpdateProducto(int productoId, ProductoRequest request);
    }
}
