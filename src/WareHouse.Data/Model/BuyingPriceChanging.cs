using System;
using System.Collections.Generic;

namespace WareHouse.Data.Model
{
    public partial class BuyingPriceChanging
    {
        public int IdPrice { get; set; }
        public int IdProduct { get; set; }
        public DateTime DatePriceChanged { get; set; }
        public double OldPrice { get; set; }
        public double? NewPrice { get; set; }

        public virtual Product IdProductNavigation { get; set; } = null!;
    }
}
