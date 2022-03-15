using System.ComponentModel.DataAnnotations;
using ClassesLibrary.AddItemClasses.Validation.ValidationModels;
using FluentValidation.Results;

namespace WareHouse.Logic.ShowWareHouseClasses.Validation
{
    public class ShowProductsFromBarNumberValidation
    {
        public ShowProductsFromBarNumberValidation(BarNumberModel barNumberObj)
        {
            BarNumberObj = barNumberObj;
        }

        public BarNumberModel BarNumberObj { get; }
        public FluentValidation.Results.ValidationResult ReturnValidatingResult()
        {
            ValidateBarNumber validateBarNumber = new ValidateBarNumber();
            return validateBarNumber.Validate(BarNumberObj);
        }
    }
}
