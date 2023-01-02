using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Dto.WareHouse;
using ApplicationLayer.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace FormsLogic.WareHouse.Logic.Data
{
    public class ReturnWareHousesFromDB
    {
        private readonly IProductRepository _productRepository;
        public IEnumerable<WareHouseDto> WareHouses { get; set; }

        public ReturnWareHousesFromDB(IWareHouseService wareHouseService, IProductRepository productRepository)
        {
            _productRepository = productRepository;
            var products = GetAllProducts();
            WareHouses = wareHouseService.GetAllWareHouses();
        }

        private IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }
    }
}