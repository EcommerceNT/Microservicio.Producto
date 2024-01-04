using Application.Request;
using Application.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IService
{
    public interface IColorService
    {
        ColorResponse GetColorById(int colorId);
        List<ColorResponse> GetColorList();
        ColorResponse CreateColor(ColorRequest request);
        ColorResponse RemoveColor(int colorId);
        ColorResponse UpdateColor(int colorId, ColorRequest request);
    }
}
