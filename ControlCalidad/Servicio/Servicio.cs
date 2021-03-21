using Aplicacion;
using Dominio;
using Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Servicio : IServicio
    {
        public AutenticarDTO Autenticar(string user, string pass)
        {
            var aux = GestorAutenticar.Autenticar(user, pass);
            if (aux.Item1 == null)
            {
                return new AutenticarDTO() { Estado = aux.Item2 };
            }
            else
            {
                var login = new AutenticarDTO()
                {
                    Estado = aux.Item2,
                    Sesion = aux.Item1.Codigo,
                    Usuario = aux.Item1.User.Codigo,
                    Empleado = aux.Item1.User.Empleado.Codigo,
                    Nombre = aux.Item1.User.Empleado.Nombre
                };
                switch (aux.Item1.User.Empleado.Cargo)
                {
                    case Cargo.SUP_LINEA:
                        login.Cargo = Cargo.SUP_LINEA.ToString();
                        break;
                    case Cargo.SUP_CALIDAD:
                        login.Cargo = Cargo.SUP_CALIDAD.ToString();
                        break;
                    case Cargo.ADMIN:
                        login.Cargo = Cargo.ADMIN.ToString();
                        break;
                    default:
                        break;
                }
                return login;
            }
        }
    }
}
