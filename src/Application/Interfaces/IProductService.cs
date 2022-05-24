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
        IQueryable<ProductDto> GetAllProducts();

        ProductDto GetProductById(int id);

        ProductDto AddNewProduct(CreateProductDto newProduct);

        void UpdateProduct(int id, UpdateProductDto product);

        void DeleteProduct(int id);
    }
}