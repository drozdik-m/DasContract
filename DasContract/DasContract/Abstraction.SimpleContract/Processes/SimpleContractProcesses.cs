using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface.Processes;
using DasContract.Abstraction.Interface.Processes.Process;
using DasContract.Abstraction.SimpleContract.Processes.Process;

namespace DasContract.Abstraction.SimpleContract.Processes
{
    public class SimpleContractProcesses : IContractProcesses
    {
        IBpmnDiagram IContractProcesses.Diagram => Diagram;
        SimpleBpmnDiagram Diagram { get; set; }

        IContractProcess IContractProcesses.Main => Main;
        SimpleContractProcess Main { get; set; }
    }
}
