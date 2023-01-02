using ApplicationLayer.Dto.ReturnDtos;
using ApplicationLayer.Dto.WareHouse;
using ApplicationLayer.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace FormsLogic.Return.Logic.Data
{
    public class AddNewReturnToDataBase
    {
        private readonly CreateReturnDto _createReturnDto;
        private readonly IReturnService _returnService;
        private readonly IProductRepository _productRepository;

        public AddNewReturnToDataBase(CreateReturnDto createReturnDto, IReturnService returnService, IProductRepository productRepository)
        {
            _createReturnDto = createReturnDto;
            _returnService = returnService;
            _productRepository = productRepository;
            AddNewReturn();
        }

        private void AddNewReturn()
        {
            EinrichReturn();
            _returnService.AddNewReturn(_createReturnDto);
        }

        private void EinrichReturn()
        {
            _createReturnDto.Unit = "szt";
            _createReturnDto.IsReturned = true;
            var product = GetProductByRegistrationNumber();

            _createReturnDto.Products = new List<Product>()
            {
                product
            };
        }
        private Product GetProductByRegistrationNumber()
        {
            return _productRepository.GetByRegistrationNumber(_createReturnDto.ProductRegistrationNumber);
        }
    }
}