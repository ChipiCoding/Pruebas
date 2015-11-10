using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService.ClassSerializer
{
    [DataContract]
    public class CitySerializer
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }
    }
}
