using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.LogMagic.Contract
{
    [Serializable]
    [DataContract]
    public class LogEvent
    {
        /// <summary>
        /// 日志头
        /// </summary>
        [DataMember]
        public LogEventHeader Header { get; set; }

        /// <summary>
        /// 日志主体
        /// </summary>
        [DataMember]
        public LogEventBody Body { get; set; }
    }
}
