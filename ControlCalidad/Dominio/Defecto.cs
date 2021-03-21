using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Defecto
    {
        public int Codigo { get; set; }
        public Pie Pie { get; set; }
        public TipoDefecto TipoDefecto { get; set; }
    }
}
