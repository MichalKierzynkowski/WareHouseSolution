using ApplicationLayer.Dto.ProductDtos;

namespace ApplicationLayer.Dto.ProductDetailDtos
{
    public class CreateProductDetailDto
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string? ExtraDescription { get; set; }
        public CreateProductDto CreateProductDto { get; set; }
    }
}