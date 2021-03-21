using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sesion
    {
        public Sesion(int cod, Usuario usuario)
        {
            this.Codigo = cod;
            this.User = usuario;
            this.Inicio = DateTime.Now;
        }

        public int Codigo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public Usuario User { get; set; }

        public void Finalizar()
        {
            this.Fin = DateTime.Now;
        }
    }
}
