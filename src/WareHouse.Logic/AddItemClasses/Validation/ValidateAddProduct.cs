using ClassesLibrary.AddItemClasses.Validation;
using FluentValidation.Results;
using WareHouse.Data.SqlModels;

namespace WareHouse.Logic.AddItemClasses.Validation
{
    public class ValidateAddProduct
    {
        public ValidateAddProduct(Product product)
        {
            Product = product;

        }

        public Product Product { get; }
        public ValidationResult ReturnValidatingResult()
        {
            AddProductAndPurchaseValidate addProductValidate = new AddProductAndPurchaseValidate();
            return addProductValidate.Validate(Product);
        }

    }
}
