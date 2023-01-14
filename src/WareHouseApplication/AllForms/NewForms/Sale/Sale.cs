using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using ApplicationLayer.Services;
using System.Windows.Forms;
using ApplicationLayer.Dto.ReturnDtos;
using ApplicationLayer.Dto.Sale;
using ApplicationLayer.Dto.WareHouse;
using Domain.Entities;
using Domain.Interfaces;
using WareHouseApplication.AllForms.NewForms.Product.SaveProducts;

namespace WareHouseApplication.AllForms.NewForms.Sale
{
    public partial class Sale : Form
    {
        public  IWareHouseService WareHouseService;
        public  IReturnService ReturnService;
        public IProductService ProductService { get; set; }
        public ISaleService SaleService { get; set; }
        public IReturnRepository ReturnRepository { get; set; }
        public IWareHouseRepository WareHouseRepository { get; set; }
        public WareHouseDto WareHouse { get; set; }
        public ReturnDto Return { get; set; }
        public CreateSaleDto SaleDto { get; set; }

        public Sale(IProductService productService,IWareHouseService wareHouseService,IReturnService returnService,ISaleService saleService,IReturnRepository returnRepository,IWareHouseRepository wareHouseRepository)
        {
            WareHouseService = wareHouseService;
            ReturnService = returnService;
            InitializeComponent();
            SetOffDeleteAndEditButtons();
            WareHouseRepository = wareHouseRepository;
            ProductService = productService;
            ReturnRepository = returnRepository;
            SaleService = saleService;
            SaleDto = new CreateSaleDto();
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
            using (var selectProduct = new SelectProductForSale(ProductService,WareHouseService,ReturnService))
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
                    System.Windows.Forms.DataGridViewRow selectedRow = dataGridView2.Rows[row];
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
            EndPriceTBox.Text = "0";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy jesteś pewny?", "Informacja", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AddNewSalePreValidation();
            }
        }

        private void AddNewSalePreValidation()
        {
            AssignedValuesFromInputsToCreateSale();
        }

        private void AssignedValuesFromInputsToCreateSale()
        {
            if (dataGridView2.Rows.Count > 0)
            {
                SaleDto.Returns = new List<Return>();
                SaleDto.WareHouses = new List<Domain.Entities.WareHouse>();
                foreach (System.Windows.Forms.DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[4].Value == "Tak")
                    {
                        var returnItem = FindReturnById(Convert.ToInt32(row.Cells[0].Value));
                        returnItem.Quantity = Convert.ToInt32(row.Cells[2]);
                        SaleDto.Returns.Add(returnItem);
                    }
                    else
                    {
                        var wareHouseItem = FindWareHouseById(Convert.ToInt32(row.Cells[0].Value));
                        ChangeTheAmountOfQuantityForWareHouseItem(wareHouseItem.Quantity, wareHouseItem);
                        wareHouseItem.Quantity = Convert.ToInt32(row.Cells[2].Value);
                        SaleDto.WareHouses.Add(wareHouseItem);
                    }
                }

                if (string.IsNullOrWhiteSpace(paymentMethodCBox.Text))
                {
                    MessageBox.Show("Metoda platnosci jest pusta!", "Błąd",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SaleDto.PaymentMethod = paymentMethodCBox.Text;
                    SaleDto.Discount = DiscountNumeric.Value;
                    SaleDto.EndPrice = Convert.ToDecimal(EndPriceTBox.Text);
                    SaleDto.Profit = CalculateProfit(SaleDto.Discount);
                    SaleDto.Margin = CalculateMargin(SaleDto.Discount);
                    SaleDto.Date= DateTime.Now;
                    SaleService.AddNewSale(SaleDto);
                    MessageBox.Show("Operacja przebiegła pomyślnie!", "Sukces!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Timer.Start();
                    TLPnlTop.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Tabela produktów jest pusta!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeTheAmountOfQuantityForWareHouseItem(int quantity,Domain.Entities.WareHouse wareHouse)
        {
           WareHouseRepository.UpdateQuantity(quantity,wareHouse);
        }


        private double CalculateMargin(decimal discount)
        {
            decimal purchasePrice = 0;
            decimal sellPrice = 0;
            foreach (var item in SaleDto.Returns)
            {
                purchasePrice = purchasePrice + item.PurchasePrice*item.Quantity;
                sellPrice = sellPrice + item.SellPrice*item.Quantity;
            }

            foreach (var item in SaleDto.WareHouses)
            {
                purchasePrice = purchasePrice + item.PurchasePrice * item.Quantity;
                sellPrice = sellPrice + item.SellPrice * item.Quantity;
            }

            var valueToReturn = Math.Round(Convert.ToDouble(((sellPrice - purchasePrice)-discount) / sellPrice) * 100, 2);
            return valueToReturn;
        }

        private decimal CalculateProfit(decimal discount)
        {
            decimal purchasePrice=0;
            decimal sellPrice = 0;
            foreach (var item in SaleDto.Returns)
            {
                purchasePrice = purchasePrice + item.PurchasePrice * item.Quantity;
                sellPrice = sellPrice + item.SellPrice * item.Quantity;
            }

            foreach (var item in SaleDto.WareHouses)
            {
                purchasePrice = purchasePrice + item.PurchasePrice * item.Quantity;
                sellPrice = sellPrice + item.SellPrice * item.Quantity;
            }

            return (sellPrice - purchasePrice)-discount;

        }

        private Return FindReturnById(int id)
        {
            return ReturnRepository.GetByProductId(id);
        }

        private Domain.Entities.WareHouse FindWareHouseById(int id)
        {
            return WareHouseRepository.GetByProductId(id);
        }

        private void DiscountNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (EndPriceTBox.Text == "0")
            {
                MessageBox.Show("Dodaj produkty, aby uwzglednic rabat!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DiscountNumeric.Value = 0;
            }
            else
            {
                EndPriceTBox.Text = (Convert.ToDecimal(EndPriceTBox.Text) - DiscountNumeric.Value).ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            System.Threading.Thread thread =
                new System.Threading.Thread(new System.Threading.ThreadStart(LoadTable));
            thread.Start();
        }

        private void LoadTable()
        {
            var sales = SaleService.GetAllSales();
            SetDataSource(sales);
            dataGridView1.ClearSelection();

        }

        internal delegate void SetDataSourceDelegate(IEnumerable<SaleDto> sales);
        private void SetDataSource(IEnumerable<SaleDto> sales)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(SetDataSource), sales);
            }
            else
            {
                dataGridView1.DataSource = null;
                foreach (var item in sales)
                {
                    dataGridView1.Rows.Add(new object[]
                        {
                           item.Id,item.PaymentMethod,item.EndPrice,item.Discount,item.Margin,item.Profit,item.Date,"INFO"
                        });
                    
                }
                progressBar.Visible = false;
            }
        }

        private void btnSaveProducts_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Brak produktów do zapisu!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SavingProducts savingProducts = new SavingProducts(dataGridView1);
                savingProducts.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Information")
            {
                 var row = dataGridView1.SelectedCells[0].RowIndex;
                 System.Windows.Forms.DataGridViewRow selectedRow = dataGridView1.Rows[row];
                 var idOfSale = Convert.ToInt32(selectedRow.Cells[0].Value);
                using var showInformation = new SaleInformations(SaleService, idOfSale);
                showInformation.ShowDialog();
            }
        }
    }
}