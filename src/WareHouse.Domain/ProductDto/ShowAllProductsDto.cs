namespace WareHouse.Domain.ProductDto
{
    public class ShowAllProductsDto
    {
        public int BarNumber { get; set; }
        public string DescriptionProduct { get; set; }
        public int Quantity { get; set; }
        public decimal CurrentSellingPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public string PurchaseMethodDescription { get; set; }
        public string ProductTypeDescription { get; set; }
        public bool IsReturned { get; set; }
        public DateTime AddedAt { get; set; }

    }
}
