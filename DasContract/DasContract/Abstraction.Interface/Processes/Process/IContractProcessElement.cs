using System;
using System.Collections.Generic;
using System.Text;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.Interface.Processes.Process
{
    public interface IContractProcessElement: INamable, IIdentifiable
    {

        IEnumerable<string> IncomingIds { get; }

        IEnumerable<string> OutgoingIds { get; } 
    }
}
