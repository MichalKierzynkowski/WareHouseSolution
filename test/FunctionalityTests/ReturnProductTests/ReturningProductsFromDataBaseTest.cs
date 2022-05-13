using Infrastructure.Data;
using Infrastructure.Repositories;
using Infrastructure.SqlLiteConnectionSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FunctionalityTests.ReturnProductTests
{
    public class ReturningProductsFromDataBaseTest : IClassFixture<SqlLiteDataAccess>
    {

        [Fact]
        public void ReturnAllProductsTest()
        {

            //var productsRepository = new ProductRepository();
            //var products = productsRepository.GetAll();
            //Assert.NotEmpty(products);
        }
    }
}
