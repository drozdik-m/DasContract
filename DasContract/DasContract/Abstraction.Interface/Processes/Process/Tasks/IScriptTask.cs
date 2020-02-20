

namespace DasContract.Abstraction.Interface.Processes.Process.Tasks
{
    public interface IScriptTask : ITask, ICustomDataCopyableTask<IScriptTask>
    {
        string Script { get; set; }
    }
}
