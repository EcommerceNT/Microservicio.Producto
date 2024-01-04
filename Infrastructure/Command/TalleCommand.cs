using Application.Interfaces.ICommand;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class TalleCommand : ITalleCommand
    {
        private readonly ProductoContext _context;

        public TalleCommand(ProductoContext context)
        {
            _context = context;
        }

        public Talle InsertTalle(Talle talle)
        {
            _context.Add(talle);
            _context.SaveChanges();

            return talle;
        }

        public Talle RemoveTalle(int talleId)
        {
            var talle = _context.Talles

            .FirstOrDefault(x => x.TalleId == talleId);

            _context.Remove(talle);
            _context.SaveChanges();

            return talle;
        }

        public Talle UpdateTalle(Talle talle)
        {
            _context.Update(talle);
            _context.SaveChanges();

            return talle;
        }
    }
}
