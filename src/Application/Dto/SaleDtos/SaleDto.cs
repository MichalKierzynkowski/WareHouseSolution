using Domain.Entities;

namespace ApplicationLayer.Dto.Sale
{
    public class SaleDto
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; }
        public decimal EndPrice { get; set; }
        public decimal Discount { get; set; }
        public double Margin { get; set; }
        public decimal Profit { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Domain.Entities.WareHouse> WareHouses { get; set; }
        public ICollection<Return> Returns { get; set; }
    }
}
