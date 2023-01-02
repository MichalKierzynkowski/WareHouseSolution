namespace ApplicationLayer.Dto.ProductDtos
{
    public class GetProductDtoForSale:GetProductDto
    {
        public int Amount { get; set; }
        public decimal SellPrice { get; set; }
    }
}
