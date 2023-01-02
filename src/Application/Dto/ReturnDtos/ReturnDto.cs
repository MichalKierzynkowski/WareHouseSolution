using Domain.Entities;

namespace ApplicationLayer.Dto.ReturnDtos
{
    public class ReturnDto
    {
        public ICollection<Product> Products { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellPrice { get; set; }
        public DateTime Date { get; set; }
        public string IsReturned { get; set; }
        public ReturnDto()
        {

        }
    }
}