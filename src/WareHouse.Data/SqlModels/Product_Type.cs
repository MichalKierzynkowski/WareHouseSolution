using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("Product_Type")]
public class Product_Type
{

    public int Type_Product { get; set; }
    public string Product_Type_Description { get; set; }
}