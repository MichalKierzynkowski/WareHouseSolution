using FluentValidation;
using FormsLogic.ProductForm.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Validation.FilteringValidations
{
    public class InputFilterByAllValidation : AbstractValidator<FilteringOption>
    {
        public InputFilterByAllValidation()
        {
            RuleFor(x => x.Input).Must(x => IsStringIsNotNull(x)).WithMessage("Pole sortowanie po wszystkim nie może być puste!");
            RuleFor(x => x.Input).Must(x => CheckIfStringIsNotMixWithDigitsAndLetters(x)).WithMessage("Pole sortowanie po wszystkim nie może zawierać liter i cyfr!");

        }
        private bool IsStringIsNotNull(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            return true;
        }
        private bool CheckIfStringIsNotMixWithDigitsAndLetters(string input)
        {
            int a;
            bool parseResult = int.TryParse(input, out a);
            if (parseResult)
            {
                return true;
            }
            else
            {
                return CheckIfStringContainsOnlyLetters(input);
            }
        }
        private bool CheckIfStringContainsOnlyLetters(string input)
        {
            if (input.All(char.IsLetter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
