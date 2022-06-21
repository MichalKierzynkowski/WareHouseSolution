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
    public class FilteringDataGridViewByRegistrationNumber
    {
        public IEnumerable<ProductDto> Products { get; set; }
        public int RegistrationNumber { get; set; }
        public FilteringDataGridViewByRegistrationNumber(int registrationNumber, IProductService productService)
        {
            RegistrationNumber = registrationNumber;
            var getProducts = new ReturnDataFromDb(productService);
            Products = getProducts.Products;
        }

        public IEnumerable<ProductDto> ReturnFilteringProductsByRegistrationNumber()
        {
            return Products.Where(x => x.RegistrationNumber == RegistrationNumber).ToList();
        }
    }
}
