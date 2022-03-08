using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("Sales")]
public class Sales
{
    public int IdSales { get; set; }
    public DateTime DateSales { get; set; }
    public double Profit { get; set; }
    public int IdProduct { get; set; }
}