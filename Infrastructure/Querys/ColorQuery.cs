using Application.Interfaces.IQuerys;
using Domain.Entities;
using Infrastructure.Persistence;

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

        public bool ExisteColor(string color)
        {
            bool existeColor = _context.Colores
                .Any(x => x.Descripcion.ToLower() == color.ToLower());

            if (existeColor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}