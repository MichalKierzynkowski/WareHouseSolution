using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace ClassesLibrary.ValidationClasses
{
    public class BarNumberValidation
    {

        public BarNumberValidation()
        {

        }

        public bool Validation(string barNumber, string connectionString)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                var exists = connection.Query<object>(
            "SELECT 1 WHERE EXISTS (SELECT 1 FROM Product WHERE Bar_Number = @barNumber)", new { barNumber })
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

