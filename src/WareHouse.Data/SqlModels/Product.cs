using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("Product")]
public class Product
{


    public int IdProduct { get; set; }
    public int IdTypeProduct { get; set; }
    public long BarNumber { get; set; }
    public string DescriptionProduct { get; set; }
    public int IdPurchaseMethod { get; set; }
    public int Quantity { get; set; }
    public decimal OfferPrice { get; set; }
    public bool IsReturned { get; set; }

        
}