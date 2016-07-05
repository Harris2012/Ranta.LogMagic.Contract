using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.LogMagic.Contract
{
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public class LogServiceClient : System.ServiceModel.ClientBase<ILogService>, ILogService
    {

        #region ClientBase Members
        public LogServiceClient()
        {
        }

        public LogServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public LogServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public LogServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public LogServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }
        #endregion

        #region ILogService Members
        public LogResponse WriteLog(LogRequest request)
        {
            return base.Channel.WriteLog(request);
        }

        public Task<LogResponse> CreateTaskOfWriteLog(LogRequest request)
        {
            return base.Channel.CreateTaskOfWriteLog(request);
        }
        #endregion
    }
}
