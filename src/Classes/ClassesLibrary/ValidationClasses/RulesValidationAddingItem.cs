using ClassesLibrary.ValidationInterfaces;
using System.Linq;

namespace ClassesLibrary
{
    public class RulesValidationAddingItem : IRulesValidationAddingItem
    {
        public string ProductInfo { get; set; }
        public string ProductType { get; set; }
        public string BarNumber { get; set; }
        public string MethodOfBuying { get; set; }
        public string BuyingPrice { get; set; }
        public string PriceSelling { get; set; }
        public string AmountOfProduct { get; set; }
        public RulesValidationAddingItem(string ProductInfo, string ProductType, string BarNumber, string MethodOfBuying, string AmountOfProduct)
        {
            this.ProductInfo = ProductInfo;
            this.BarNumber = BarNumber;
            this.MethodOfBuying = MethodOfBuying;
            this.BuyingPrice = BuyingPrice;
            this.PriceSelling = PriceSelling;
            this.AmountOfProduct = AmountOfProduct;
            this.ProductType = ProductType;
            Validation(ProductInfo, ProductType, BarNumber, MethodOfBuying, AmountOfProduct);
        }

        public RulesValidationAddingItem()
        {
        }

        public RulesValidationAddingItem(string bar_Number)
        {
            Validation(bar_Number);
        }

        public bool Validation(string bar_Number)
        {
            if (bar_Number.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ComboValidation(string comboBox)
        {
            if (comboBox == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Validation(string ProductInfo, string ProductType, string BarNumber, string MethodOfBuying, string AmountOfProduct)
        {
            if (ProductType.All(char.IsDigit) && BarNumber.All(char.IsDigit) && MethodOfBuying.All(char.IsDigit) && AmountOfProduct.All(char.IsDigit))
            {
                return true;
            }

            return false;

        }

        public bool MoneyValidation(string buingPrice, string sellingPrice)
        {
            double number3 = 0;

            var canConvert = double.TryParse(buingPrice, out number3);
            var canConvert2 = double.TryParse(sellingPrice, out number3);
            if (canConvert == true && canConvert2 == true)
                return true;
            else
                return false;


        }
        public bool ShowHouseBarNumberValidation(string barNumber)
        {

            if(string.IsNullOrEmpty(barNumber)==true)
            {
                return false;
            }
            else
            {
                return Validation(barNumber);
            }



        }
    }
}
