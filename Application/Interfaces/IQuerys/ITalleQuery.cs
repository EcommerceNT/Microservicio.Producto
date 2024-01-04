using Domain.Entities;

namespace Application.Interfaces.IQuerys
{
    public interface ITalleQuery
    {
        Talle GetTalleById(int talleId);
        List<Talle> GetTalleList();
    }
}
