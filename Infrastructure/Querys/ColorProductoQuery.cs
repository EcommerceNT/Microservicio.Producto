﻿using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class ColorProductoQuery : IColorProductoQuery
    {
        private readonly ProductoContext _context;

        public ColorProductoQuery(ProductoContext context)
        {
            _context = context;
        }

        public ColorProducto GetColorProductoById(int colorProductoId)
        {
            var colorProducto = _context.ColoresProductos.FirstOrDefault(x => x.ColorProductoId == colorProductoId);

            return colorProducto;
        }

        public List<ColorProducto> GetColorProductoList()
        {
            var colorProductoList = _context.ColoresProductos.ToList();
            
            return colorProductoList;
        }
    }
}