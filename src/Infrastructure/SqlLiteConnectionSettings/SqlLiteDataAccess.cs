namespace Infrastructure.SqlLiteConnectionSettings
{
    public class SqlLiteDataAccess : ISqlLiteDataAccess
    {
        public string ReturnConnectionString()
        {
            return @"Data Source=.\WareHouse.db;Version=3;";
        }
    }
}