using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface;
using DasContract.Abstraction.Interface.DataModel;
using DasContract.Abstraction.SimpleContract.DataModel;
using DasContract.Abstraction.SimpleContract.Processes;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.SimpleContract
{
    public class SimpleContract : IContract
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        SimpleContractProcesses IContract.Processes => throw new NotImplementedException();
        //SimpleContractProcesses Processes { get; set; }

        IContractDataModel IContract.DataModel => DataModel;
        SimpleContractDataModel DataModel { get; set; }

    }
}
