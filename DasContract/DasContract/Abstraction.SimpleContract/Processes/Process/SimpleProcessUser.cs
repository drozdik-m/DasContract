using System;
using System.Collections.Generic;
using DasContract.Abstraction.Interface.Processes.Process;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.SimpleContract.Processes.Process
{
    public class SimpleProcessUser : IProcessUser
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }


        IEnumerable<IProcessRole> IProcessUser.Roles => Roles;
        List<SimpleProcessRole> Roles { get; set; } = new List<SimpleProcessRole>();
    }
}
