using System.ComponentModel.DataAnnotations.Schema;


namespace WareHouse.Data.SqlModels;

[Table("Product")]
public class Product
{


    public Guid IdProduct { get; set; }
    public string IdTypeProduct { get; set; }
    public string IdPurchaseMethod { get; set; }
    public int BarNumber { get; set; }
    public string DescriptionProduct { get; set; }
    public int Quantity { get; set; }
    public decimal CurrentSellingPrice { get; set; }
    public bool IsReturned { get; set; }
    public DateTime AddedAt { get; set; }
    public Purchase Purchase { get; set; }


   
}