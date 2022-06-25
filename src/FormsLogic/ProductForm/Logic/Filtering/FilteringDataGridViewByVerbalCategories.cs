using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using FormsLogic.ProductForm.Logic.Data;
using FormsLogic.ProductForm.Logic.DistinctComparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Logic.Filtering
{
    public class FilteringDataGridViewByVerbalCategories
    {
        public string FilterInput { get; set; }
        public IProductService ProductService { get; set; }
        public IEnumerable<ProductDto> ProductsAfterFilteringByAllConditions { get; set; }
        public IEnumerable<ProductDto> ProductsAfterFilteringByProductDescription { get; set; }
        public IEnumerable<ProductDto> ProductsAfterFilteringByProductName { get; set; }
        public IEnumerable<ProductDto> ProductsAfterFilteringByProductType { get; set; }
        public FilteringDataGridViewByVerbalCategories(string filterInput, IProductService productService)
        {
            FilterInput = filterInput;
            ProductService = productService;
            ProductsAfterFilteringByAllConditions = new List<ProductDto>();
            ProductsAfterFilteringByProductDescription = new List<ProductDto>();
            ProductsAfterFilteringByProductName = new List<ProductDto>();
            ProductsAfterFilteringByProductType = new List<ProductDto>();
            FilteringProductsByAllCondition();
            MergeFilteringListToOneMainList();
        }

        private void MergeFilteringListToOneMainList()
        {
            var productsAfterMerge = ProductsAfterFilteringByAllConditions.Concat(ProductsAfterFilteringByProductType).Concat(ProductsAfterFilteringByProductDescription).Concat(ProductsAfterFilteringByProductName).ToList();
            ProductsAfterFilteringByAllConditions = productsAfterMerge.Distinct(new ProductDtoDistinctComparer());
        }

        public void FilteringProductsByAllCondition()
        {
            FilteringByProductDescription();
            FilteringByProductName();
            FilteringByProductType();
        }
        public void FilteringByProductDescription()
        {
            var filteringByProductDescription = new FilteringDataGridViewByProductDescription(FilterInput, ProductService);
            ProductsAfterFilteringByProductDescription = filteringByProductDescription.ReturnFilteringProductsByProductDescription();

        }
        public void FilteringByProductName()
        {
            var filteringByProductName = new FilteringDataGridViewByProductName(FilterInput, ProductService);
            ProductsAfterFilteringByProductName = filteringByProductName.ReturnFilteringProductsByProductName();
        }
        public void FilteringByProductType()
        {
            var filteringByProductType = new FilteringDataGridViewByProductType(FilterInput, ProductService);
            ProductsAfterFilteringByProductType = filteringByProductType.ReturnFilteringProductsByProductType();
        }
    }
}
