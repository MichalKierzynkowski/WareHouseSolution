using System.Linq;
using FluentValidation;
using WareHouse.Data.SqlModels;

namespace ClassesLibrary.AddItemClasses.Validation;

public class AddProductValidate : AbstractValidator<Product>
{
    public AddProductValidate()
    {
        RuleFor(x => x.DescriptionProduct).NotEmpty().WithMessage("Pole Opis Produktu nie może być puste!");
        RuleFor(x => x.DescriptionProduct).Must(DescriptionProduct => IsStringContainsNumbers(DescriptionProduct))
            .WithMessage("Pole Opis Produktu nie może zawierać cyfr!");
        RuleFor(x => x.IdTypeProduct).NotEmpty().WithMessage("Pole Typ Produktu nie może być puste!");
        RuleFor(x => x.IdTypeProduct).Must(IdTypeProduct => IsStringContainsOnlyNumbers(IdTypeProduct))
            .WithMessage("Pole Rodzaj Produktu nie może zawierać liter!");


        RuleFor(x => x.BarNumber).NotEmpty()
        .WithMessage("Pole numer kreskowy nie może być puste!").DependentRules(() =>
        RuleFor(x => x.BarNumber).Must(BarNumber => IsStringContainsOnlyNumbers(BarNumber))
        .WithMessage("Pole Kod Kreskowy nie może zawierać liter!").DependentRules(() =>
        RuleFor(x => x.BarNumber).Must(BarNumber => IsExistingBarNumberNotExist(BarNumber))
        .WithMessage("Podany numer kreskowy znajduje się już w bazie!")));
    }

    private bool IsStringContainsNumbers(string value)
    {
        if (!value.All(char.IsLetter)) return false;

        return true;
    }

    private bool IsStringContainsOnlyNumbers(string value)
    {
        if (value.All(char.IsDigit))
            return true;
        return false;
    }

    private bool IsExistingBarNumberNotExist(string barNumber)
    {
        var barNumberValidate = new BarNumberExistingValidation(barNumber);
        var result = barNumberValidate.IsGivenBarNumberExist();
        if (result)
            return false;
        return true;
    }
}