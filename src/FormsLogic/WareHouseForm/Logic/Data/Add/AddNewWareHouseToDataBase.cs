using ApplicationLayer.Dto.WareHouse;
using ApplicationLayer.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace FormsLogic.WareHouse.Logic.Data.Add
{
    public class AddNewWareHouseToDataBase
    {
        private readonly CreateWareHouseDto _createWareHouseDto;
        private readonly IWareHouseService _wareHouseService;
        private readonly IProductRepository _productRepository;

        public AddNewWareHouseToDataBase(CreateWareHouseDto createWareHouseDto, IWareHouseService wareHouseService, IProductRepository productRepository)
        {
            _createWareHouseDto = createWareHouseDto;
            _wareHouseService = wareHouseService;
            _productRepository = productRepository;
            AddNewWareHouse();
        }

        private void AddNewWareHouse()
        {
            EinrichWareHouse();
            _wareHouseService.AddNewWareHouse(_createWareHouseDto);
        }

        private void EinrichWareHouse()
        {
            _createWareHouseDto.Unit = "szt";
            _createWareHouseDto.IsReturned = "Nie";
            var product = GetProductByRegistrationNumber();

            _createWareHouseDto.Products = new List<Product>()
            {
                product
            };
        }

        private Product GetProductByRegistrationNumber()
        {
            return _productRepository.GetByRegistrationNumber(_createWareHouseDto.ProductRegistrationNumber);
        }
    }
}