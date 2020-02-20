using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DasContract.Abstraction.Interface.Processes.Process;
using DasContract.Abstraction.SimpleContract.Processes.Process.Events;
using DasContract.Abstraction.SimpleContract.Processes.Process.Gateways;
using DasContract.Abstraction.SimpleContract.Processes.Process.Tasks;

namespace DasContract.Abstraction.SimpleContract.Processes.Process
{
    public class SimpleContractProcess : IContractProcess
    {
        IEnumerable<IContractSequenceFlow> IContractProcess.SequenceFlows => SequenceFlows;
        List<SimpleContractSequenceFlow> SequenceFlows { get; set; } = new List<SimpleContractSequenceFlow>();

        IEnumerable<IContractProcessElement> IContractProcess.ProcessElements => ProcessElements;
        List<SimpleContractProcessElement> ProcessElements { get; set; } = new List<SimpleContractProcessElement>();
        

        public IEnumerable<SimpleEvent> Events { get { return ProcessElements.OfType<SimpleEvent>(); } }
        public IEnumerable<SimpleGateway> Gateways { get { return ProcessElements.OfType<SimpleGateway>(); } }


        public IEnumerable<SimpleTask> Activities => ProcessElements.OfType<SimpleTask>();

        public IEnumerable<SimpleBusinessRuleTask> BusinessActivities => ProcessElements.OfType<SimpleBusinessRuleTask>();

        public IEnumerable<SimpleScriptTask> ScriptActivities => ProcessElements.OfType<SimpleScriptTask>();

        public IEnumerable<SimpleUserTask> UserActivities => ProcessElements.OfType<SimpleUserTask>();

        public SimpleStartEvent StartEvent => ProcessElements.OfType<SimpleStartEvent>().SingleOrDefault();
    }
}
