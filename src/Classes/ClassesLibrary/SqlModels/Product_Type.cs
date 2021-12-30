using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.SqlModels
{
    [Table("Product_Type")]
    public class Product_Type
    {

        public int Type_Product { get; set; }
        public string Product_Type_Description { get; set; }
    }
}
