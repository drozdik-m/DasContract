using System;
using System.Collections.Generic;
using System.Text;

namespace DasContract.Abstraction.Interface.Processes.Process
{
    public interface IContractProcess
    {
        ICollection<IContractSequenceFlow> SequenceFlows { get; }

        ICollection<IContractSequenceFlow> ProcessElements { get; }
    }
}
