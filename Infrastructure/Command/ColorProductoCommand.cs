using Application.Interfaces.ICommand;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class ColorProductoCommand : IColorProductoCommand
    {
        private readonly ProductoContext _context;

        public ColorProductoCommand(ProductoContext context)
        {
            _context = context;
        }

        public ColorProducto InsertColorProducto(ColorProducto colorProducto)
        {
            _context.Add(colorProducto);
            _context.SaveChanges();

            return colorProducto;
        }

        public ColorProducto RemoveColorProducto(int colorProductoId)
        {
            var colorProducto = _context.ColoresProductos
            .FirstOrDefault(x => x.ColorProductoId == colorProductoId);

            _context.Remove(colorProducto);
            _context.SaveChanges();

            return colorProducto;
        }

        public ColorProducto UpdateColorProducto(ColorProducto colorProducto)
        {
            _context.Update(colorProducto);
            _context.SaveChanges();

            return colorProducto;
        }
    }
}
