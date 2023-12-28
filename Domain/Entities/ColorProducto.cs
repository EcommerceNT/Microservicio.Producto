using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ColorProducto
    {
        public int ColorProductoId { set; get; }

        public int ColorId { set; get; }
        public Color Color { set; get; }

        public int ProductoId { set; get; }
        public Producto Producto { set; get; }
    }
}
