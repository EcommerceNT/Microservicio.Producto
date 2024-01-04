using Domain.Entities;

namespace Application.Interfaces.IQuerys
{
    public interface IColorQuery
    {
        Color GetColorById(int colorId);
        List<Color> GetColorList();
        bool ExisteColor(string color);
    }
}
