using DasContract.Abstraction.Interface.Processes.Process.Tasks;

namespace DasContract.Abstraction.SimpleContract.Processes.Process.Tasks
{
    public class SimpleScriptTask : SimpleTask, IScriptTask
    {
        public string Script { get; set; }

        public void CopyCustomDataFrom(IScriptTask source)
        {
            Script = source.Script;
        }
    }
}
