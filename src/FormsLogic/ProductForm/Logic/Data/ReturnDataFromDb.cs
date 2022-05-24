using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using ApplicationLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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