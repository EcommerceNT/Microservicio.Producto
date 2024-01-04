using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ICommand
{
    public interface IColorCommand
    {
        Color InsertColor(Color color);
        Color RemoveColor(int colorId);
        Color UpdateColor(Color color);
    }
}
