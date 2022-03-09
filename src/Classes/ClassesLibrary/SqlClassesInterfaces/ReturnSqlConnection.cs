namespace ClassesLibrary.SqlClassesInterfaces;

public class ReturnSqlConnection : IReturnSql
{
    public string ReturnSqlLaptop()
    {
        return "Data Source=DESKTOP-DQ7DARP\\\\SQLEXPRESS; Initial Catalog=WareHouse;User ID =DESKTOP-DQ7DARP\\Michal; Integrated Security=SSPI;Persist Security Info=False;Encrypt=True;TrustServerCertificate=True;";
    }

    public string ReturnSqlPc()
    {
        return "Data Source=DESKTOP-GI0C1PC\\SQLEXPRESS;; Initial Catalog=WareHouse;User ID=; Integrated Security=SSPI;Persist Security Info=False;";
    }
   
}