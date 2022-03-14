using WareHouse.Data.SqlModels;
using WareHouse.Domain.ProductDto;

namespace WareHouse.Data.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ShowAllProductsDto> GetProducts();
        void Insert(Product product);
        void Update(Product product);
        void Delete(string productId);
        bool CheckExistenceOfBarNumber(decimal barNumber);
        IEnumerable<ShowAllProductsDto> ReturnProductsById(decimal barNumber);
    }
}
