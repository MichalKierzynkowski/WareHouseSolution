using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;


namespace WareHouse.Data.AppConnection
{
    public static class ReturnAppConection
    {
        //public static string ConnectionString => ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        //work -
        public static string ConnectionString = "Data Source=DESKTOP-4NURNJC; Initial Catalog=WareHouse;Trusted_Connection=True; Integrated Security=SSPI;Persist Security Info=False;Encrypt=False;TrustServerCertificate=True;";
        //pc
        //public static string ConnectionString =
        //    "Data Source=DESKTOP-GI0C1PC\\SQLEXPRESS;Initial Catalog=WareHouse;Trusted_Connection=True; Integrated Security=SSPI;Persist Security Info=False;Encrypt=False;TrustServerCertificate=True; ";
    }
}
