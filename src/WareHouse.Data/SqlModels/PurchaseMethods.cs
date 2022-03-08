using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("PurchaseMethods")]
public class PurchaseMethods
{
    public int PurchaseMethod { get; set; }
    public string PurchaseMethodDescription { get; set; }
}