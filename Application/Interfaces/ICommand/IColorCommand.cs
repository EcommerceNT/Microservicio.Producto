using Domain.Entities;

namespace Application.Interfaces.ICommand
{
    public interface IColorCommand
    {
        Color InsertColor(Color color);
        Color RemoveColor(int colorId);
        Color UpdateColor(Color color);
    }
}
