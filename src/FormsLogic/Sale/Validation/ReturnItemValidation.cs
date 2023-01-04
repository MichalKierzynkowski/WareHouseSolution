using ApplicationLayer.Dto.ReturnDtos;
using FluentValidation;

namespace FormsLogic.Sale.Validation
{
    public class ReturnItemValidation:AbstractValidator<ReturnDto>
    {
        public int Amount { get; set; }
        public ReturnItemValidation(int amount)
        {
            Amount = amount;
            RuleFor(x => x.Quantity).Must(x => CheckAmount(x)).WithMessage("Wybrana ilość jest większa niż ta która jest na magazynie!");
        }

        private bool CheckAmount(int amountOfProduct)
        {
            if (amountOfProduct - Amount>=0)
            {
                return true;
            }
            return false;
        }
    }
}
