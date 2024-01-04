﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ICommand
{
    public interface ITalleProductoCommand
    {
        TalleProducto InsertTalleProducto(TalleProducto talleProducto);
        TalleProducto RemoveTalleProducto(int talleProductoId);
        TalleProducto UpdateTalleProducto(TalleProducto talleProducto);
    }
}
