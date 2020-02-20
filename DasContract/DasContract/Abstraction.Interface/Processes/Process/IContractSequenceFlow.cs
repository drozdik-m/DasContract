using System;
using System.Collections.Generic;
using System.Text;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.Interface.Processes.Process
{
    /// <summary>
    /// An arrow between process elements. 
    /// </summary>
    public interface IContractSequenceFlow: INamable, IIdentifiable
    {
        /// <summary>
        /// Source process element id. 
        /// </summary>
        string SourceId { get; set; }

        /// <summary>
        /// Target process element id. 
        /// </summary>
        string TargetId { get; set; }

        /// <summary>
        /// Condition in solidity under which the sequence flow can be traversed
        /// </summary>
        string Condition { get; set; }
    }
}
