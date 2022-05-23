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
        public int RegistrationNumber { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public DateTime AddedAt { get; set; }
    }
}