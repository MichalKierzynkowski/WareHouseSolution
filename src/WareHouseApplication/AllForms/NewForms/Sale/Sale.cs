using System;
using System.Drawing;
using System.Linq;
using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using ApplicationLayer.Services;
using System.Windows.Forms;
using ApplicationLayer.Dto.ReturnDtos;
using ApplicationLayer.Dto.WareHouse;

namespace WareHouseApplication.AllForms.NewForms.Sale
{
    public partial class Sale : Form
    {
        public  IWareHouseService WareHouseService;
        public  IReturnService ReturnService;
        public IProductService ProductService { get; set; }
        public WareHouseDto WareHouse { get; set; }
        public ReturnDto Return { get; set; }
        public Sale(IProductService productService,IWareHouseService wareHouseService,IReturnService returnService)
        {
            WareHouseService = wareHouseService;
            ReturnService = returnService;
            InitializeComponent();
            SetOffDeleteAndEditButtons();
            ProductService = productService;
        }

        private void SetOffDeleteAndEditButtons()
        {
            btnDelete.Enabled = false;
            btnEditProduct.Enabled = false;
        }
        private void SetOnDeleteAndEditButtons()
        {
            btnDelete.Enabled = true;
            btnEditProduct.Enabled = true;
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            if (PnlAdd.Width == 395)
            {
                for (int i = 0; i < 5; i++)
                    PnlAdd.Width = PnlAdd.Width - 79;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    PnlAdd.Width = PnlAdd.Width + 79;
            }

            Timer.Stop();
        }

        private void SetTimer()
        {
            Timer.Start();
        }

        private void btnAddProduct_Click(object sender, System.EventArgs e)
        {
            SetTimer();
        }

        private void Sale_Load(object sender, System.EventArgs e)
        {
            PnlAdd.Width = 0;
            CBoxSearchByCategory.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Timer.Start();
            TLPnlTop.Enabled = true;
        }

        private void btnSelectProduct_Click(object sender, System.EventArgs e)
        {
            using (SelectProductForSale selectProduct = new SelectProductForSale(ProductService,WareHouseService,ReturnService))
            {
                selectProduct.ShowDialog();
                if (selectProduct.IsReturned && selectProduct.ReturnDto!=null)
                {
                    Return=selectProduct.ReturnDto;
                    AddReturnItemToDataGridView(Return,selectProduct.AmountOfProductSelectByUser);
                }
                else if (!selectProduct.IsReturned && selectProduct.WareHouseDto != null)
                {
                    WareHouse = selectProduct.WareHouseDto;
                    AddWareHouseItemToDataGridView(WareHouse,selectProduct.AmountOfProductSelectByUser);
                }
            }
        }
        private void AddWareHouseItemToDataGridView(WareHouseDto wareHouse,int amountOfProductSelectByUser)
        {
            
            dataGridView2.Rows.Add(new object[] {wareHouse.Products.First().RegistrationNumber,wareHouse.Products.First().ProductDetail.Name,amountOfProductSelectByUser,wareHouse.SellPrice*amountOfProductSelectByUser,wareHouse.IsReturned,"X"});
            var currentPrice = ReturnEndPrice(Convert.ToDecimal(EndPriceTBox.Text),
                wareHouse.SellPrice * amountOfProductSelectByUser);
            EndPriceTBox.Text = currentPrice.ToString();
        }

        private void AddReturnItemToDataGridView(ReturnDto returnDto,int amountOfProductSelectByUser)
        {
            dataGridView2.Rows.Add(new object[] {returnDto.Products.First().RegistrationNumber, returnDto.Products.First().ProductDetail.Name, amountOfProductSelectByUser, returnDto.SellPrice*amountOfProductSelectByUser, returnDto.IsReturned,"X" });
            var currentPrice = ReturnEndPrice(Convert.ToDecimal(EndPriceTBox.Text),
                returnDto.SellPrice * amountOfProductSelectByUser);
            EndPriceTBox.Text = currentPrice.ToString();
        }

        public decimal ReturnEndPrice(decimal actualPrice,decimal userPrice)
        {
            return actualPrice + userPrice;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Usuń")
            {
                if (MessageBox.Show("Jesteś pewny, że chcesz usunać ten rekord?", "Ostrzeżenie",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var row = dataGridView2.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView2.Rows[row];
                    UpdateEndPrice(Convert.ToDecimal(selectedRow.Cells[3].Value));
                    dataGridView2.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void UpdateEndPrice(decimal valueToDelete)
        {
            EndPriceTBox.Text = (Convert.ToDecimal(EndPriceTBox.Text) - valueToDelete).ToString();
        }

        private void btnResetValues_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            paymentMethodCBox.SelectedIndex = -1;
            DiscountNumeric.Value = 0;
            DiscountPicker.SelectedIndex = -1;
            EndPriceTBox.Text = "0";
        }
    }
}