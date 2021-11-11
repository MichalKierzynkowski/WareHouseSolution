using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.SqlModels
{
    [Table("Sales")]
    public  class Sales
    {
        public int Id_Sales { get; set; }
        public DateTime Date_Sales { get; set; }
        public double Profit { get; set; }
        public int Id_Product { get; set; }
    }
}
