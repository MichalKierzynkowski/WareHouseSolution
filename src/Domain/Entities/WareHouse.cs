namespace Domain.Entities
{
    public class WareHouse
    {
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellPrice { get; set; }
        public DateTime Date { get; set; }
        public bool IsReturned { get; set; }
        public ICollection<Sale> Sales { get; set; }

    }
}