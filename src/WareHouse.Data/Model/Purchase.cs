using System;
using System.Collections.Generic;

namespace WareHouse.Data.Model
{
    public partial class Purchase
    {
        public int IdPurchase { get; set; }
        public int IdProduct { get; set; }
        public DateTime DatePurchase { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public string? FromProductCreate { get; set; }

        public virtual Product IdProductNavigation { get; set; } = null!;
    }
}
