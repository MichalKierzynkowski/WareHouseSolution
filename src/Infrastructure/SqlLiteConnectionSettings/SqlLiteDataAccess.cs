using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SqlLiteConnectionSettings
{
    public class SqlLiteDataAccess : ISqlLiteDataAccess
    {

        public string ReturnConnectionString()
        {

            return @"Data Source=C:\Users\Integra\source\repos\MichalKierzynkowski\WareHouseSolution\SqlLiteDataBase\DataBase.db;Version=3;";

        }
    }
}
