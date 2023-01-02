using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;

namespace FormsLogic.ProductForm.Logic.Data.Return
{
    public class ReturnProductsFromDB
    {
        public IEnumerable<ProductDto> Products { get; set; }

        public ReturnProductsFromDB(IProductService productService)
        {
            Products = productService.GetAllProducts().ToList();
        }
    }
}