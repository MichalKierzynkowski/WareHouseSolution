using System;
using System.Collections.Generic;

namespace WareHouse.Data.Model
{
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        public int TypeProduct { get; set; }
        public string ProductTypeDescription { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
