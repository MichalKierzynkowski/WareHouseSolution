using ApplicationLayer.Dto.WareHouse;
using FluentValidation;

namespace FormsLogic.Sale.Validation
{
    public class WareHouseItemValidation:AbstractValidator<WareHouseDto>
    {
        public int Amount { get; set; }
        public WareHouseItemValidation(int amount)
        {
            Amount = amount;
            RuleFor(x => x.Quantity).Must(x => CheckAmount(x)).WithMessage("Wybrana ilość jest większa niż ta która jest na magazynie!");
        }
        private bool CheckAmount(int amountOfProduct)
        {
            if (amountOfProduct - Amount >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
