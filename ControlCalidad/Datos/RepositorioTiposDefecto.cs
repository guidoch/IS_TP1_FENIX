using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class RepositorioTiposDefecto : IRepositorio<TipoDefecto>
    {
        public static RepositorioTiposDefecto Instancia = new RepositorioTiposDefecto();
        public List<TipoDefecto> _tiposdefecto;
        public RepositorioTiposDefecto()
        {
            _tiposdefecto = new List<TipoDefecto>()
            {
                new TipoDefecto() { Codigo = 0, Descripcion = "Defecto OBS 0", Tipo = TipoClaseDefecto.OBSERVADO},
                new TipoDefecto() { Codigo = 1, Descripcion = "Defecto OBS 1", Tipo = TipoClaseDefecto.OBSERVADO},
                new TipoDefecto() { Codigo = 2, Descripcion = "Defecto OBS 2", Tipo = TipoClaseDefecto.OBSERVADO},
                new TipoDefecto() { Codigo = 3, Descripcion = "Defecto REP 3", Tipo = TipoClaseDefecto.REPROCESO},
                new TipoDefecto() { Codigo = 4, Descripcion = "Defecto REP 4", Tipo = TipoClaseDefecto.REPROCESO},
                new TipoDefecto() { Codigo = 5, Descripcion = "Defecto REP 5", Tipo = TipoClaseDefecto.REPROCESO}
            };
        }
        public TipoDefecto BuscarCodigo(int codigo)
        {
            return _tiposdefecto.Find(item => item.Codigo == codigo);
        }

        public void Guardar(TipoDefecto objeto)
        {
            _tiposdefecto.Add(objeto);
        }

        public TipoDefecto VerificarExistencia(int codigo)
        {
            return _tiposdefecto.Find(item => item.Codigo == codigo);
        }
    }
}
