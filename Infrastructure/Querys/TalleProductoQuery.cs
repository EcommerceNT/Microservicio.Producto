using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class TalleProductoQuery : ITalleProductoQuery
    {
        private readonly ProductoContext _context;

        public TalleProductoQuery(ProductoContext context)
        {
            _context = context;
        }

        public TalleProducto GetTalleProductoById(int talleProductoId)
        {
            var talleProducto = _context.TallesProductos.FirstOrDefault(x => x.TalleProductoId == talleProductoId);

            return talleProducto;
        }

        public List<TalleProducto> GetTalleProductoList()
        {
            var talleProductoList = _context.TallesProductos.ToList();

            return talleProductoList;
        }
    }
}
