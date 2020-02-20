using System;
using System.Collections.Generic;
using System.Text;

namespace DasContract.Abstraction.Interface.DataModel.Entity.Property.Reference
{
    public interface IReferenceContractProperty: IContractProperty
    {
        IContractEntity Entity { get; }
    }
}
