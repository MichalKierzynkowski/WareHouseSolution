using System;
using System.Collections.Generic;

namespace WareHouse.Data.Model
{
    public partial class PurchaseMethod
    {
        public PurchaseMethod()
        {
            Products = new HashSet<Product>();
        }

        public int PurchaseMethod1 { get; set; }
        public string PurchaseMethodDescription { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
