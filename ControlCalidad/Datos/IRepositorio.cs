using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    interface IRepositorio<R>
    {
        R BuscarCodigo(int codigo);

        R VerificarExistencia(int codigo);

        void Guardar(R objeto);
    }
}
