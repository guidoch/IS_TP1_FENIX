﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Empleado Empleado { get; set; }

    }
}
