using ApplicationLayer.Dto.ProductDtos;

namespace ApplicationLayer.Dto.ProductDetailDtos
{
    public class CreateProductDetailDto:ProductDetailDto
    {
        public CreateProductDto CreateProductDto { get; set; }
    }
}