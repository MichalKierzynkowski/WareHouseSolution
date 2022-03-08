using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("Purchase_Methods")]
public class Purchase_Methods
{
    public int PurchaseMethod { get; set; }
    public string PurchaseMethodDescription { get; set; }
}