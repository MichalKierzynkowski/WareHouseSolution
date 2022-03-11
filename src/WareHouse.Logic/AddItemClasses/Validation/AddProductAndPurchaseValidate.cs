using System;
using System.Linq;
using FluentValidation;
using WareHouse.Data.SqlModels;

namespace ClassesLibrary.AddItemClasses.Validation;

public class AddProductAndPurchaseValidate : AbstractValidator<Product>
{
    public AddProductAndPurchaseValidate()
    {
        
        RuleFor(x => x.DescriptionProduct).NotEmpty().WithMessage("Pole Opis Produktu nie może być puste!");
        RuleFor(x => x.DescriptionProduct).Must(DescriptionProduct => IsStringContainsNumbers(DescriptionProduct))
            .WithMessage("Pole Opis Produktu nie może zawierać cyfr!");

        RuleFor(x => x.IdTypeProduct).NotEmpty().WithMessage("Pole Rodzaj Produktu nie może być puste!");
        
        RuleFor(x => x.BarNumber).NotEmpty()

            .WithMessage("Pole numer kreskowy nie może być puste!").DependentRules(() =>
                        RuleFor(x => x.BarNumber).Must(BarNumber => IsExistingBarNumberNotExist(BarNumber))
                            .WithMessage("Podany numer kreskowy znajduje się już w bazie!"));

        RuleFor(x => x.CurrentSellingPrice).NotEmpty()
            .WithMessage("Pole Cena Sprzedaży nie może być puste!").DependentRules(() =>
                RuleFor(x => x.CurrentSellingPrice).Must(CurrentSellingPrice => IsPriceIsGreaterThan0(CurrentSellingPrice))
                    .WithMessage("Cena Sprzedaży musi być większa od 0!"));

        RuleFor(x => x.Quantity).NotEmpty()
            .WithMessage("Pole Ilość nie może być puste!").DependentRules(() =>
                RuleFor(x => x.Quantity).Must(OfferPrice => IsPriceIsGreaterThan0(OfferPrice))
                    .WithMessage("Pole Ilość musi być większa od 0!"));


        RuleFor(x => x.IdPurchaseMethod).NotEmpty().WithMessage("Pole Metoda Kupna nie może być pusta!");

        RuleFor(x => x.Purchase.PurchasePrice).NotEmpty()
            .WithMessage("Pole Cena Zakupu nie może być puste!").DependentRules(() =>
                RuleFor(x => x.Purchase.PurchasePrice).Must(PurchasePrice => IsPriceIsGreaterThan0(PurchasePrice))
                    .WithMessage("Cena zakupu musi być większa od 0!"));

    }

    private bool IsStringContainsNumbers(string value)
    {
        string valueToCheck = String.Concat(value.Where(c => !Char.IsWhiteSpace(c)));
        return System.Text.RegularExpressions.Regex.IsMatch(valueToCheck, @"^[a-zA-Z]+$");
    }

    

    private bool IsPriceIsGreaterThan0(decimal value)
    {
        if (value > 0)
            return true;
        return false;
    }

    

    private bool IsExistingBarNumberNotExist(int barNumber)
    {
        var barNumberValidate = new BarNumberExistingValidation(barNumber);
        var result = barNumberValidate.IsGivenBarNumberExist();
        if (result)
            return false;
        return true;
    }
}