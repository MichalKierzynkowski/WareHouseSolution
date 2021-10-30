using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary.ValidationInterfaces;

namespace ClassesLibrary
{
    public class RulesValidationAddingItem:IRulesValidationAddingItem
    {
        public string ProductInfo{ get; set; }
        public string ProductType { get; set; }
        public string BarNumber { get; set; }
        public string MethodOfBuying{ get; set; }
        public string PriceBuying { get; set; }
        public string PriceSelling { get; set; }
        public string AmountOfProduct { get; set; }
        public RulesValidationAddingItem(string ProductInfo,string ProductType,string BarNumber,string MethodOfBuying,string PriceBuying,string PriceSelling,string AmountOfProduct)
        {
            this.ProductInfo = ProductInfo;
            this.BarNumber = BarNumber;
            this.MethodOfBuying = MethodOfBuying;
            this.PriceBuying = PriceBuying;
            this.PriceSelling = PriceSelling;
            this.AmountOfProduct = AmountOfProduct;
            this.ProductType = ProductType;
            Validation(ProductInfo, ProductType, BarNumber, MethodOfBuying, PriceBuying, PriceSelling, AmountOfProduct);
        }

        public RulesValidationAddingItem()
        {
        }

        public bool Validation(string ProductInfo, string ProductType, string BarNumber, string MethodOfBuying, string PriceBuying, string PriceSelling, string AmountOfProduct)
        {
            if (ProductType.All(char.IsDigit) && BarNumber.All(char.IsDigit) &&  MethodOfBuying.All(char.IsDigit) && PriceBuying.All(char.IsDigit)&& PriceSelling.All(char.IsDigit) && AmountOfProduct.All(char.IsDigit)  )
            {
                return true;
            }

            return false;

        }

       



    }
}
