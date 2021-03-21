using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Entidades
{
    [DataContract]
    public class ModeloDTO
    {
        [DataMember]
        public int SKU { get; set; }
        [DataMember]
        public string Denominacion { get; set; }
        [DataMember]
        public int Objetivo { get; set; }

    }
}
