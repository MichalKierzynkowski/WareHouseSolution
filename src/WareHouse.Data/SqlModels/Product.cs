using System.ComponentModel.DataAnnotations.Schema;

namespace ClassesLibrary.SqlModels
{
    [Table("Product")]
    public class Product
    {


        public int IdProduct { get; set; }
        public int IdTypeProduct { get; set; }
        public int BarNumber { get; set; }
        public string DescriptionProduct { get; set; }
        public int IdPurchaseMethod { get; set; }
        public int Quantity { get; set; }
        public double Offer_Price { get; set; }
        public string IsReturned { get; set; }

        
    }
}
