using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("Purchase")]
public class Returns
{
    public int IdReturns { get; set; }
    public int IdSales { get; set; }
    public DateTime DateReturns { get; set; }
}