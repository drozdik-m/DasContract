using System;
using System.Collections.Generic;
using System.Text;

namespace DasContract.Abstraction.Interface.DataModel.Entity.Property
{
    public interface IContractPropertyExpression
    {
        string ModelName { get; set; }

        string PropertyName { get; set; }
    }
}
