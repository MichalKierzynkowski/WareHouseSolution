using ApplicationLayer.Dto.ReturnDtos;
using FluentValidation;

namespace FormsLogic.Return.Validation
{
    public  class CreateReturnValidation:AbstractValidator<CreateReturnDto>
    {
        public CreateReturnValidation()
        {
            RuleFor(x => x.ProductRegistrationNumber).NotEmpty().WithMessage("Pole Numer Ewidencyjny nie może być puste! Wybierz produkt!");
            RuleFor(x => x.PurchasePrice).NotEmpty().WithMessage("Pole Cena Zakupu nie może być puste!");
            RuleFor(x => x.SellPrice).NotEmpty().WithMessage("Pole Cena Sprzedaży nie może być puste!");
            RuleFor(x => new { x.SellPrice, x.PurchasePrice })
                .Must(x => CheckIfBuyPriceIsLowerThanSellPrice(x.SellPrice, x.PurchasePrice)).WithMessage(
                    "Cena sprzedaży nie może być mniejsza " +
                    "od ceny zakupu!");
        }

        private bool CheckIfBuyPriceIsLowerThanSellPrice(decimal sellPrice, decimal purchasePrice)
        {
            if (purchasePrice <= sellPrice)
            {
                return true;
            }

            return false;
        }
    }
}