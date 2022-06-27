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
