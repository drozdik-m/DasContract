using DasContract.Abstraction.Interface.Processes.Process.Events;
using DasContract.Abstraction.Interface.UserInterface;
using DasContract.Abstraction.SimpleContract.UserInterface;

namespace DasContract.Abstraction.SimpleContract.Processes.Process.Events
{
    public class SimpleStartEvent : SimpleEvent, IStartEvent
    {
        IUserForm IStartEvent.StartForm => StartForm;
        public SimpleUserForm StartForm { get; set; }
    }
}
