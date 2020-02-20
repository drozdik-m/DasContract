using System;
using System.Collections.Generic;
using System.Text;

namespace DasContract.Abstraction.Interface.Processes.Process
{
    public interface IContractProcess
    {
        IEnumerable<IContractSequenceFlow> SequenceFlows { get; }

        IEnumerable<IContractProcessElement> ProcessElements { get; }
    }
}
