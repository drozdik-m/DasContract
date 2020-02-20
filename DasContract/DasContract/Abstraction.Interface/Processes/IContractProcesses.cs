using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface.Processes.Process;

namespace DasContract.Abstraction.Interface.Processes
{
    public interface IContractProcesses
    {
        /// <summary>
        /// BPMN 2.0 XML with process description and a visual process information for the main process.
        /// </summary>
        IBpmnDiagram Diagram { get; }


        /// <summary>
        /// The main process of this contract. 
        /// </summary>
        IContractProcess Main { get; }
    }
}
