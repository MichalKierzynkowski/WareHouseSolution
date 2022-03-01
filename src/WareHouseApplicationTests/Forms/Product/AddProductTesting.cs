using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary.AddItemClasses.Validation;
using Xunit;
using FluentAssertions;
using WareHouse.Data.SqlModels;
namespace WareHouseApplicationTests.Forms.Product;

public class AddProductTesting
{
    public WareHouse.Data.SqlModels.Product Product { get; set; }

    public string ConnectionString { get; set; } =
        "Data Source=DESKTOP-GI0C1PC\\SQLEXPRESS;; Initial Catalog=WareHouse;User ID=; Integrated Security=SSPI;Persist Security Info=False;";
    public AddProductTesting()
    {
        Product = new WareHouse.Data.SqlModels.Product()
        {
            DescriptionProduct ="",
            IdTypeProduct = "s",
            BarNumber = "2",
            Offer_Price = "2",
            IsReturned = "Nie",
            Quantity = "3",
            IdPurchaseMethod ="3"

        };
    }
    [Fact]
    public void AddProductTestShouldBeFalse()
    {
        AddProductValidate addProductValidate = new AddProductValidate();
        var result = addProductValidate.Validate(Product);
        result.IsValid.Should().BeFalse();
    }

   
   

}