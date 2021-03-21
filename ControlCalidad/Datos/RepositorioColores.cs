using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioColores : IRepositorio<Color>
    {
        public static RepositorioColores Instancia = new RepositorioColores();
        public List<Color> _colores { get; set; }
        public RepositorioColores()
        {
            _colores = new List<Color>
            {
                new Color() { Codigo = 0, Descripcion = "Blanco"},
                new Color() { Codigo = 1, Descripcion = "Negro"},
                new Color() { Codigo = 2, Descripcion = "Rojo"},
                new Color() { Codigo = 3, Descripcion = "Verde"},
                new Color() { Codigo = 4, Descripcion = "Azul"}
            };
        }
        public Color BuscarCodigo(int codigo)
        {
            return _colores.Find(item => item.Codigo == codigo);
        }

        public void Guardar(Color color)
        {
            _colores.Add(color);
        }

        public Color VerificarExistencia(int codigo)
        {
            return _colores.Find(item => item.Codigo == codigo);
        }
    }
}
