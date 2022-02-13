using System;
using System.Collections.Generic;

namespace WareHouse.Data.Model
{
    public partial class Return
    {
        public int IdReturns { get; set; }
        public int IdSales { get; set; }
        public DateTime DateReturns { get; set; }

        public virtual Sale IdSalesNavigation { get; set; } = null!;
    }
}
