using System;
using DasContract.Abstraction.Interface.Processes.Process;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.SimpleContract.Processes.Process
{
    public class SimpleProcessRole : IProcessRole
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }

        public void CopyDataFrom(IProcessRole source)
        {
            Id = source.Id;
            Name = source.Id;
            Description = source.Id;
        }
    }
}
