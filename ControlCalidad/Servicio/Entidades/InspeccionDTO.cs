using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Entidades
{
    [DataContract]
    public class InspeccionDTO
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public DateTime FechaYHora { get; set; }
        [DataMember]
        public List<DefectoDTO> ListaDefectos { get; set; }
    }
}
