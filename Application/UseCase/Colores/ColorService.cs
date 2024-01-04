using Application.Interfaces.ICommand;
using Application.Interfaces.IQuerys;
using Application.Interfaces.IService;
using Application.Request;
using Application.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Colores
{
    public class ColorService : IColorService
    {
        private readonly IColorCommand _command;
        private readonly IColorQuery _query;

        public ColorService(IColorCommand command, IColorQuery query)
        {
            _command = command;
            _query = query;
        }

        public ColorResponse GetColorById(int colorId)
        {
            var color = _query.GetColorById(colorId);

            if (color == null)
            {
                throw new ArgumentException($"No se encontró el color con el identificador {colorId}.");
            }

           return MappingColor(color);
        }

        public List<ColorResponse> GetColorList()
        {
            var colorList = _query.GetColorList();

            List<ColorResponse> colorResponseList = new List<ColorResponse>();

            foreach (var color in colorList)
            {
                colorResponseList.Add(MappingColor(color));
            }

            return colorResponseList;
        }

        public ColorResponse CreateColor(ColorRequest request)
        {
            var color = new Color
            {
                Descripcion = request.Descripcion,
            };

            _command.InsertColor(color);

            return MappingColor(color);
        }

        public ColorResponse RemoveColor(int colorId)
        {
            if (_query.GetColorById(colorId) == null)
            {
                throw new ArgumentException($"No se encontró el color que desea eliminar con el identificador '{colorId}'.");
            }

            var color = _command.RemoveColor(colorId);

            return MappingColor(color);
        }

        public ColorResponse UpdateColor(int colorId, ColorRequest request)
        {
            var color = _query.GetColorById(colorId);

            if (colorId == null)
            {
                throw new ArgumentException($"No se encontró el color con el identificador {colorId}.");
            }

            color.Descripcion = request.Descripcion;

            _command.UpdateColor(color);

            return MappingColor(color);
        }

        private static ColorResponse MappingColor(Color color)
        {
            return new ColorResponse
            {
                Id = color.ColorId,
                Descripcion = color.Descripcion,
            };
        }
    }
}
