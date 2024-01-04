using Application.Interfaces.IQuerys;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class ColorQuery : IColorQuery
    {
        private readonly ProductoContext _context;

        public ColorQuery(ProductoContext context)
        {
            _context = context;
        }

        public Color GetColorById(int colorId)
        {
            var color = _context.Colores.FirstOrDefault(x => x.ColorId == colorId);

            return color;
        }

        public List<Color> GetColorList()
        {
            var colorList = _context.Colores.ToList();

            return colorList;
        }
    }
}