using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ClassesLibrary.AddItemClasses.Validation
{
    public class BarNumberExistingValidation
    {
        
        public string ConnectionString { get; set; } =ConfigurationManager.ConnectionStrings["Michal"].ConnectionString;
        public BarNumberExistingValidation(decimal  barNumber)
        {
            BarNumber = barNumber;
          
        }
        public decimal  BarNumber { get; set; }

        
        


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
