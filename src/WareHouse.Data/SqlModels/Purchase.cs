using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("Purchase")]
public class Purchase
{
    public int IdPurchase { get; set; }
    public int IdProduct { get; set; }
    public DateTime DatePurchase { get; set; }
    public int Amount { get; set; }
    public int Price { get; set; }
}