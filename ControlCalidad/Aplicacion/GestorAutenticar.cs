using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class GestorAutenticar
    {
        public static (Sesion, int) Autenticar(string user, string pass)
        {
            var usuario = RepositorioUsuarios.Instancia.BuscarUsername(user);

            if (usuario != null)
            {
                if (RepositorioSesiones.Instancia.ConsultarUsuarioLibre(user))
                {
                    if (usuario.Password == pass)
                    {
                        var sesion = new Sesion(RepositorioSesiones.Instancia._sesiones.Count(), usuario);
                        RepositorioSesiones.Instancia.Guardar(sesion);
                        return (sesion, 0);
                    }
                    else
                    {
                        return (null, 1);
                    }
                }
                else
                {
                    return (null, 2);
                }
            }
            return (null, 1);
        }
    }
}
