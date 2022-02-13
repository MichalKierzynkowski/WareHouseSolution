using System;
using System.Collections.Generic;

namespace WareHouse.Data.Model
{
    public partial class SellingPriceChanging
    {
        public int IdPrice { get; set; }
        public int IdProduct { get; set; }
        public DateTime DatePriceChanged { get; set; }
        public int OldPrice { get; set; }
        public int NewPrice { get; set; }

        public virtual Product IdProductNavigation { get; set; } = null!;
    }
}
