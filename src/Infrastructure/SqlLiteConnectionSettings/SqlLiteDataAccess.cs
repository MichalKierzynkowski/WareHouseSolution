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

            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString.ToString();

        }
    }
}
