using ApplicationLayer.Dto.ProductDetailDtos;

namespace ApplicationLayer.Dto.ProductDtos
{
    public class DeleteProductDto:ProductDto
    {
        public DeleteProductDetailDto DeleteProductDetailDto { get; set; }
        public DeleteProductDto(DeleteProductDetailDto deleteProductDetail)
        {
            DeleteProductDetailDto = deleteProductDetail;
        }
    }
}