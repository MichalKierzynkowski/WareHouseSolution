using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary.SqlModels;


namespace ClassesLibrary.AddItemClasses.Validation
{
    public class Validate
    {
        public Validate(Product product)
        {
            Product = product;
        }

        public Product Product { get; }


    }
}
