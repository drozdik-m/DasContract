using System;
using System.Collections.Generic;
using System.Text;

namespace DasContract.Abstraction.Interface.DataModel.Entity.Property.Reference
{
    public interface ICollectionReferenceContractProperty : IContractProperty
    {
        IEnumerable<IContractEntity> Entities { get; }
    }
}
