using ApplicationLayer.Dto.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetAllProducts();

        ProductDto GetProductById(int id);

        ProductDto GetProductByRegistrationNumber(int registrationNumber);

        ProductDto AddNewProduct(CreateProductDto newProduct);

        void UpdateProduct(int id, UpdateProductDto product);

        void DeleteProductById(int id);
        void DeleteProductByRegistrationNumber(int registrationNumber);
    }
}