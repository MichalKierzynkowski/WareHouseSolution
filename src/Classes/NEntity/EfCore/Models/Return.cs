using System;
using System.Collections.Generic;

#nullable disable

namespace EfCore.Models
{
    public partial class Return
    {
        public decimal IdReturns { get; set; }
        public decimal? ProIdProduct { get; set; }
        public int? IdProduct { get; set; }
        public DateTime? Date { get; set; }

        public virtual Product ProIdProductNavigation { get; set; }
    }
}
