﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Color
    {
        public int ColorId { get; set; }
        public string Descripcion { get; set; }

        public ICollection<ColorProducto> ColoresProductos { get; set; }
    }
}
