using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class GestorIniciarOP
    {
        public static List<Modelo> ListarModelos()
        {
            return RepositorioModelos.Instancia._modelos;
        }

        public static List<Color> ListarColores()
        {
            return RepositorioColores.Instancia._colores;
        }

        public static List<LineaTrabajo> ListarLineasLibres()
        {
            return RepositorioOP.Instancia.ListarLineasLibres();
        }

        public static bool IniciarOP(int numero, int linea, int modelo, int color, int supervisor)
        {
            if (RepositorioOP.Instancia.VerificarLineaLibre(linea)) // REPRESENTAR EN EL MODELO??? creeemos que ya no hace falta
            {
                if (RepositorioOP.Instancia.GuardarSeguro(new OP(
                numero,
                RepositorioEmpleados.Instancia.BuscarCodigo(supervisor),
                RepositorioModelos.Instancia.BuscarCodigo(modelo),
                RepositorioColores.Instancia.BuscarCodigo(color),
                RepositorioLineasDeTrabajo.Instancia.BuscarCodigo(linea)
                )))
                {
                    return true; //MessageBox.Show("OP creada", "Aviso");
                }
                else return false; //MessageBox.Show("Linea ocupada", "Aviso");
            }
            else
            {
                return false; //MessageBox.Show("Linea ocupada", "Aviso");
            }
        }

        /*//private PresentadorIniciarOP _presentador;
        public Empleado Supervisor { get; set; }

        public GestorIniciarOP(PresentadorIniciarOP presentadorIniciarOP, int codSup)
        {
            //this._presentador = presentadorIniciarOP;
            this.Supervisor = RepositorioEmpleados.Instancia.BuscarCodigo(codSup);
        }

        internal bool IniciarOP(int numero, int linea, int modelo, int color)
        {
            if (RepositorioOP.Instancia.VerificarLineaLibre(linea)) // REPRESENTAR EN EL MODELO??? creeemos que ya no hace falta
            {
                if (RepositorioOP.Instancia.GuardarSeguro(new OP(
                numero,
                Supervisor,
                RepositorioModelos.Instancia.BuscarCodigo(modelo),
                RepositorioColores.Instancia.BuscarCodigo(color),
                RepositorioLineasDeTrabajo.Instancia.BuscarCodigo(linea)
                )))
                {
                    return true; //MessageBox.Show("OP creada", "Aviso");
                }
                else return false; //MessageBox.Show("Linea ocupada", "Aviso");
            }
            else
            {
                return false; //MessageBox.Show("Linea ocupada", "Aviso");
            }
        }

        internal object ListarModelos()
        {
            return RepositorioModelos.Instancia._modelos;
        }

        internal object ListarColores()
        {
            return RepositorioColores.Instancia._colores;
        }

        internal object ListarLineasLibres()
        {
            return RepositorioOP.Instancia.ListarLineasLibres();
        }*/
    }
}
