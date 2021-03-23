using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Entidades
{
    [DataContract]
    public class TopDTO
    {
        //[DataMember]
        public DataTable GetTbl()
{
            DataTable tbl = new DataTable("testTbl");
            //Populate table with SQL query

            return tbl;
        }
    }
}
