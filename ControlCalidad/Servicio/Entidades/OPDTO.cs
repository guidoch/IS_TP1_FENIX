using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Entidades
{
    [DataContract]
    public class OPDTO
    {
        [DataMember]
        public int Numero { get; set; }
        [DataMember]
        public int Modelo { get; set; }
        [DataMember]
        public int Color { get; set; }
        [DataMember]
        public int Hermanado { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public int Linea { get; set; }
        [DataMember]
        public int Supervisor { get; set; }
        /*[DataMember]
        public List<int> ListaPeriodos { get; set; }*/
    }
}
