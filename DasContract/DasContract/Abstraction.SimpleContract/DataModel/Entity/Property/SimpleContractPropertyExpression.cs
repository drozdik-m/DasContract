using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface.DataModel.Entity.Property;

namespace DasContract.Abstraction.SimpleContract.DataModel.Entity.Property
{
    public class SimpleContractPropertyExpression : IContractPropertyExpression
    {
        public string ModelName { get; set; }

        public string PropertyName { get; set; }
    }
}
