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
    public class LogEventBody
    {
        /// <summary>
        /// 日志标题
        /// </summary>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        /// 日志详细内容
        /// </summary>
        [DataMember]
        public string Detail { get; set; }
    }
}
