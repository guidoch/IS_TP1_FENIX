using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class RepositorioUsuarios : IRepositorio<Usuario>
    {
        public static RepositorioUsuarios Instancia = new RepositorioUsuarios();
        public List<Usuario> _usuarios { get; set; }
        public RepositorioUsuarios()
        {
            _usuarios = new List<Usuario>
            {
                new Usuario() { Codigo = 0, Username = "user0", Password = "123", Empleado = RepositorioEmpleados.Instancia.BuscarCodigo(0)},
                new Usuario() { Codigo = 1, Username = "user1", Password = "123", Empleado = RepositorioEmpleados.Instancia.BuscarCodigo(1)},
                new Usuario() { Codigo = 2, Username = "user2", Password = "123", Empleado = RepositorioEmpleados.Instancia.BuscarCodigo(2)},
                new Usuario() { Codigo = 3, Username = "user3", Password = "123", Empleado = RepositorioEmpleados.Instancia.BuscarCodigo(3)},
                new Usuario() { Codigo = 4, Username = "user4", Password = "123", Empleado = RepositorioEmpleados.Instancia.BuscarCodigo(4)},
                new Usuario() { Codigo = 5, Username = "user5", Password = "123", Empleado = RepositorioEmpleados.Instancia.BuscarCodigo(5)}

            };
        }

        public Usuario BuscarUsername(string user)
        {
            return _usuarios.Find(item => item.Username == user);
        }

        public Usuario BuscarCodigo(int codigo)
        {
            return _usuarios.Find(item => item.Codigo == codigo);
        }

        public void Guardar(Usuario objeto)
        {
            _usuarios.Add(objeto);
        }

        public Usuario VerificarExistencia(int codigo)
        {
            return _usuarios.Find(item => item.Codigo == codigo);
        }
    }
}
