using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime? LastChangedAt { get; set; }
        public string? ExtraDescription { get; set; }
        public Product Product { get; set; }
    }
}