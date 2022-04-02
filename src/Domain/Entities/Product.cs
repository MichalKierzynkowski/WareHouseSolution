using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductDetailId { get; set; }
        public int RegistrationNumber { get; set; }
        public string ExtraDescription { get; set; }
        public DateTime AddedAt { get; set; }


    }
}
