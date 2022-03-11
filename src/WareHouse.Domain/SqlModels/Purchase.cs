using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("Purchase")]
public class Purchase
{
    public Guid IdPurchase { get; set; }
    public Guid IdProduct { get; set; }
    public DateTime DatePurchase { get; set; }
    public int Amount { get; set; }
    public decimal PurchasePrice { get; set; }
}