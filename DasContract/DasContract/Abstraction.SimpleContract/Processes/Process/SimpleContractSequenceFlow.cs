using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface.Processes.Process;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.SimpleContract.Processes.Process
{
    /// <summary>
    /// An arrow between process elements. 
    /// </summary>
    public class SimpleContractSequenceFlow : IContractSequenceFlow
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string SourceId { get; set; }
        public string TargetId { get; set; }
        public string Condition { get; set; }
        
    }
}
