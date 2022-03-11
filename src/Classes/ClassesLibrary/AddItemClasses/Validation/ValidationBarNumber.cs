using ClassesLibrary.AddItemClasses.Validation;
using ClassesLibrary.AddItemClasses.Validation.ValidationModels;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Logic.AddItemClasses.Validation
{
    public class ValidationBarNumber
    {
        public ValidationBarNumber(BarNumberModel barNumberObj)
        {
            BarNumberObj = barNumberObj;
            barNumberValidation = new BarNumberValidation();
        }

        public BarNumberModel BarNumberObj { get; }
        BarNumberValidation barNumberValidation { get; set; }
        public ValidationResult ReturnValidatingResult()
        {
            return barNumberValidation.Validate(BarNumberObj);

        }
    }
}
