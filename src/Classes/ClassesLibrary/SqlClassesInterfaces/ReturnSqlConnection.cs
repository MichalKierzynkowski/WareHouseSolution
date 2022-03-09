namespace ClassesLibrary.SqlClassesInterfaces;

public class ReturnSqlConnection : IReturnSql
{
   //Laptop
        public string ReturnSqlLaptop()
    {
       return "Data Source=DESKTOP-DQ7DARP\\SQLEXPRESS; Initial Catalog=WareHouse;User ID =DESKTOP-DQ7DARP\\Michal; Integrated Security=SSPI;Persist Security Info=False;Encrypt=True;TrustServerCertificate=True;";
    }

   //PC
        public string ReturnSqla()
    {
        return "Data Source=DESKTOP-GI0C1PC\\SQLEXPRESS;; Initial Catalog=WareHouse;User ID=; Integrated Security=SSPI;Persist Security Info=False;";
   }

    //Praca
    public string ReturnSql()
    {
        return "Data Source=DESKTOP-4NURNJC; Initial Catalog=WareHouse;Trusted_Connection=True; Integrated Security=SSPI;Persist Security Info=False;Encrypt=False;TrustServerCertificate=True;";
    }

    



}