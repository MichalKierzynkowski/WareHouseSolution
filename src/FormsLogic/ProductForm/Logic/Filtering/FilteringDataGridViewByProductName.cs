using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using FormsLogic.ProductForm.Logic.Data;

namespace FormsLogic.ProductForm.Logic.Filtering
{
    public class FilteringDataGridViewByProductName
    {
        public IEnumerable<ProductDto> Products { get; set; }
        public string ProductName { get; set; }
        public FilteringDataGridViewByProductName(string productName, IProductService productService)
        {
            ProductName = productName;
            var getProducts = new ReturnDataFromDb(productService);
            Products = getProducts.Products;
        }
        public IEnumerable<ProductDto> ReturnFilteringProductsByProductName()
        {
            return Products.Where(x => x.ProductDetailDto.Name.ToLower().Contains(ProductName.ToLower())).ToList();
        }

    }
}
