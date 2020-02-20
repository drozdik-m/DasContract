namespace DasContract.Abstraction.Interface.Processes.Process.Tasks
{
    public interface IBusinessRuleTask : ITask, IDataCopyable<IBusinessRuleTask>
    {
        /// <summary>
        /// A definition of a business rule in xml format. 
        /// </summary>
        public string BusinessRuleXml { get; set; }
    }
}
