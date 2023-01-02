namespace ApplicationLayer.Dto.ProductDetailDtos
{
    public class UpdateProductDetailDto:ProductDetailDto
    {
        public DateTime? LastChangedAt { get; set; }
    }
}