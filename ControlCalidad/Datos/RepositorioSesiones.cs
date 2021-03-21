using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class RepositorioSesiones : IRepositorio<Sesion>
    {
        public static RepositorioSesiones Instancia = new RepositorioSesiones();
        public List<Sesion> _sesiones { get; set; }
        public RepositorioSesiones()
        {
            _sesiones = new List<Sesion>() { };
        }
        public Sesion BuscarCodigo(int codigo)
        {
            return _sesiones.Find(item => item.Codigo == codigo);
        }

        public void Guardar(Sesion objeto)
        {
            _sesiones.Add(objeto);
        }

        public bool ConsultarUsuarioLibre(string user)
        {
            foreach (var sesion in _sesiones)
            {
                if (sesion.User.Username == user && sesion.Fin.Equals(new DateTime())) return false;
            }
            return true;
        }

        public Sesion VerificarExistencia(int codigo)
        {
            return _sesiones.Find(item => item.Codigo == codigo);
        }

        public Sesion BuscarSesion(string user)
        {
            Sesion s = null;
            foreach (var sesion in _sesiones)
            {
                if (sesion.User.Username == user && sesion.Fin.Equals(new DateTime())) s = sesion;
            }
            return s;
        }
    }
}

