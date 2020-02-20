using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface.DataModel.Entity;
using DasContract.Abstraction.Interface.DataModel.Entity.Property.Reference;
using DasContract.Abstraction.SimpleContract.DataModel.Entity;

namespace DasContract.Abstraction.SimpleContract.DataModel.Entity.Property.Reference
{
    public class CollectionReferenceSimpleContractProperty : SimpleContractProperty, ICollectionReferenceContractProperty
    {
        IEnumerable<IContractEntity> ICollectionReferenceContractProperty.Entities => Entities;
        public List<SimpleContractEntity> Entities { get; set; } = new List<SimpleContractEntity>();
    }
}
