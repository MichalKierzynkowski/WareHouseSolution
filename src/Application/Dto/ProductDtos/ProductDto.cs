using ApplicationLayer.Dto.ProductDetailDtos;

namespace ApplicationLayer.Dto.ProductDtos
{
    public class ProductDto
    {
        public int RegistrationNumber { get; set; }
        public ProductDetailDto ProductDetailDto { get; set; }
        public DateTime AddedAt { get; set; }

    }
}