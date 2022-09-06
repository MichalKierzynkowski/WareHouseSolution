using ApplicationLayer.Dto.ProductDetailDtos;

namespace ApplicationLayer.Interfaces
{
    public interface IProductDetailService
    {
        IEnumerable<ProductDetailDto> GetAllProductDetails();

        ProductDetailDto GetProductById(int id);
    }
}