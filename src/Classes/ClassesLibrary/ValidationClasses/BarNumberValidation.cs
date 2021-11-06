using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ClassesLibrary.ValidationClasses
{
    public class BarNumberValidation
    {

        public BarNumberValidation()
        {
            
        }

        public  bool Validation(string barNumber)
        {
            string connectionString = "Data Source=DESKTOP-DQ7DARP\\SQLEXPRESS; Initial Catalog=WareHouse;User ID=; Integrated Security=SSPI;Persist Security Info=False;";
            using (var connection = new SqlConnection(connectionString))
            {
                var exists = connection.Query<object>(
            "SELECT 1 WHERE EXISTS (SELECT 1 FROM Product WHERE Bar_Number = @barNumber)", new { barNumber })
                 .Any();

                connection.Close();
                if (exists==true)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
        }
    }
}

