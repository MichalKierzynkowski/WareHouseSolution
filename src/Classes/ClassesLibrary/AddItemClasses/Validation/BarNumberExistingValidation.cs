using System;
using System.Collections.Generic;
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

       
        public bool IsGivenBarNumberNotExist( string connectionString)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                var exists = connection.Query<object>(
                        "SELECT 1 WHERE EXISTS (SELECT 1 FROM Product WHERE Bar_Number = @barNumber)", new {BarNumber})
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
