using ApplicationLayer.Dto.ProductDetailDtos;

namespace ApplicationLayer.Dto.ProductDtos
{
    public class CreateProductDto
    {
        public int RegistrationNumber { get; set; }
        public CreateProductDetailDto CreateProductDetailDto { get; set; }
        public DateTime AddedAt { get; set; }

        public CreateProductDto(CreateProductDetailDto createProductDetailDto)
        {
            CreateProductDetailDto = createProductDetailDto;
        }
    }
}