using System;
using System.Collections.Generic;
using System.Text;

namespace DasContract.Abstraction.Interface.DataModel.Entity.Property.Reference
{
    public interface ICollectionReferenceContractProperty : IContractProperty
    {
        ICollection<IContractEntity> Entities { get; }
    }
}
