using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Entidades
{
    [DataContract]
    public class AutenticarDTO
    {
        [DataMember]
        public int Estado { get; set; }
        [DataMember]
        public int Sesion { get; set; }
        [DataMember]
        public int Usuario { get; set; }
        [DataMember]
        public int Empleado { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Cargo { get; set; }
    }
}
