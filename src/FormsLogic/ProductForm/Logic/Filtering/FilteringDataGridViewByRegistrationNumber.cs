using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using FormsLogic.ProductForm.Logic.Data.Return;

namespace FormsLogic.ProductForm.Logic.Filtering
{
    public class FilteringDataGridViewByRegistrationNumber
    {
        public IEnumerable<ProductDto> Products { get; set; }
        public int RegistrationNumber { get; set; }
        public FilteringDataGridViewByRegistrationNumber(int registrationNumber, IProductService productService)
        {
            RegistrationNumber = registrationNumber;
            var getProducts = new ReturnProductsFromDB(productService);
            Products = getProducts.Products;
        }

        public IEnumerable<ProductDto> ReturnFilteringProductsByRegistrationNumber()
        {
            return Products.Where(x => x.RegistrationNumber == RegistrationNumber).ToList();
        }
    }
}