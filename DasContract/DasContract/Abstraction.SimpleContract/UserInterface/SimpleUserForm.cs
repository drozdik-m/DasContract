using DasContract.Abstraction.Interface.UserInterface;
using DasContract.DasContract.Abstraction.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DasContract.Abstraction.SimpleContract.UserInterface
{
    public class SimpleUserForm : IUserForm
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        IEnumerable<IFormField> IUserForm.Fields => Fields;
        List<SimpleFormField> Fields { get; set; } = new List<SimpleFormField>();
    }
}
