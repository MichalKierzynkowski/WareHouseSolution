using ClassesLibrary.AddItemClasses.Validation;
using ClassesLibrary.AddItemClasses.Validation.ValidationModels;
using FluentAssertions;
using System;
using WareHouse.Data.SqlModels;
using WareHouse.Logic.AddItemClasses.Validation;
using Xunit;

namespace WareHouseApplicationTests.Forms.Product;

public class AddProductTesting
{
    public WareHouse.Data.SqlModels.Product Product { get; set; }


    public AddProductTesting()
    {



        Product = new WareHouse.Data.SqlModels.Product()
        {
            IdProduct = Guid.NewGuid(),
            DescriptionProduct = "sa sd",
            IdTypeProduct = "1",
            BarNumber = 3,
            CurrentSellingPrice = 3,
            IsReturned = false,
            Quantity = 2,
            IdPurchaseMethod = "2",
            Purchase = new Purchase()
            {
                Amount = 2,
                DatePurchase = DateTime.UtcNow,
                IdProduct = new Guid(),
                IdPurchase = new Guid(),
                PurchasePrice = 0
            }



        };
    }
    [Fact]
    public void AddProductTestShouldBeFalse()
    {
        AddProductAndPurchaseValidate addProductValidate = new AddProductAndPurchaseValidate();
        var result = addProductValidate.Validate(Product);
        var errros = result.Errors;
        result.IsValid.Should().BeFalse();
    }

    [Fact]
    public void DataBaseShouldContainsThatBarNumbers()
    {
        var barNumberObj = new BarNumberModel()
        {
            BarNumber = Product.BarNumber
        };

        ValidationBarNumber validationBarNumber = new ValidationBarNumber(barNumberObj);
        var result = validationBarNumber.ReturnValidatingResult();
        var errors = result.Errors;
    }

}