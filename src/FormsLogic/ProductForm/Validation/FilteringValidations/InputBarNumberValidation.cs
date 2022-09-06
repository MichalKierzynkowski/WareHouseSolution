using FluentValidation;
using FormsLogic.ProductForm.Logic.Entities;

namespace FormsLogic.ProductForm.Validation.FilteringValidations
{
    public class InputBarNumberValidation : AbstractValidator<FilteringOption>
    {
        public InputBarNumberValidation()
        {

            RuleFor(x => x.Input).Must(x => IsBarNumberContainsOnlyDigits(x)).WithMessage("Numer Ewidencyjny może zawierać tylko cyfry!");
            RuleFor(x => x.Input).Must(x => IsStringIsNotNull(x)).WithMessage("Numer Ewidencyjny nie może byc pusty!");

        }
        private bool IsBarNumberContainsOnlyDigits(string input)
        {
            if (input.All(char.IsDigit))
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
