using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;

namespace FormsLogic.ProductForm.Logic.Data
{
    public class AddNewProductToDataBase
    {
        public CreateProductDto CreateProductDto { get; set; }
        public IProductService ProductService { get; set; }

        public AddNewProductToDataBase(CreateProductDto createProductDto, IProductService productService)
        {
            CreateProductDto = createProductDto;
            ProductService = productService;
            AddNewProduct();
        }

        public void AddNewProduct()
        {
            ProductService.AddNewProduct(CreateProductDto);
        }
    }
}