using ApplicationLayer.Dto.ProductDetailDtos;

namespace ApplicationLayer.Dto.ProductDtos
{
    public class DeleteProductDto
    {
        public int RegistrationNumber { get; set; }
        public DeleteProductDetailDto DeleteProductDetailDto { get; set; }
        public DateTime AddedAt { get; set; }
        public DeleteProductDto(DeleteProductDetailDto deleteProductDetail)
        {
            DeleteProductDetailDto = deleteProductDetail;
        }
    }
}
