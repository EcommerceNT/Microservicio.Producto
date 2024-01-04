using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ICommand
{
    public interface IProductoCommand
    {
        Producto InsertProducto(Producto producto);
        Producto RemoveProducto(int productoId);
        Producto UpdateProducto(Producto producto);
    }
}
