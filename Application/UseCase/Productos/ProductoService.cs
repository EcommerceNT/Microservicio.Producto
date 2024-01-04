using Application.Interfaces.ICommand;
using Application.Interfaces.IQuerys;
using Application.Interfaces.IService;
using Application.Request;
using Application.Response;

namespace Application.UseCase.Productos
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoCommand _command;
        private readonly IProductoQuery _query;

        public ProductoService(IProductoCommand command, IProductoQuery query)
        {
            _command = command;
            _query = query;
        }

        public ProductoResponse GetProductoById(int productoId)
        {
            throw new NotImplementedException();
        }

        public List<ProductoResponse> GetProductoList()
        {
            throw new NotImplementedException();
        }

        public ProductoResponse CreateProducto(ProductoRequest request)
        {
            throw new NotImplementedException();
        }

        public ProductoResponse RemoveProducto(int productoId)
        {
            throw new NotImplementedException();
        }

        public ProductoResponse UpdateProducto(int productoId, ProductoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
