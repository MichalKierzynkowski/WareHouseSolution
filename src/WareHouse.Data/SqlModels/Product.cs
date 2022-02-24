using System.ComponentModel.DataAnnotations.Schema;

namespace ClassesLibrary.SqlModels
{
    [Table("Product")]
    public class Product
    {


        public int IdProduct { get; set; }
        public string IdTypeProduct { get; set; }
        public string BarNumber { get; set; }
        public string DescriptionProduct { get; set; }
        public string IdPurchaseMethod { get; set; }
        public string Quantity { get; set; }
        public string  Offer_Price { get; set; }
        public string IsReturned { get; set; }

        
    }
}
