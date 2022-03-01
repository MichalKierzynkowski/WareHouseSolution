using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Data.SqlModels;

[Table("Users")]
public class Users
{
    public int Id_Users { get; set; }
    public string Login_User { get; set; }
    public string Password_User { get; set; }


}