using System;
using System.Collections.Generic;
using System.Text;
using DasContract.DasContract.Abstraction.Interface;

namespace DasContract.Abstraction.Interface.DataModel.Entity.Property
{
    public interface IContractProperty: IIdentifiable, INamable
    {
        bool IsMandatory { get; set; }


    }
}
