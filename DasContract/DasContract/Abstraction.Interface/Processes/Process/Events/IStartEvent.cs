

using DasContract.Abstraction.Interface.UserInterface;

namespace DasContract.Abstraction.Interface.Processes.Process.Events
{
    public interface IStartEvent : IEvent
    {
        IUserForm StartForm { get; }
    }
}
