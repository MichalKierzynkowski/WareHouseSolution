using System;
using System.Collections.Generic;

#nullable disable

namespace EfCore.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            Products = new HashSet<Product>();
        }

        public decimal IdWarehouse { get; set; }
        public int? IdProduct { get; set; }
        public int? Quantity { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
