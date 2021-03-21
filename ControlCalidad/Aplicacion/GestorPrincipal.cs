using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class GestorPrincipal
    {
        public static bool CerrarSesion(int sesion)
        {
            RepositorioSesiones.Instancia.BuscarCodigo(sesion).Finalizar();
            //RepositorioSesiones.Instancia.Actualizar(Sesion); <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
            return true;
        }
    }
}
