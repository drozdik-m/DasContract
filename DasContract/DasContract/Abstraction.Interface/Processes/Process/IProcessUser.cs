using System.Collections.Generic;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.Interface.Processes.Process
{
    public interface IProcessUser: INamable, IIdentifiable
    {
        public string Description { get; set; }

        public string Address { get; set; }

        public IEnumerable<IProcessRole> Roles { get; }
    }
}
