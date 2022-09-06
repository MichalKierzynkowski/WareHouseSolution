namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int RegistrationNumber { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public DateTime AddedAt { get; set; }
    }
}