using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService.ClassSerializer
{
    [DataContract]
    public class DocumentsTypeSerializer
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string description { get; set; }
    }
}
