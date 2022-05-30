using ApplicationLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Logic.Edit
{
    public class SwapProductWithEditProduct
    {
        public IProductService ProductService { get; set; }

        public SwapProductWithEditProduct(IProductService productService)
        {
            ProductService = productService;
            SwapProduct();
        }

        private void SwapProduct()
        {
        }
    }
}