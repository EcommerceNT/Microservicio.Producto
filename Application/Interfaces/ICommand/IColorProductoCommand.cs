using Domain.Entities;

namespace Application.Interfaces.ICommand
{
    public interface IColorProductoCommand
    {
        ColorProducto InsertColorProducto(ColorProducto colorProducto);
        ColorProducto RemoveColorProducto(int colorProductoId);
        ColorProducto UpdateColorProducto(ColorProducto colorProducto);
    }
}
