using ClassesLibrary.AddItemClasses.Validation;
using ClassesLibrary.AddItemClasses.Validation.ValidationModels;
using FluentValidation.Results;

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
