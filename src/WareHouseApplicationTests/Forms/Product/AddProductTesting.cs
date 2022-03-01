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
namespace WareHouseApplicationTests.Forms.Product;

public class AddProductTesting
{
    public WareHouse.Data.SqlModels.Product Product { get; set; }

    public string ConnectionString { get; set; } =
        "Data Source=DESKTOP-DQ7DARP\\SQLEXPRESS; Initial Catalog=WareHouse;User ID =DESKTOP-DQ7DARP\\Michal; Integrated Security=SSPI;Persist Security Info=False;Encrypt=True;TrustServerCertificate=True;";
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

    [Fact]
    public void IsGivenBarNumberExistingInDataBase()
    {
        int BarNumber = 1999;
        bool result;
        using (var connection = new SqlConnection(ConnectionString))
        {
            var exists = connection.Query<object>(
                    "SELECT 1 WHERE EXISTS (SELECT 1 FROM Product WHERE BarNumber = @barNumber)", new {BarNumber})
                .Any();

            connection.Close();


            exists.Should().BeFalse();
        }

    }
}