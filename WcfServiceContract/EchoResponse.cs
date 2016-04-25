using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceContract
{
    [DataContract]
    public class EchoResponse
    {
        [DataMember]
        public bool IsChannelOpen { get; set; }
        [DataMember]
        public string Text { get; set; }
    }
}
