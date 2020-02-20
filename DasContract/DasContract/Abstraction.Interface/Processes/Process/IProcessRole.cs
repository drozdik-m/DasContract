using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.Interface.Processes.Process
{
    public interface IProcessRole: INamable, IIdentifiable
    {
        public string Description { get; set; }
    }
}
