using FluentValidation;
using FormsLogic.ProductForm.DatePickPopUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.DatePickPopUp.Validation
{
    public class SelectedDateValidation : AbstractValidator<SelectedDate>
    {
        public SelectedDateValidation()
        {
            RuleFor(x => x.DateFrom).NotEmpty().WithMessage("Pole Data Od nie może być puste!");
            RuleFor(x => x.DateFrom).Must(x => CheckIfSelectedDataIsExistings(x)).WithMessage("Pole Data Od jest starsze od dzisiejszej daty!");
            RuleFor(x => x.DateTo).NotEmpty().WithMessage("Pole Data Do nie może być puste!");
            RuleFor(x => x.DateTo).Must(DateTo => CheckIfSelectedDataIsExistings(DateTo)).WithMessage("Pole Data Do jest starsze od dzisiejszej daty!");
            RuleFor(x => new { x.DateFrom, x.DateTo }).Must(x => CheckIfDateFromIsNotBiggerThanDateTo(x.DateFrom, x.DateTo)).WithMessage("Data od musi być starsza od daty do!");
        }

        public bool CheckIfDateFromIsNotBiggerThanDateTo(DateTime dateFrom, DateTime dateTo)
        {
            if (dateFrom <= dateTo)
            {
                return true;
            }
            return false;
        }
        public bool CheckIfSelectedDataIsExistings(DateTime date)
        {
            if (DateTime.Now >= date)
            {
                return true;
            }
            return false;
        }
    }
}
