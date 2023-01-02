using ApplicationLayer.Dto.ReturnDtos;
using ApplicationLayer.Dto.WareHouse;
using ApplicationLayer.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace FormsLogic.Return.Logic.Data.Return
{
    public class ReturnReturnItemFromDB
    {
        private readonly IReturnService _returnService;
        private readonly IProductRepository _productRepository;
        public IEnumerable<ReturnDto> Returns { get; set; }

        public ReturnReturnItemFromDB(IReturnService returnService, IProductRepository productRepository)
        {
            _returnService = returnService;
            _productRepository = productRepository;
            var products = GetAllProducts();
            Returns = returnService.GetAllReturns();
        }

        private IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }
    }
}