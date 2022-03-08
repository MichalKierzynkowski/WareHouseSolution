using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.AddItemClasses.Validation
{
    public class BarNumberValidation
    {
        

        public BarNumberValidation(string connectionString, decimal barNumber) 
        {
            Value = value;
        }

        public string ConnectionString { get; }
        public decimal BarNumber { get; }
    }
}
