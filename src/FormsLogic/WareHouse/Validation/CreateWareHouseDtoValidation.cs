using System.Security.Cryptography.X509Certificates;
using ApplicationLayer.Dto.WareHouse;
using FluentValidation;

namespace FormsLogic.WareHouse.Validation
{
    public class CreateWareHouseDtoValidation:AbstractValidator<CreateWareHouseDto>
    {
        public CreateWareHouseDtoValidation()
        {
            RuleFor(x => x.ProductRegistrationNumber).NotEmpty().WithMessage("Pole Numer Ewidencyjny nie może być puste! Wybierz produkt!");
            RuleFor(x => x.PurchasePrice).NotEmpty().WithMessage("Pole Cena Zakupu nie może być puste!");
            RuleFor(x => x.SellPrice).NotEmpty().WithMessage("Pole Cena Sprzedaży nie może być puste!");
            RuleFor(x => new { x.SellPrice, x.PurchasePrice })
                .Must(x => CheckIfBuyPriceIsLowerThanSellPrice(x.SellPrice, x.PurchasePrice)).WithMessage(
                    "Cena sprzedaży nie może być mniejsza " +
                    "od ceny zakupu!");
        }

        public bool CheckIfBuyPriceIsLowerThanSellPrice(decimal sellPrice, decimal purchasePrice)
        {
            if (purchasePrice<=sellPrice)
            {
                return true;
            }

            return false;
        }

    }
}
