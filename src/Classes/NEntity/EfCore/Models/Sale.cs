using System;
using System.Collections.Generic;

#nullable disable

namespace EfCore.Models
{
    public partial class Sale
    {
        public decimal IdSales { get; set; }
        public decimal? ProIdProduct { get; set; }
        public int? IdProduct { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Profit { get; set; }
        public int? Quantity { get; set; }

        public virtual Product ProIdProductNavigation { get; set; }
    }
}
