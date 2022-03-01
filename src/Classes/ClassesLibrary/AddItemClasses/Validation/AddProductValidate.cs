using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using WareHouse.Data.SqlModels;


namespace ClassesLibrary.AddItemClasses.Validation;

public class AddProductValidate:AbstractValidator<Product>
{
    public AddProductValidate()
    {
        RuleFor(x => x.DescriptionProduct).NotEmpty().WithMessage("Pole Opis Produktu nie może być puste!");
        RuleFor(x => x.DescriptionProduct).Must(DescriptionProduct => IsStringContainsNumbers(DescriptionProduct))
            .WithMessage("Pole Opis Produktu nie może zawierać cyfr!");
        RuleFor(x => x.IdTypeProduct).NotEmpty().WithMessage("Pole Typ Produktu nie może być puste!");
        RuleFor(x => x.IdTypeProduct).Must(IdTypeProduct => IsStringContainsOnlyNumbers(IdTypeProduct))
            .WithMessage("Pole Typ Produktu nie może zawierać liter!");

    }
    private bool IsStringContainsNumbers(string value)
    {
        if (!value.All(char.IsLetter)) return false;

        return true;
    }

    private bool IsStringContainsOnlyNumbers(string value)
    {
        if (value.All(char.IsDigit))
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}