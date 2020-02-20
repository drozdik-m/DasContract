using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface.Processes.Process;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.SimpleContract.Processes.Process
{
    public class SimpleContractProcessElement : IContractProcessElement
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        

        IEnumerable<string> IContractProcessElement.IncomingIds => IncomingIds;
        List<string> IncomingIds { get; set; } = new List<string>();

        IEnumerable<string> IContractProcessElement.OutgoingIds => OutgoingIds;
        List<string> OutgoingIds { get; set; } = new List<string>();

    }
}
