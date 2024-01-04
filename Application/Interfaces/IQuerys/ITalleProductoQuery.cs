using Domain.Entities;

namespace Application.Interfaces.IQuerys
{
    public interface ITalleProductoQuery
    {
        TalleProducto GetTalleProductoById(int talleProductoId);
        List<TalleProducto> GetTalleProductoList();
    }
}
