using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService.ClassSerializer
{
    [DataContract]
    public class CustomerSerializer
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public int idDocumentType { get; set; }

        [DataMember]
        public string documentNumber { get; set; }

        [DataMember]
        public System.DateTime birthdate { get; set; }

        [DataMember]
        public int idCity { get; set; }

        [DataMember]
        public string movilNumber { get; set; }

        [DataMember]
        public string name { get; set; }

        
        [DataMember]
        public virtual CitySerializer City { get; set; }
        [DataMember]
        public virtual DocumentsTypeSerializer DocumentsType { get; set; }
    }
}


