using FluentValidation;
using FormsLogic.ProductForm.Logic.Entities;

namespace FormsLogic.ProductForm.Validation.FilteringValidations
{
    public class InputProductTypeValidation : AbstractValidator<FilteringOption>
    {
        public InputProductTypeValidation()
        {
            RuleFor(x => x.Input).Must(x => IsBarNumberContainsOnlyDigits(x)).WithMessage("Pole Rodzaj Produktu nie może zawierać cyfr!");
            RuleFor(x => x.Input).Must(x => IsStringIsNotNull(x)).WithMessage("Pole Rodzaj Produktu nie może być puste!");

        }
        private bool IsBarNumberContainsOnlyDigits(string input)
        {
            if (!input.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }
        private bool IsStringIsNotNull(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            return true;
        }
    }
}