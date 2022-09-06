using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;

namespace FormsLogic.ProductForm.Logic.Data
{
    public class ReturnDataFromDb
    {
        public IEnumerable<ProductDto> Products { get; set; }

        public ReturnDataFromDb(IProductService productService)
        {
            Products = productService.GetAllProducts().ToList();
        }
    }
}