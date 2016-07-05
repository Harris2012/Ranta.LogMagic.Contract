using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.LogMagic.Contract
{
    [ServiceContract]
    public interface ILogService
    {
        [FaultContract(typeof(FaultException))]
        [OperationContract]
        LogResponse WriteLog(LogRequest request);

        [FaultContract(typeof(FaultException))]
        [OperationContract]
        Task<LogResponse> CreateTaskOfWriteLog(LogRequest request);
    }
}
