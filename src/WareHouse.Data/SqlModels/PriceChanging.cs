using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("PriceChanging")]
public class PriceChanging
{
    public int IdPrice { get; set; }
}