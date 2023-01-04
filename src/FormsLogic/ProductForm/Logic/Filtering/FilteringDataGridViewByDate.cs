using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using FormsLogic.ProductForm.DatePickPopUp.Entities;
using FormsLogic.ProductForm.Logic.Data;
using FormsLogic.ProductForm.Logic.Data.Return;

namespace FormsLogic.ProductForm.Logic.Filtering
{
    public class FilteringDataGridViewByDate
    {
        #region Properties
        public SelectedDate SelectedDate { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
        public IEnumerable<ProductDto> ProductsAfterFiltering { get; set; }
        #endregion

        #region Constructor
        public FilteringDataGridViewByDate(SelectedDate selectedDate, IProductService productService)
        {
            SelectedDate = selectedDate;
            var getProducts = new ReturnProductsFromDB(productService);
            Products = getProducts.Products;
            FiteringProductsByDate();
        }
        #endregion

        #region Filtering
        private void FiteringProductsByDate()
        {
            ProductsAfterFiltering = Products.Where(x => x.AddedAt >= SelectedDate.DateFrom && x.AddedAt <= SelectedDate.DateTo).ToList();
        }
        #endregion

    }
}