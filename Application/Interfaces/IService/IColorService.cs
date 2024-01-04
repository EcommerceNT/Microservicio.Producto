using Application.Request;
using Application.Response;

namespace Application.Interfaces.IService
{
    public interface IColorService
    {
        ColorResponse GetColorById(int colorId);
        List<ColorResponse> GetColorList();
        ColorResponse CreateColor(ColorRequest request);
        ColorResponse RemoveColor(int colorId);
        ColorResponse UpdateColor(int colorId, ColorRequest request);
        bool ExisteColor(string color);
    }
}
