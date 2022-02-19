using System.ComponentModel.DataAnnotations.Schema;

namespace ClassesLibrary.SqlModels
{
    [Table("PriceChanging")]
    public class PriceChanging
    {
        public int Id_Price { get; set; }
    }
}
