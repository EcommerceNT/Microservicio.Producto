using Domain.Entities;

namespace Application.Interfaces.ICommand
{
    public interface ITalleProductoCommand
    {
        TalleProducto InsertTalleProducto(TalleProducto talleProducto);
        TalleProducto RemoveTalleProducto(int talleProductoId);
        TalleProducto UpdateTalleProducto(TalleProducto talleProducto);
    }
}
