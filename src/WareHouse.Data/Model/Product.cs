using System;
using System.Collections.Generic;

namespace WareHouse.Data.Model
{
    public partial class Product
    {
        public Product()
        {
            BuyingPriceChangings = new HashSet<BuyingPriceChanging>();
            Purchases = new HashSet<Purchase>();
            Sales = new HashSet<Sale>();
            SellingPriceChangings = new HashSet<SellingPriceChanging>();
        }

        public int IdProduct { get; set; }
        public int TypeProduct { get; set; }
        public int BarNumber { get; set; }
        public string DescriptionProduct { get; set; } = null!;
        public int PurchaseMethod { get; set; }
        public int Quantity { get; set; }
        public double OfferPrice { get; set; }
        public string? IsReturned { get; set; }

        public virtual PurchaseMethod PurchaseMethodNavigation { get; set; } = null!;
        public virtual ProductType TypeProductNavigation { get; set; } = null!;
        public virtual ICollection<BuyingPriceChanging> BuyingPriceChangings { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<SellingPriceChanging> SellingPriceChangings { get; set; }
    }
}
