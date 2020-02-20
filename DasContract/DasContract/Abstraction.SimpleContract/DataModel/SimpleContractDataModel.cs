using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface.DataModel;
using DasContract.Abstraction.Interface.DataModel.Entity;
using DasContract.Abstraction.SimpleContract.DataModel.Entity;

namespace DasContract.Abstraction.SimpleContract.DataModel
{
    public class SimpleContractDataModel : IContractDataModel
    {
        IEnumerable<IContractEntity> IContractDataModel.Entities => Entities;
        public List<SimpleContractEntity> Entities { get; set; } = new List<SimpleContractEntity>();
    }
}
