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

    }


}