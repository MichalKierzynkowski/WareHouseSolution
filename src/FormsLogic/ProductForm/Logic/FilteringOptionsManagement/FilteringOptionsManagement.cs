using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using FormsLogic.ProductForm.Logic.Entities;
using FormsLogic.ProductForm.Logic.Filtering;
using FormsLogic.ProductForm.Validation.FilteringValidations;

namespace FormsLogic.ProductForm.Logic.FilteringOptionsManagement
{
    public class FilteringOptionsManagement
    {
        public string FilterOption { get; set; }
        public string Input { get; set; }
        public List<FluentValidation.Results.ValidationFailure> ErrorMessages { get; set; }
        public IEnumerable<ProductDto> ProductsAfterFiltering { get; set; }
        public IProductService ProductService { get; set; }

        public FilteringOptionsManagement(string filterOption, string input, IProductService productService)
        {
            ProductService = productService;
            FilterOption = filterOption;
            Input = input;
            ValidateInput();
        }
        private void ValidateInput()
        {
            ResetFlags();
            if (FilterOption == "Numer Ewidencyjny")
            {
                var filterOption = new FilteringOption(Input);
                InputBarNumberValidation barNumberValidation = new InputBarNumberValidation();
                var result = barNumberValidation.Validate(filterOption);
                if (!result.IsValid)
                {
                    ErrorMessages = result.Errors;
                }
                else
                {
                    var filterByRegistrationNumber = new FilteringDataGridViewByRegistrationNumber(Convert.ToInt32(filterOption.Input), ProductService);
                    ProductsAfterFiltering = filterByRegistrationNumber.ReturnFilteringProductsByRegistrationNumber();
                }

            }
            else if (FilterOption == "Wszystko")
            {
                var filterOption = new FilteringOption(Input);
                InputFilterByAllValidation filterByAllValidation = new InputFilterByAllValidation();
                var result = filterByAllValidation.Validate(filterOption);
                if (!result.IsValid)
                {
                    ErrorMessages = result.Errors;
                }
                else
                {
                    if (Input.All(char.IsDigit))
                    {
                        var filterByRegistrationNumber = new FilteringDataGridViewByRegistrationNumber(Convert.ToInt32(filterOption.Input), ProductService);
                        ProductsAfterFiltering = filterByRegistrationNumber.ReturnFilteringProductsByRegistrationNumber();
                    }
                    else
                    {
                        var filterAllCategoriesByString = new FilteringDataGridViewByVerbalCategories(filterOption.Input, ProductService);
                        ProductsAfterFiltering = filterAllCategoriesByString.ProductsAfterFilteringByAllConditions;
                    }
                }


            }
            else if (FilterOption == "Nazwa")
            {
                var filterOption = new FilteringOption(Input);
                InputProductNameValidation productNameValidation = new InputProductNameValidation();
                var result = productNameValidation.Validate(filterOption);
                if (!result.IsValid)
                {
                    ErrorMessages = result.Errors;
                }
                else
                {
                    var filterByProductName = new FilteringDataGridViewByProductName(filterOption.Input, ProductService);
                    ProductsAfterFiltering = filterByProductName.ReturnFilteringProductsByProductName();
                }

            }
            else if (FilterOption == "Rodzaj")
            {
                var filterOption = new FilteringOption(Input);
                InputProductTypeValidation productTypeValidation = new InputProductTypeValidation();
                var result = productTypeValidation.Validate(filterOption);
                if (!result.IsValid)
                {
                    ErrorMessages = result.Errors;
                }
                else
                {
                    var filterByProductType = new FilteringDataGridViewByProductType(filterOption.Input, ProductService);
                    ProductsAfterFiltering = filterByProductType.ReturnFilteringProductsByProductType();
                }
            }
            else if (FilterOption == "Opis")
            {
                var filterOption = new FilteringOption(Input);
                InputProductDescriptionValidation productDescriptionValidation = new InputProductDescriptionValidation();
                var result = productDescriptionValidation.Validate(filterOption);
                if (!result.IsValid)
                {
                    ErrorMessages = result.Errors;
                }
                else
                {
                    var filterByProductDescription = new FilteringDataGridViewByProductDescription(filterOption.Input, ProductService);
                    ProductsAfterFiltering = filterByProductDescription.ReturnFilteringProductsByProductDescription();
                }
            }
        }

        private void ResetFlags()
        {
            ErrorMessages = null;
            ProductsAfterFiltering = Enumerable.Empty<ProductDto>();

        }
    }
}
