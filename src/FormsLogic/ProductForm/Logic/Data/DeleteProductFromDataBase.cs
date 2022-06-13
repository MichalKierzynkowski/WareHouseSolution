using ApplicationLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Logic.Data
{
    public class DeleteProductFromDataBase
    {
        public int RegisterNumber { get; set; }
        public IProductService ProductService { get; set; }
        public DeleteProductFromDataBase(int registerNumber, IProductService productService)
        {
            RegisterNumber = registerNumber;
            ProductService = productService;
            DeleteProduct();
        }
        public void DeleteProduct()
        {
            ProductService.DeleteProductByRegistrationNumber(RegisterNumber);
        }
    }
}
