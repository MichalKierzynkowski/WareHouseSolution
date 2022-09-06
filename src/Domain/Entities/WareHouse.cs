namespace Domain.Entities
{
    public class WareHouse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public DateTime AddedAt { get; set; }
        public Product Product { get; set; }
        public bool IsReturned { get; set; }

    }
}
