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
            return @"C:\Users\Integra\Source\Repos\MichalKierzynkowski\WareHouseSolution\src\WareHouseApplication\WareHouse.db;Version=3;";
        }
    }
}