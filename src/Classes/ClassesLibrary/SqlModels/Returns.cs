using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.SqlModels
{
    [Table("Purchase")]
    public class Returns
    {
        public int Id_Returns { get; set; }
        public int Id_Sales { get; set; }
        public DateTime Date_Returns { get; set; }
    }
}
