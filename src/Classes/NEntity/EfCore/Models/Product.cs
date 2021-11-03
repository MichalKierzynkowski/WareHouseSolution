using System;
using System.Collections.Generic;

#nullable disable

namespace EfCore.Models
{
    public partial class Product
    {
        public Product()
        {
            Returns = new HashSet<Return>();
            Sales = new HashSet<Sale>();
        }

        public decimal IdProduct { get; set; }
        public decimal? IdWarehouse { get; set; }
        public int? Type { get; set; }
        public int? BarNumber { get; set; }
        public string Description { get; set; }
        public int? PurchaseMethod { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SellPrice { get; set; }

        public virtual Warehouse IdWarehouseNavigation { get; set; }
        public virtual ICollection<Return> Returns { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
