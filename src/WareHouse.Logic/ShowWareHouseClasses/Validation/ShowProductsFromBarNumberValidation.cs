using ClassesLibrary.AddItemClasses.Validation.ValidationModels;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Logic.ShowWareHouseClasses.Validation
{
    public class ShowProductsFromBarNumberValidation
    {
        public ShowProductsFromBarNumberValidation(BarNumberModel barNumberObj)
        {
            BarNumberObj = barNumberObj;
        }

        public BarNumberModel BarNumberObj { get; }
        public ValidationResult  ReturnValidatingResult()
        {
            ValidateBarNumber validateBarNumber = new ValidateBarNumber();
            return validateBarNumber.Validate(BarNumberObj);
        }
    }
}
