using DasContract.DasContract.Abstraction.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DasContract.Abstraction.Interface.UserInterface
{
    public interface IUserForm: IIdentifiable
    {
        /// <summary>
        /// Field of this user form
        /// </summary>
        IEnumerable<IFormField> Fields { get; }
    }
}
