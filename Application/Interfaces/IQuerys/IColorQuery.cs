using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IQuerys
{
    public interface IColorQuery
    {
        Color GetColorById(int colorId);
        List<Color> GetColorList();
    }
}
