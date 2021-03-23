using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Entidades
{
    [DataContract]
    public class DefectoDTO
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Pie { get; set; }
        [DataMember]
        public int TipoDefectoCodigo { get; set; }
        [DataMember]
        public string TipoDefectoDescripcion { get; set; }
        [DataMember]
        public string TipoDefectoTipo { get; set; }
    }
}
