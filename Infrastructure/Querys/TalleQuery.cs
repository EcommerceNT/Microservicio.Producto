using Application.Interfaces.IQuerys;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Querys
{
    public class TalleQuery : ITalleQuery
    {
        private readonly ProductoContext _context;

        public TalleQuery(ProductoContext context)
        {
            _context = context;
        }

        public Talle GetTalleById(int talleId)
        {
            var talle = _context.Talles.FirstOrDefault(x => x.TalleId == talleId);

            return talle;
        }

        public List<Talle> GetTalleList()
        {
            var talleList = _context.Talles.ToList();

            return talleList;
        }
    }
}
