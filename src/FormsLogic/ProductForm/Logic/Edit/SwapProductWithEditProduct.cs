using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;

namespace FormsLogic.ProductForm.Logic.Edit
{
    public class SwapProductWithEditProduct
    {
        public IProductService ProductService { get; set; }
        public UpdateProductDto ProductToUpdate { get; set; }

        public SwapProductWithEditProduct(IProductService productService, UpdateProductDto productToUpdate)
        {
            ProductService = productService;
            ProductToUpdate = productToUpdate;
            SwapProduct();
        }

        private void SwapProduct()
        {
            ProductService.UpdateProduct(ProductToUpdate.RegistrationNumber, ProductToUpdate);
        }
    }
}