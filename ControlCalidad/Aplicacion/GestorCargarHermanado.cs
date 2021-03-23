using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class GestorCargarHermanado
    {
        public static bool CargarHermanado(int hermanado, int codOp)
        {
            var op = RepositorioOP.Instancia.BuscarCodigo(codOp);
            if (!op.Estado.Equals(Estado.FINALIZADA))
            {
                op.Hermanado += hermanado;
                RepositorioOP.Instancia.Actualizar(op);//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                return true;
            }
            else
            {
                return false;
            }
        }

        public static OP GetOP(int numero)
        {
            return RepositorioOP.Instancia.BuscarCodigo(numero);
        }



        /*//private PresentadorCargarHermanado _presentador;
        public OP OP { get; set; }

        public GestorCargarHermanado(PresentadorCargarHermanado presentador, int numero)
        {
            //this._presentador = presentador;
            this.OP = RepositorioOP.Instancia.BuscarCodigo(numero);
        }

        internal bool CargarHermanado(int hermanado)
        {
            //controlar op no finalizada
            if (!OP.Estado.Equals(Estado.FINALIZADA))
            {
                OP.Hermanado += hermanado;
                RepositorioOP.Instancia.Actualizar(OP);//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
