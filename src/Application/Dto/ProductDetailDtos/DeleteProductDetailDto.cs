using ApplicationLayer.Dto.ProductDtos;

namespace ApplicationLayer.Dto.ProductDetailDtos
{
    public class DeleteProductDetailDto:ProductDetailDto
    {
        public DeleteProductDto DeleteProductDto { get; set; }
    }
}