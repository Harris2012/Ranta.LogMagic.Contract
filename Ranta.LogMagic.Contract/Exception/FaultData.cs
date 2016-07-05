using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.LogMagic.Contract
{
    [DataContract]
    public class FaultData
    {
        [DataMember]
        public string Message { get; set; }
    }
}
