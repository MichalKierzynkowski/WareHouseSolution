using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("Purchase")]
public class Purchase
{
    public int Id_Purchase { get; set; }
    public int Id_Product { get; set; }
    public DateTime Date_Purchase { get; set; }
    public int Amount { get; set; }
    public int Price { get; set; }
}