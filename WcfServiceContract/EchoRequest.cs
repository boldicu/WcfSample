using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceContract
{
    [DataContract]
    public class EchoRequest
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Text { get; set; }
    }
}
