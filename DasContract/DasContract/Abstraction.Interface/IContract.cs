using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface.DataModel;
using DasContract.Abstraction.Interface.Processes;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.Interface
{
    public interface IContract: IIdentifiable, INamable
    {
        /// <summary>
        /// Contract processes
        /// </summary>
        IContractProcesses Processes { get; }

        /// <summary>
        /// Contract data model
        /// </summary>
        IContractDataModel DataModel { get; }
    }
}
