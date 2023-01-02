using ApplicationLayer.Dto.ProductDetailDtos;

namespace ApplicationLayer.Dto.ProductDtos
{
    public class ExportProductDto
    {
        public int RegistrationNumber { get; set; }
        public ExportProductDetailDto ProductDetailDto { get; set; }
        public DateTime AddedAt { get; set; }
        public ExportProductDto(ExportProductDetailDto exportProduct)
        {
            ProductDetailDto = exportProduct;
        }
    }
}