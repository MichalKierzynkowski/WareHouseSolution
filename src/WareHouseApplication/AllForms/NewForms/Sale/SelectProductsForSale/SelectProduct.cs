using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLayer.Dto.ProductDetailDtos;
using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using FormsLogic.ProductForm.Logic.Data;
using FormsLogic.ProductForm.Logic.FilteringOptionsManagement;

namespace WareHouseApplication.AllForms.NewForms.Sale
{
    public partial class SelectProduct : Form
    {
        public IProductService ProductService { get; set; }
        public IWareHouseService WareHouseService { get; set; }
        public GetProductDtoForSale GetProductDto { get; set; }

        public SelectProduct(IProductService productService, IWareHouseService wareHouseService)
        {
            InitializeComponent();
            this.TopMost = true;
            ProductService = productService;
            WareHouseService = wareHouseService;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        internal delegate void SetDataSourceDelegate(IEnumerable<ProductDto> products);
        private void SetDataSource(IEnumerable<ProductDto> products)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(SetDataSource), products);
            }
            else
            {
                dataGridView1.DataSource = null;
                foreach (var item in products)
                {
                    dataGridView1.Rows.Add(new object[] { item.RegistrationNumber, item.ProductDetailDto.Name, item.ProductDetailDto.Type, item.ProductDetailDto.ExtraDescription, item.AddedAt });
                }
                progressBar.Visible = false;
            }
        }

        private void SelectProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            CBoxSearchByCategory.SelectedIndex = 0;
        }

        public IEnumerable<ProductDto> ReturnDataFromDataBase()
        {
            var dataReturn = new ReturnDataFromDb(ProductService);
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
            var products = ReturnDataFromDataBase();
            SetDataSource(products);
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
            var products = ReturnDataFromDataBase();
            LoadProductsToDataGridView(products);
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            if (AmountUpDown.Value==0)
            {
                MessageBox.Show("Nie wybrano ilości!", "Błąd!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Pomyślnie wybrano produkt!", "Sukces!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AssignmentDataToGetProductDto(e.RowIndex);
        }

        private void AssignmentDataToGetProductDto( int digitOfSelectedRow)
        {
            if (digitOfSelectedRow >= 0)
            {
                GetProductDto = new GetProductDtoForSale();
                var selectedRow = dataGridView1.Rows[digitOfSelectedRow];
                GetProductDto.RegistrationNumber = (int) selectedRow.Cells[0].Value;
                GetProductDto.Name= selectedRow.Cells[1].Value.ToString();
                GetProductDto.Type=selectedRow.Cells[2].Value.ToString();
                GetProductDto.Amount = (int)AmountUpDown.Value;
                GetProductDto.SellPrice = GetSellPriceForProduct(GetProductDto.RegistrationNumber);
            }
        }

        private decimal GetSellPriceForProduct(int registrationNumber)
        {
            return WareHouseService.GetSellPriceForProduct(registrationNumber);
        }
    }
}