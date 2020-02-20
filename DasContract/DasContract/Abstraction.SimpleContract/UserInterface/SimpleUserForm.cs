using DasContract.Abstraction.Interface.UserInterface;
using DasContract.DasContract.Abstraction.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DasContract.Abstraction.SimpleContract.UserInterface
{
    public class SimpleUserForm : IUserForm
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        IEnumerable<IFormField> IUserForm.Fields => Fields;
        List<SimpleFormField> Fields { get; set; } = new List<SimpleFormField>();

        public void CopyDataFrom(IUserForm source)
        {
            foreach(var field in Fields)
            {
                var res = source.Fields.Where(e => e.Id == field.Id).SingleOrDefault();
                if (res != null)
                    field.CopyDataFrom(res);
            }
        }
    }
}
