using System;
using System.Collections.Generic;
using System.Text;

namespace DasContract.Abstraction.Interface
{
    public interface IDataCopyable<TInputType>
    {
        void CopyDataFrom(TInputType source);
    }
}
