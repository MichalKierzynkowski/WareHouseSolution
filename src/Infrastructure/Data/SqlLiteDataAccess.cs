using Dapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class SqlLiteDataAccess
    {
        private readonly string _connectionString;
        public SqlLiteDataAccess()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString.ToString();
            TestingUseOfDataBase();
        }
        public void TestingUseOfDataBase()
        {
            using (IDbConnection cnn = new SQLiteConnection(_connectionString))
            {
                var list = cnn.Query<ProductDetail>("SELECT * FROM sqlite_master", new DynamicParameters());
                int test = 5;
            }
        }
    }
}
