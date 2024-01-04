using Domain.Entities;

namespace Application.Interfaces.IQuerys
{
    public interface IColorProductoQuery
    {
        ColorProducto GetColorProductoById(int colorProductoId);
        List<ColorProducto> GetColorProductoList();
    }
}
