using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ICommand
{
    public interface ITalleCommand
    {
        Talle InsertTalle(Talle talle);
        Talle RemoveTalle(int talleId);
        Talle UpdateTalle(Talle talle);
    }
}
