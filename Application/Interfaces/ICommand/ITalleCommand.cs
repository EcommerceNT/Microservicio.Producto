using Domain.Entities;

namespace Application.Interfaces.ICommand
{
    public interface ITalleCommand
    {
        Talle InsertTalle(Talle talle);
        Talle RemoveTalle(int talleId);
        Talle UpdateTalle(Talle talle);
    }
}
