using DasContract.Abstraction.Interface.Processes.Process.Tasks;

namespace DasContract.Abstraction.SimpleContract.Processes.Process.Tasks
{
    public class SimpleBusinessRuleTask : SimpleTask, IBusinessRuleTask
    {
        public string BusinessRuleXml { get; set; }

        public void CopyDataFrom(IBusinessRuleTask source)
        {
            BusinessRuleXml = source.BusinessRuleXml;
        }
    }
}
