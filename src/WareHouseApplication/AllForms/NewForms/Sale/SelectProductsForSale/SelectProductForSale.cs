using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Dto.ReturnDtos;
using ApplicationLayer.Dto.WareHouse;
using ApplicationLayer.Interfaces;
using FormsLogic.ProductForm.Logic.Data.Return;
using FormsLogic.ProductForm.Logic.FilteringOptionsManagement;
using FormsLogic.Return.Logic.Data.Return;
using FormsLogic.Sale.Validation;
using FormsLogic.WareHouseForm.Logic.Data.Return;

namespace WareHouseApplication.AllForms.NewForms.Sale
{
    public partial class SelectProductForSale : Form
    {
        public IProductService ProductService { get; set; }
        public IWareHouseService WareHouseService { get; set; }
        public WareHouseDto WareHouseDto { get; set; }
        public ReturnDto ReturnDto { get; set; }
        public bool IsReturned {get; set; }
        public IReturnService ReturnService { get; set; }
        public int AmountOfProductSelectByUser { get; set; }
        public SelectProductForSale(IProductService productService, IWareHouseService wareHouseService, IReturnService returnService)
        {
            InitializeComponent();
            this.TopMost = true;
            ProductService = productService;
            WareHouseService = wareHouseService;
            ReturnService = returnService;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            WareHouseDto = null;
            ReturnDto = null;
        }
       
        internal delegate void SetDataSourceDelegate(IEnumerable<WareHouseDto> wareHouses,IEnumerable<ReturnDto> returns);
        private void SetDataSource(IEnumerable<WareHouseDto> wareHouses, IEnumerable<ReturnDto> returns)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(SetDataSource), wareHouses,returns);
            }
            else
            {
                dataGridView1.DataSource = null;
                foreach (var item in wareHouses)
                {
                    var product = item.Products.FirstOrDefault();
                    dataGridView1.Rows.Add(new object[] { product.RegistrationNumber, product.ProductDetail.Name,product.ProductDetail.Type, product.ProductDetail.ExtraDescription,item.Quantity,item.IsReturned});
                }

                foreach (var item in returns)
                {
                    var product = item.Products.FirstOrDefault();
                    dataGridView1.Rows.Add(new object[] { product.RegistrationNumber, product.ProductDetail.Name, product.ProductDetail.Type, product.ProductDetail.ExtraDescription, item.Quantity, item.IsReturned });
                }
                progressBar.Visible = false;
            }
        }
        private void SelectProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            CBoxSearchByCategory.SelectedIndex = 0;
        }

        public IEnumerable<ProductDto> ReturnProductsFromWareHouse()
        {
            var dataReturn = new ReturnProductsFromDB(ProductService);
            return dataReturn.Products;

        }
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            System.Threading.Thread thread =
                new System.Threading.Thread(new System.Threading.ThreadStart(LoadTable));
            thread.Start();
            btnPick.Enabled = true;
        }

        private void LoadTable()
        {
            var wareHouses = new ReturnProductsFromWareHouseOnStock(WareHouseService).WareHouses;
            var returns = new ReturnProductFromReturnOnStock(ReturnService).Returns;
            SetDataSource(wareHouses,returns);
            dataGridView1.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var filteringOption = new FilteringOptionsManagement(CBoxSearchByCategory.SelectedItem.ToString(), TxtSearch.Text, ProductService);
            if ((filteringOption.ErrorMessages != null) && (filteringOption.ErrorMessages.Any()))
            {
                MessageBox.Show(string.Join("\n", filteringOption.ErrorMessages), "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoadProductsToDataGridView(filteringOption.ProductsAfterFiltering);
            }
        }
        private void LoadProductsToDataGridView(IEnumerable<ProductDto> products)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            foreach (var item in products)
            {
                dataGridView1.Rows.Add(new object[] { item.RegistrationNumber, item.ProductDetailDto.Name, item.ProductDetailDto.Type, item.ProductDetailDto.ExtraDescription, item.AddedAt });
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            TxtSearch.Clear();
            CBoxSearchByCategory.SelectedIndex = 0;
            ResetValuesInDataGridAndFillWithValuesAgain();
        }
        private void ResetValuesInDataGridAndFillWithValuesAgain()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            var products = ReturnProductsFromWareHouse();
            LoadProductsToDataGridView(products);
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            if (AmountUpDown.Value == 0)
            {
                MessageBox.Show("Nie wybrano ilości!", "Błąd!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (IsReturned)
                {
                    var returnItemValidation = new ReturnItemValidation((int)AmountUpDown.Value);
                    var result = returnItemValidation.Validate(ReturnDto);
                    if (!result.IsValid)
                    {
                        MessageBox.Show(string.Join("\n", result.Errors), "Błąd",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        AmountOfProductSelectByUser = (int)AmountUpDown.Value;
                        SuccessAddedInfo();
                    }
                }
                else
                {
                    var wareHouseValidation = new WareHouseItemValidation((int)AmountUpDown.Value);
                    var result = wareHouseValidation.Validate(WareHouseDto);
                    if (!result.IsValid)
                    {
                        MessageBox.Show(string.Join("\n", result.Errors), "Błąd",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        AmountOfProductSelectByUser = (int)AmountUpDown.Value;
                        SuccessAddedInfo();
                    }
                }
            }
        }

        private void SuccessAddedInfo()
        {
            MessageBox.Show("Pomyślnie wybrano produkt!", "Sukces!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AssignmentDataToWareHouseDto(e.RowIndex);
        }

        private void AssignmentDataToWareHouseDto(int digitOfSelectedRow)
        {
            if (digitOfSelectedRow >= 0)
            {
               var selectedRow = dataGridView1.Rows[digitOfSelectedRow];
               var registrationNumber = (int)selectedRow.Cells[0].Value;
               var isReturned = selectedRow.Cells[5].Value.ToString();
               if (isReturned=="Tak")
               {
                   IsReturned = true;
                   ReturnDto = FindReturnDtoBaseOnRegistrationNumber(registrationNumber);
               }
               else
               {
                   IsReturned = false;
                   WareHouseDto = FindWareHouseDtoBaseOnRegistrationNumber(registrationNumber);
               }
            }
        }
        private WareHouseDto FindWareHouseDtoBaseOnRegistrationNumber(int registrationNumber)
        {
            var findCorrectWareHouse = new ReturnSpecificWareHouseBaseOnRegistrationNumber(WareHouseService,registrationNumber);
            return findCorrectWareHouse.WareHouse;
        }

        private ReturnDto FindReturnDtoBaseOnRegistrationNumber(int registrationNumber)
        {
            var findCorrectReturn = new ReturnSpecificReturnBaseOnRegistrationNumber(ReturnService,registrationNumber);
            return findCorrectReturn.Return;
        }
    }
} 