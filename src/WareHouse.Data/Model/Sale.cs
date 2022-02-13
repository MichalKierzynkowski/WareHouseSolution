using System;
using System.Collections.Generic;

namespace WareHouse.Data.Model
{
    public partial class Sale
    {
        public Sale()
        {
            Returns = new HashSet<Return>();
        }

        public int IdSales { get; set; }
        public DateTime DateSales { get; set; }
        public double Profit { get; set; }
        public int IdProduct { get; set; }

        public virtual Product IdProductNavigation { get; set; } = null!;
        public virtual ICollection<Return> Returns { get; set; }
    }
}
