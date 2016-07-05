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
    public class LogEventHeader
    {
        /// <summary>
        /// 应用程序编号
        /// </summary>
        [DataMember]
        public int AppId { get; set; }

        /// <summary>
        /// 事件源
        /// </summary>
        [DataMember]
        public string Source { get; set; }

        /// <summary>
        /// 日志类型
        /// </summary>
        [DataMember]
        public LogEventType LogEventType { get; set; }

        /// <summary>
        /// 创建日志的时间
        /// </summary>
        [DataMember]
        public DateTime CreateTime { get; set; }
    }
}
