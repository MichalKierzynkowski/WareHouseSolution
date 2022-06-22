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
    public class FilteringDataGridViewByProductDescription
    {
        public IEnumerable<ProductDto> Products { get; set; }
        public string ProductDescription { get; set; }
        public FilteringDataGridViewByProductDescription(string productDescription, IProductService productService)
        {
            ProductDescription = productDescription;
            var getProducts = new ReturnDataFromDb(productService);
            Products = getProducts.Products;
        }
        public IEnumerable<ProductDto> ReturnFilteringProductsByProductDescription()
        {
            return Products.Where(x => x.ProductDetailDto.ExtraDescription.ToLower().StartsWith(ProductDescription.ToLower())).ToList();
        }
    }
}
