using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface.DataModel.Entity;
using DasContract.Abstraction.Interface.DataModel.Entity.Property.Reference;
using DasContract.Abstraction.SimpleContract.DataModel.Entity;

namespace DasContract.Abstraction.SimpleContract.DataModel.Entity.Property.Reference
{
    public class ReferenceSimpleContractProperty : SimpleContractProperty, IReferenceContractProperty
    {
        IContractEntity IReferenceContractProperty.Entity => Entity;
        SimpleContractEntity Entity { get; set; }
    }
}
