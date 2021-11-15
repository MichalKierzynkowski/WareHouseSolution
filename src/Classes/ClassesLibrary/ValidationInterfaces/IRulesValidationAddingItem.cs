namespace ClassesLibrary.ValidationInterfaces
{
    public interface IRulesValidationAddingItem
    {
        bool Validation(string ProductInfo, string ProductType, string BarNumber, string MethodOfBuying, string AmountOfProduct);
    }
}
