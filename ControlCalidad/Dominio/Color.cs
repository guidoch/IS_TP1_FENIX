﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Color
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion.ToString();
        }
    }
}
