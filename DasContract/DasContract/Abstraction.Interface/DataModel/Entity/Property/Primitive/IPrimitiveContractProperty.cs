using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.DataModel.Property.Primitive;

namespace DasContract.Abstraction.Interface.DataModel.Entity.Property.Primitive
{
    public interface IPrimitiveContractProperty: IContractProperty
    {
        PrimitiveContractPropertyType Type { get; set; }
    }
}
