using System.Collections.Generic;
using DasContract.Abstraction.Interface.Processes.Process.Gateways;

namespace DasContract.Abstraction.SimpleContract.Processes.Process.Gateways
{
    public class SimpleGateway : SimpleContractProcessElement, IGateway 
    {
        public string DefaultSequenceFlowId { get; set; }
    }
}
