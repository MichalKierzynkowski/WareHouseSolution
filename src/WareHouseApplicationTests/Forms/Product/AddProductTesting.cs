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
using ClassesLibrary.SqlClassesInterfaces;
using ClassesLibrary.AddItemClasses.Queries;

namespace WareHouseApplicationTests.Forms.Product;

public class AddProductTesting
{
    public WareHouse.Data.SqlModels.Product Product { get; set; }
   

    public AddProductTesting()
    {
        
       

        Product = new WareHouse.Data.SqlModels.Product()
        {
            IdProduct = Guid.NewGuid(),
            DescriptionProduct ="sa",
            IdTypeProduct = "1",
            BarNumber = 312421412,
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
        AddProductAndPurchaseValidate addProductValidate = new AddProductAndPurchaseValidate("Data Source=DESKTOP-4NURNJC; Initial Catalog=WareHouse;Trusted_Connection=True; Integrated Security=SSPI;Persist Security Info=False;Encrypt=False;TrustServerCertificate=True;");
        var result = addProductValidate.Validate(Product);
        result.IsValid.Should().BeFalse();
    }
    [Fact]
    public void AddProductToDataBaseTest()
    {
        AddProductAndPurchaseToDataBase addObj = new AddProductAndPurchaseToDataBase(Product, "Data Source=DESKTOP-4NURNJC; Initial Catalog=WareHouse;Trusted_Connection=True; Integrated Security=SSPI;Persist Security Info=False;Encrypt=False;TrustServerCertificate=True;");

    }
    
    
}