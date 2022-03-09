using ClassesLibrary.AddItemClasses.Validation.ValidationModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.AddItemClasses.Validation
{
    public class BarNumberValidation:AbstractValidator<BarNumberModel>
    {
        public BarNumberValidation(string connection)
        {

            RuleFor(x => x.BarNumber).NotEmpty()

           .WithMessage("Pole numer kreskowy nie może być puste!").DependentRules(() =>
                       RuleFor(x => x.BarNumber).Must(BarNumber => IsExistingBarNumberNotExist(BarNumber, connection))
                           .WithMessage("Podany numer kreskowy znajduje się już w bazie!"));


        }

        private bool IsExistingBarNumberNotExist(decimal barNumber, string connectionString)
        {
            var barNumberValidate = new BarNumberExistingValidation(barNumber, connectionString);
            var result = barNumberValidate.IsGivenBarNumberExist();
            if (result)
                return false;
            return true;
        }
    }
}
