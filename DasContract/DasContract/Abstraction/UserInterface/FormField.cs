﻿using DasContract.DasContract.Abstraction.Interface;
using System;
using System.Linq.Expressions;

namespace DasContract.Abstraction.UserInterface
{
    public class FormField: IIdentifiable, INamable
    {
        public string Id { get; set; }

        public string Name { get; set; }

        //TODO What is DasContract.Abstraction.UserInterface.FormField.Type (describe the enum at least please)
        public FormFieldType Type { get; set; }

        /// <summary>
        /// User friendly label of this field/input
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Description of this input for better user understanding
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// If true, the field cannot be changed
        /// </summary>
        public bool ReadOnly { get; set; } = true; 

        /// <summary>
        /// An expression binding (f.e. Entity.Property)
        /// </summary>
        public string PropertyExpression { get; set; }
    }
}
