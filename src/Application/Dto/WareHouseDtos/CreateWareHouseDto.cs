using ApplicationLayer.Dto.ProductDtos;
using Domain.Entities;

namespace ApplicationLayer.Dto.WareHouse
{
    public class CreateWareHouseDto
    {
        public int ProductRegistrationNumber { get; set; }
        public ICollection<Product> Products { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellPrice { get; set; }
        public DateTime Date { get; set; }
        public string Unit { get; set; }
        public bool IsReturned { get; set; }
        public CreateWareHouseDto()
        {
                
        }
    }
}