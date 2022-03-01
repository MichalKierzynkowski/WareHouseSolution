namespace ClassesLibrary.SqlClassesInterfaces;

public class ReturnSqlConnection : IReturnSql
{
    public string ReturnSqlLaptop()
    {
        return "Data Source=DESKTOP-DQ7DARP\\SQLEXPRESS; Initial Catalog=WareHouse;User ID=; Integrated Security=SSPI;Persist Security Info=False;";
    }

    public string ReturnSqlPc()
    {
        return "Data Source=DESKTOP-GI0C1PC\\SQLEXPRESS;; Initial Catalog=WareHouse;User ID=; Integrated Security=SSPI;Persist Security Info=False;";
    }
}