using ApplicationLayer.Dto.ProductDetailDtos;

namespace ApplicationLayer.Dto.ProductDtos
{
    public class UpdateProductDto:ProductDto
    {
        public UpdateProductDetailDto EditProductDetailDto { get; set; }
        public UpdateProductDto(UpdateProductDetailDto editProductDetailDto)
        {
            EditProductDetailDto = editProductDetailDto;
        }
    }
}