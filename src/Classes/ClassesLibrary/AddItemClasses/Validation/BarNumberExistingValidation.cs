using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ClassesLibrary.AddItemClasses.Validation
{
    public class BarNumberExistingValidation
    {
        public BarNumberExistingValidation(int  barNumber)
        {
            BarNumber = barNumber;
        }
        public int  BarNumber { get; set; }

        public string ConnectionString { get; set; } =
            "Data Source=DESKTOP-DQ7DARP\\SQLEXPRESS;Initial Catalog=WareHouse;User ID =DESKTOP-DQ7DARP\\Michal; Integrated Security=SSPI;Persist Security Info=False;Encrypt=True;TrustServerCertificate=True;";
        public bool IsGivenBarNumberExist( )
        {

            using (var connection = new SqlConnection(ConnectionString))
            {
                var exists = connection.Query<object>(
                        "SELECT 1 WHERE EXISTS (SELECT 1 FROM Product WHERE BarNumber = @barNumber)", new { BarNumber })
                    .Any();

                connection.Close();
                return exists;


            }
        }
    }
}
