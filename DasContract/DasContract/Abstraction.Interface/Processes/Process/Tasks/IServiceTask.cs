
namespace DasContract.Abstraction.Interface.Processes.Process.Tasks
{
    public interface IServiceTask : ITask, ICustomDataCopyableTask<IServiceTask>
    {
        public string ImplementationType { get; set; }

        public string Configuration { get; set; }
    }
}
