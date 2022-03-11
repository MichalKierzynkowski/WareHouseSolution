using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("Users")]
public class User
{
    //
    public int IdUser { get; set; }
    public string LoginUser { get; set; }
    public string PasswordUser { get; set; }


}