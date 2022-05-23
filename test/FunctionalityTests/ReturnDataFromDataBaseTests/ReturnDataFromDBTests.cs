using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace FunctionalityTests.ReturnDataFromDataBaseTests
{
    public class ReturnDataFromDBTests : IClassFixture<DependencySetupFixture>
    {
        private ServiceProvider _serviceProvide;

        public ReturnDataFromDBTests(DependencySetupFixture fixture)
        {
            _serviceProvide = fixture.ServiceProvider;
        }

        [Fact]
        public void ContextInjectionTest()
        {
            using (var scope = _serviceProvide.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<WareHouseDbContext>();
                Assert.NotNull(context);
            }
        }

        [Fact]
        public void ReturnProductsFromDataBase()
        {
            using (var scope = _serviceProvide.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<WareHouseDbContext>();
                ProductRepository repository = new ProductRepository(context);
                var products = repository.GetAll();
                Assert.NotNull(products);
            }
        }
    }
}