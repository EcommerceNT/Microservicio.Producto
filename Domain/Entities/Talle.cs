using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Talle
    {
        public int TalleId { get; set; }
        public string Descripcion { get; set; }

        public ICollection<TalleProducto> TallesProductos { get; set; }
    }
}
