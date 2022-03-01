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
        public BarNumberExistingValidation(string barNumber)
        {
            barNumber = BarNumber;
        }
        public string BarNumber { get; set; }
        public string ConnectionString { get; set; } = ConfigurationManager.ConnectionStrings["MichalPC"].ConnectionString;

        public bool IsGivenBarNumberNotExist( )
        {

            using (var connection = new SqlConnection(ConnectionString))
            {
                var exists = connection.Query<object>(
                        "SELECT 1 WHERE EXISTS (SELECT 1 FROM Product WHERE Bar_Number = @barNumber)", new { BarNumber })
                    .Any();

                connection.Close();
                if (exists == true)
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
