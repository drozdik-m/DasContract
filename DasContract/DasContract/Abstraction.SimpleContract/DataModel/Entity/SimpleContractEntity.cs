using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface.DataModel.Entity;
using DasContract.Abstraction.Interface.DataModel.Entity.Property.Primitive;
using DasContract.Abstraction.Interface.DataModel.Entity.Property.Reference;
using DasContract.Abstraction.SimpleContract.DataModel.Entity.Property.Primitive;
using DasContract.Abstraction.SimpleContract.DataModel.Entity.Property.Reference;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.SimpleContract.DataModel.Entity
{
    public class SimpleContractEntity : IContractEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        IEnumerable<IPrimitiveContractProperty> IContractEntity.PrimitiveProperties => PrimitiveProperties;
        List<PrimitiveSimpleContractProperty> PrimitiveProperties { get; set; } = new List<PrimitiveSimpleContractProperty>();


        IEnumerable<IReferenceContractProperty> IContractEntity.ReferenceProperties => ReferenceProperties;
        List<ReferenceSimpleContractProperty> ReferenceProperties { get; set; } = new List<ReferenceSimpleContractProperty>();


        IEnumerable<ICollectionReferenceContractProperty> IContractEntity.CollectionReferenceProperties => CollectionReferenceProperties;
        List<CollectionReferenceSimpleContractProperty> CollectionReferenceProperties { get; set; } = new List<CollectionReferenceSimpleContractProperty>();
    }
}
