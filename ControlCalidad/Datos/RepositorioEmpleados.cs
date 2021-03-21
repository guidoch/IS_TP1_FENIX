using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioEmpleados : IRepositorio<Empleado>
    {
        public static RepositorioEmpleados Instancia = new RepositorioEmpleados();
        public List<Empleado> _empleados { get; set; }
        public RepositorioEmpleados()
        {
            _empleados = new List<Empleado>()
            {
                new Empleado() { Codigo = 0, Cargo = Cargo.ADMIN, Documento = 000, Nombre = "Admin 0", EMail = "@0"},
                new Empleado() { Codigo = 1, Cargo = Cargo.SUP_LINEA, Documento = 111, Nombre = "Sup Linea 1", EMail = "@1"},
                new Empleado() { Codigo = 2, Cargo = Cargo.SUP_LINEA, Documento = 222, Nombre = "Sup Linea 2", EMail = "@2"},
                new Empleado() { Codigo = 3, Cargo = Cargo.SUP_CALIDAD, Documento = 333, Nombre = "Sup Calidad 3", EMail = "@3"},
                new Empleado() { Codigo = 4, Cargo = Cargo.SUP_CALIDAD, Documento = 444, Nombre = "Sup Calidad 4", EMail = "@4"},
                new Empleado() { Codigo = 5, Cargo = Cargo.SUP_CALIDAD, Documento = 555, Nombre = "Sup Calidad 5", EMail = "@5"}
            };
        }

        public Empleado BuscarCodigo(int codigo)
        {
            return _empleados.Find(item => item.Codigo == codigo);
        }

        public void Guardar(Empleado objeto)
        {
            _empleados.Add(objeto);
        }

        public Empleado VerificarExistencia(int codigo)
        {
            return _empleados.Find(item => item.Codigo == codigo);
        }
    }
}
