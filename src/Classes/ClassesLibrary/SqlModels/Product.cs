using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.SqlModels
{
    [Table("Product")]
    public  class Product
    {
       
        
            public int Id_Product { get; set; }
            public int Type_Product { get; set; }
            public int Bar_Number { get; set; }
            public string Description_Product { get; set; }
            public int Purchase_Method { get; set; }
            public int Quantity { get; set; }
            public double Offer_Price { get; set; }
        
    }
}
