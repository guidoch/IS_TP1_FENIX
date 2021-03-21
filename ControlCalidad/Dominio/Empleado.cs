using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado
    {
        public int Codigo { get; set; }
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string EMail { get; set; }
        public Cargo Cargo { get; set; }
        //public Usuario Usuario { get; set; }

        public override string ToString()
        {
            return Nombre.ToString();
        }
    }
}
