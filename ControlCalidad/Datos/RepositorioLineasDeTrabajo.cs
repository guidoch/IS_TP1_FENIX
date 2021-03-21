using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class RepositorioLineasDeTrabajo : IRepositorio<LineaTrabajo>
    {
        public static RepositorioLineasDeTrabajo Instancia = new RepositorioLineasDeTrabajo();
        public List<LineaTrabajo> _lineas;

        public RepositorioLineasDeTrabajo()
        {
            _lineas = new List<LineaTrabajo>()
            {
                new LineaTrabajo() { Numero = 0, Descripcion = "Linea 0"},
                new LineaTrabajo() { Numero = 1, Descripcion = "Linea 1" },
                new LineaTrabajo() { Numero = 2, Descripcion = "Linea 2" },
                new LineaTrabajo() { Numero = 3, Descripcion = "Linea 3" }
            };
        }

        public LineaTrabajo BuscarCodigo(int codigo)
        {
            return _lineas.Find(item => item.Numero == codigo);
        }

        public void Guardar(LineaTrabajo objeto)
        {
            _lineas.Add(objeto);
        }

        public LineaTrabajo VerificarExistencia(int codigo)
        {
            return _lineas.Find(item => item.Numero == codigo);
        }
    }
}
