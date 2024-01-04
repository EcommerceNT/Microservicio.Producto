using Application.Interfaces.ICommand;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class ColorCommand : IColorCommand
    {
        private readonly ProductoContext _context;

        public ColorCommand(ProductoContext context)
        {
            _context = context;
        }

        public Color InsertColor(Color color)
        {
            _context.Add(color);
            _context.SaveChanges();

            return color;
        }

        public Color RemoveColor(int colorId)
        {
            var color = _context.Colores
            .FirstOrDefault(x => x.ColorId == colorId);

            _context.Remove(color);
            _context.SaveChanges();

            return color;
        }

        public Color UpdateColor(Color color)
        {
            _context.Update(color);
            _context.SaveChanges();

            return color;
        }
    }
}
