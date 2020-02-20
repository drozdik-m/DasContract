using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface.DataModel.Entity;

namespace DasContract.Abstraction.Interface.DataModel
{
    public interface IContractDataModel
    {
        ICollection<IContractEntity> Entities { get; }
    }
}
