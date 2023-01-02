using ApplicationLayer.Dto.ProductDtos;

namespace ApplicationLayer.Dto.ProductDetailDtos
{
    public class DeleteProductDetailDto
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string? ExtraDescription { get; set; }
        public DeleteProductDto DeleteProductDto { get; set; }
    }
}