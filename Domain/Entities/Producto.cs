using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public string Imagen { get; set; }


        public ICollection<TalleProducto> TallesProductos { get; set; }
        public ICollection<ColorProducto> ColoresProductos { get; set; }
    }
}
