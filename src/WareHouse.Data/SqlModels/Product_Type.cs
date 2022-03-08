using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("Product_Type")]
public class Product_Type
{

    public int TypeProduct { get; set; }
    public string ProductTypeDescription { get; set; }
}