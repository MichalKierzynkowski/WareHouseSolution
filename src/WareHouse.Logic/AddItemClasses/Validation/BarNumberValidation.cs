using ClassesLibrary.AddItemClasses.Validation.ValidationModels;
using FluentValidation;

namespace ClassesLibrary.AddItemClasses.Validation
{
    public class BarNumberValidation : AbstractValidator<BarNumberModel>
    {
        public BarNumberValidation()
        {

            RuleFor(x => x.BarNumber).NotEmpty()

           .WithMessage("Pole numer kreskowy nie może być puste!").DependentRules(() =>
                       RuleFor(x => x.BarNumber).Must(BarNumber => IsExistingBarNumberNotExist(BarNumber))
                           .WithMessage("Podany numer kreskowy znajduje się już w bazie!"));


        }

        public BarNumberValidation(BarNumberModel barNumberObj)
        {
            BarNumberObj = barNumberObj;
        }

        public BarNumberModel BarNumberObj { get; }

        private bool IsExistingBarNumberNotExist(decimal barNumber)
        {
            var barNumberValidate = new BarNumberExistingValidation(barNumber);
            var result = barNumberValidate.IsGivenBarNumberExist();
            if (result)
                return false;
            return true;
        }
    }
}
