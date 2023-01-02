using ApplicationLayer.Dto.ProductDetailDtos;

namespace ApplicationLayer.Dto.ProductDtos
{
    public class CreateProductDto:ProductDto
    {
        public CreateProductDetailDto CreateProductDetailDto { get; set; }
        public CreateProductDto(CreateProductDetailDto createProductDetailDto)
        {
            CreateProductDetailDto = createProductDetailDto;
        }
    }
}