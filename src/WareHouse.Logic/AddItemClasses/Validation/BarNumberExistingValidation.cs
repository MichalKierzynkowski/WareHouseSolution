using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

using WareHouse.Data.Repository;

namespace ClassesLibrary.AddItemClasses.Validation
{
    public class BarNumberExistingValidation
    {

        ProductRepository productRepository { get; set; }
        public BarNumberExistingValidation(decimal  barNumber)
        {
            BarNumber = barNumber;
            productRepository =  new ProductRepository();
          
        }
        public decimal  BarNumber { get; set; }

        
        


        public bool IsGivenBarNumberExist( )
        {

            return productRepository.CheckExistenceOfBarNumber(BarNumber);
            
            

            
        }
    }
}
