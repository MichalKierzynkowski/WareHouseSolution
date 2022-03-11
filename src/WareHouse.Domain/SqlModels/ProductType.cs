using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("ProductType")]
public class ProductType
{

    public int TypeProduct { get; set; }
    public string ProductTypeDescription { get; set; }
}