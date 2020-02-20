using System.Collections.Generic;

namespace DasContract.Abstraction.Interface.Processes.Process.Gateways
{
    public interface IGateway : IContractProcessElement
    {
        public string DefaultSequenceFlowId { get; set; }
    }
}
