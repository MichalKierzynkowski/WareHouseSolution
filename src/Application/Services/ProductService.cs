using Application.Dto.Product;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<ProductDto> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public ProductDto GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public ProductDto AddNewProduct(CreateProductDto newProduct)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int id, UpdateProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}