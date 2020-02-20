using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface.DataModel.Entity.Property.Primitive;
using DasContract.Abstraction.Interface.DataModel.Entity.Property.Reference;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.Interface.DataModel.Entity
{
    public interface IContractEntity: IIdentifiable, INamable
    {
        IEnumerable<IPrimitiveContractProperty> PrimitiveProperties { get; }

        IEnumerable<IReferenceContractProperty> ReferenceProperties { get; }

        IEnumerable<ICollectionReferenceContractProperty> CollectionReferenceProperties { get; }
    }
}
