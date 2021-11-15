using System;
using System.ComponentModel.DataAnnotations.Schema;

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
