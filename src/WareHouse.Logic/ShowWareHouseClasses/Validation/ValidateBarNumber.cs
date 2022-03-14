using ClassesLibrary.AddItemClasses.Validation;
using ClassesLibrary.AddItemClasses.Validation.ValidationModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Logic.ShowWareHouseClasses.Validation
{
    public class ValidateBarNumber: AbstractValidator<BarNumberModel>
    {
        public ValidateBarNumber()
        {
            RuleFor(x => x.BarNumber).NotEmpty().WithMessage("Pole numer ewidencyjny nie może być puste!").DependentRules(()
                => RuleFor(x => x.BarNumber).Must(BarNumber=>IsThisBarNumberExist(BarNumber)).WithMessage("Podany numer ewidencyjny nie istnieje w bazie danych!"));


        }

        private bool IsThisBarNumberExist(decimal barNumber)
        {
            var barNumberValidate = new BarNumberExistingValidation(barNumber);
            var result = barNumberValidate.IsGivenBarNumberExist();
            return result;
        }
    }
}
