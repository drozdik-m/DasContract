using System;
using System.Collections.Generic;
using System.Text;

namespace DasContract.Abstraction.Interface.Processes.Process.Tasks
{
    public interface ICustomDataCopyableTask<TInputType>
    {
        void CopyCustomDataFrom(TInputType source);
    }
}
