using AccesoExterno.ReferenciaServicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoExterno
{
    public class Adaptador
    {
        public static AutenticarDTO Autenticar(string user, string pass)
        {
            using (var servicio = new ReferenciaServicio.ServicioClient())
            {
                return servicio.Autenticar(user, pass);
            }
        }

        public static bool CerrarSesion(int sesion)
        {
            using (var servicio = new ReferenciaServicio.ServicioClient())
            {
                return servicio.CerrarSesion(sesion);
            }
        }

        public static OPDTO[] ListarOPs(int empleado)
        {
            using (var servicio = new ReferenciaServicio.ServicioClient())
            {
                return servicio.ListarOPs(empleado);
            }
        }

        public static bool ControlarOPsTodasFinalizadas(int empleado)
        {
            using (var servicio = new ReferenciaServicio.ServicioClient())
            {
                return servicio.ControlarOPsTodasFinalizadas(empleado);
            }
        }

        public static bool ReanudarOP(int numero)
        {
            using (var servicio = new ReferenciaServicio.ServicioClient())
            {
                return servicio.ReanudarOP(numero);
            }
        }

        public static bool FinalizarOP(int numero)
        {
            using (var servicio = new ReferenciaServicio.ServicioClient())
            {
                return servicio.FinalizarOP(numero);
            }
        }

        public static bool PausarOP(int numero)
        {
            using (var servicio = new ReferenciaServicio.ServicioClient())
            {
                return servicio.PausarOP(numero);
            }
        }

        public static bool IniciarOP(int numero, int linea, int modelo, int color, int empleado)
        {
            using (var servicio = new ReferenciaServicio.ServicioClient())
            {
                return servicio.IniciarOP(numero, linea, modelo, color, empleado);
            }
        }

        public static ColorDTO[] GetColores()
        {
            using (var servicio = new ReferenciaServicio.ServicioClient())
            {
                return servicio.GetColores();
            }
        }

        public static LineaTrabajoDTO[] GetLineasLibres()
        {
            using (var servicio = new ReferenciaServicio.ServicioClient())
            {
                return servicio.GetLineasLibres();
            }
        }

        public static ModeloDTO[] GetModelos()
        {
            using (var servicio = new ReferenciaServicio.ServicioClient())
            {
                return servicio.GetModelos();
            }
        }

        public static int AsociarOP(int numero, int empleado)
        {
            throw new NotImplementedException();
        }

        public static bool AptoCargarHermanado(int numero)
        {
            using (var servicio = new ReferenciaServicio.ServicioClient())
            {
                return servicio.AptoCargarHermanado(numero);
            }
        }

        public static OPDTO[] ListarOPs()
        {
            using (var servicio = new ReferenciaServicio.ServicioClient())
            {
                return servicio.ListaOPs();
            }
        }

    }
}
