using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ICommand
{
    public interface IColorProductoCommand
    {
        ColorProducto InsertColorProducto(ColorProducto colorProducto);
        ColorProducto RemoveColorProducto(int colorProductoId);
        ColorProducto UpdateColorProducto(ColorProducto colorProducto);
    }
}
