using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("Purchase_Methods")]
public class Purchase_Methods
{
    public int Purchase_Method { get; set; }
    public string Purchase_Method_Description { get; set; }
}