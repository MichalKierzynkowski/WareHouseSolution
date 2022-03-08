using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("Users")]
public class Users
{
    public int IdUsers { get; set; }
    public string LoginUser { get; set; }
    public string PasswordUser { get; set; }


}