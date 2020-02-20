using System;
using System.Collections.Generic;
using System.Text;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.Interface.Processes.Process
{
    public interface IContractProcessElement: INamable, IIdentifiable
    {

        ICollection<string> IncomingIds { get; }

        ICollection<string> OutgoingIds { get; } 
    }
}
