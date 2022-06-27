using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using FormsLogic.ProductForm.Logic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Logic.Filtering
{
    public class FilteringDataGridViewByProductType
    {
        public IEnumerable<ProductDto> Products { get; set; }
        public string ProductType { get; set; }
        public FilteringDataGridViewByProductType(string productType, IProductService productService)
        {
            ProductType = productType;
            var getProducts = new ReturnDataFromDb(productService);
            Products = getProducts.Products;
        }
        public IEnumerable<ProductDto> ReturnFilteringProductsByProductType()
        {
            return Products.Where(x => x.ProductDetailDto.Type.ToLower().Contains(ProductType.ToLower())).ToList();
        }
    }
}
