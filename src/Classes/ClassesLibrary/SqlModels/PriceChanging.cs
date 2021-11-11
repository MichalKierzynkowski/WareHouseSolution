using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.SqlModels
{
    [Table("PriceChanging")]
    public class PriceChanging
    {
        public int Id_Price { get; set; }
    }
}
