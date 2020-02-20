using DasContract.Abstraction.Interface.DataModel.Entity.Property;
using DasContract.Abstraction.Interface.UserInterface;
using DasContract.Abstraction.SimpleContract.DataModel.Entity.Property;
using DasContract.DasContract.Abstraction.Interface;
using System;
using System.Linq.Expressions;

namespace DasContract.Abstraction.SimpleContract.UserInterface
{
    public class SimpleFormField : IFormField
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public bool ReadOnly { get; set; }

        public FormFieldType Type { get; set; }

        IContractPropertyExpression IFormField.PropertyExpression => PropertyExpression;
        SimpleContractPropertyExpression PropertyExpression { get; set; }

        public void CopyDataFrom(IFormField source)
        {
            Id = source.Id;
            Name = source.Name;
            Label = source.Label;
            Description = source.Description;
            ReadOnly = source.ReadOnly;
            Type = source.Type;
            PropertyExpression.CopyDataFrom(source.PropertyExpression);
        }
    }
}
