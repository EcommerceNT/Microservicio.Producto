using Application.Interfaces.ICommand;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
