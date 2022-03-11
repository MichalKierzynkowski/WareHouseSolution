using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary.AddItemClasses.Validation;
using Dapper;
using Xunit;
using FluentAssertions;
using Microsoft.Data.SqlClient;
using WareHouse.Data.SqlModels;

using ClassesLibrary.AddItemClasses.Queries;
using ClassesLibrary.AddItemClasses.Validation.ValidationModels;
using WareHouse.Logic.AddItemClasses.Validation;

namespace WareHouseApplicationTests.Forms.Product;

public class AddProductTesting
{
    public WareHouse.Data.SqlModels.Product Product { get; set; }
   

    public AddProductTesting()
    {
        
       

        Product = new WareHouse.Data.SqlModels.Product()
        {
            IdProduct = Guid.NewGuid(),
            DescriptionProduct ="sa sd",
            IdTypeProduct = "1",
            BarNumber = 3,
            CurrentSellingPrice = 3,
            IsReturned = false,
            Quantity = 2,
            IdPurchaseMethod ="2",
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