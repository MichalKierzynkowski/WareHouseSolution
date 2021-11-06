using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.ValidationInterfaces
{
    public interface IRulesValidationAddingItem
    {
        bool Validation(string ProductInfo, string ProductType, string BarNumber, string MethodOfBuying,  string PriceSelling, string AmountOfProduct);
    }
}
