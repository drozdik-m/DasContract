using System;
using System.Collections.Generic;
using System.Text;
using DasContract.Abstraction.Interface.DataModel.Entity.Property;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.SimpleContract.DataModel.Entity.Property
{
    public class SimpleContractProperty : IContractProperty
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public bool IsMandatory { get; set; }
        
    }
}
