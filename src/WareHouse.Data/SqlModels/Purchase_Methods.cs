using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.SqlModels
{
    [Table("Purchase_Methods")]
    public class Purchase_Methods
    {
        public int Purchase_Method { get; set; }
        public string Purchase_Method_Description { get; set; }
    }
}
