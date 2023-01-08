using System.Collections;

namespace Domain.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; }
        public decimal EndPrice { get; set; }
        public decimal Discount { get; set; }
        public double Dreams { get; set; }
        public decimal Profit { get; set; }
        public ICollection<WareHouse> WareHouses { get; set; }
        public ICollection<Return> Returns { get; set; }

    }
}
