using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Entidades
{
    [DataContract]
    public class LineaTrabajoDTO
    {
        [DataMember]
        public int Numero { get; set; }
        [DataMember]
        public string Descripcion { get; set; }

    }
}
