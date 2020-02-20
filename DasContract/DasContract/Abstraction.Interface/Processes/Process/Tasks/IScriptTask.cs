namespace DasContract.Abstraction.Interface.Processes.Process.Tasks
{
    public interface IScriptTask : ITask, IDataCopyable<IScriptTask>
    {
        string Script { get; set; }
    }
}
