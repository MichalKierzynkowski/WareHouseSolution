using ApplicationLayer.Dto.ProductDetailDtos;

namespace ApplicationLayer.Dto.ProductDtos
{
    public class UpdateProductDto
    {
        public int RegistrationNumber { get; set; }
        public UpdateProductDetailDto EditProductDetailDto { get; set; }
        public DateTime AddedAt { get; set; }

        public UpdateProductDto(UpdateProductDetailDto editProductDetailDto)
        {
            EditProductDetailDto = editProductDetailDto;
        }
    }
}