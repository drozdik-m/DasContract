using DasContract.Abstraction.Interface.DataModel.Entity.Property;
using DasContract.DasContract.Abstraction.Interface;
using System;
using System.Linq.Expressions;

namespace DasContract.Abstraction.Interface.UserInterface
{
    public interface IFormField: IIdentifiable, INamable
    {
        //TODO What is DasContract.Abstraction.UserInterface.FormField.Type (describe the enum at least please)
        FormFieldType Type { get; }

        /// <summary>
        /// User friendly label of this field/input
        /// </summary>
        string Label { get; set; }

        /// <summary>
        /// Description of this input for better user understanding
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// If true, the field cannot be changed
        /// </summary>
        bool ReadOnly { get; set; }

        /// <summary>
        /// An expression binding (to what property is this field connected to?)
        /// </summary>
        IContractPropertyExpression PropertyExpression { get; }
    }
}
