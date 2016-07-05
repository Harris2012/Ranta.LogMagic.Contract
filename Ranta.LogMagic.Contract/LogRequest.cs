using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.LogMagic.Contract
{
    [DataContract]
    public class LogRequest
    {
        /// <summary>
        /// 消息编号
        /// </summary>
        [DataMember]
        public Guid Guid { get; set; }

        /// <summary>
        /// 日志实体
        /// </summary>
        [DataMember]
        public LogEvent LogEvent { get; set; }
    }
}
