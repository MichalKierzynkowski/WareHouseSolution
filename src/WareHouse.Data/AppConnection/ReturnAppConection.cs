using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Data.AppConnection
{
    public static class ReturnAppConection
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["Michal"].ConnectionString;
    }
}
