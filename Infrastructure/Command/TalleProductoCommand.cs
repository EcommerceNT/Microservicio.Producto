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
    public class TalleProductoCommand : ITalleProductoCommand
    {
        private readonly ProductoContext _context;

        public TalleProductoCommand(ProductoContext context)
        {
            _context = context;
        }

        public TalleProducto InsertTalleProducto(TalleProducto talleProducto)
        {
            _context.Add(talleProducto);
            _context.SaveChanges();

            return talleProducto;
        }

        public TalleProducto RemoveTalleProducto(int talleProductoId)
        {
            var talleProducto = _context.TallesProductos
            .FirstOrDefault(x => x.TalleProductoId == talleProductoId);

            _context.Remove(talleProducto);
            _context.SaveChanges();

            return talleProducto;
        }

        public TalleProducto UpdateTalleProducto(TalleProducto talleProducto)
        {
            _context.Update(talleProducto);
            _context.SaveChanges();

            return talleProducto;
        }
    }
}
