
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Dto.WareHouse;
using ApplicationLayer.Interfaces;
using Domain.Interfaces;
using FormsLogic.ProductForm.Logic.Data;
using FormsLogic.WareHouse.Logic.Data;
using FormsLogic.WareHouse.Validation;
using System.Data.Entity;

namespace WareHouseApplication.AllForms.NewForms.WareHouse
{
    public partial class WareHouse : Form
    {
        public IProductService ProductService { get; set; }
        public GetProductDto GetProductDto { get; set; }
        public CreateWareHouseDto CreateWareHouseDto { get; set; }
        public IWareHouseService WareHouseService { get; set; }
        public IProductRepository ProductRepository { get; set; }

        public WareHouse(IProductService productService, IWareHouseService wareHouseService,
            IProductRepository productRepository)
        {
            InitializeComponent();
            ProductService = productService;
            WareHouseService = wareHouseService;
            ProductRepository = productRepository;
            CreateWareHouseDto = new CreateWareHouseDto();
            SetOffDeleteAndEditButtons();
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

        private void btnSelectProduct_Click(object sender, System.EventArgs e)
        {
            using (SelectProduct selectProduct = new SelectProduct(ProductService))
            {
                GetProductDto = null;
                selectProduct.ShowDialog();
                if (selectProduct.GetProductDto != null)
                {
                    GetProductDto = selectProduct.GetProductDto;
                    AssigneDataToInputs();
                }
            }

        }

        private void AssigneDataToInputs()
        {
            txtRegistrationNumber.Text = GetProductDto.RegistrationNumber.ToString();
            txtProductType.Text = GetProductDto.Type;
            txtName.Text = GetProductDto.Name.ToString();
        }


        private void SetTimer()
        {
            Timer.Start();
        }

        private void btnAddProduct_Click(object sender, System.EventArgs e)
        {
            SetTimer();
            RightPanelAddProductAdjustment();
        }

        private void RightPanelAddProductAdjustment()
        {
            TLPnlTop.Enabled = false;
            lblRightPanelMainName.Text = "Dodaj dostawe";
            btnResetValues.Enabled = true;

        }

        private void Timer_Tick(object sender, EventArgs e)
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

        private void WareHouse_Load(object sender, EventArgs e)
        {
            PnlAdd.Width = 0;
            CBoxSearchByCategory.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Timer.Start();
            TLPnlTop.Enabled = true;
            ClearInputsInAddNewDelivery();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetOnDeleteAndEditButtons();
        }

        private void ClearInputsInAddNewDelivery()
        {
            txtRegistrationNumber.Clear();
            txtName.Clear();
            txtProductType.Clear();
            quantityNumeric.Value = 0;
            buyPriceNumeric.Value = 0;
            sellPriceNumeric.Value = 0;
        }

        private void btnResetValues_Click(object sender, EventArgs e)
        {
            ClearInputsInAddNewDelivery();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (isReturnedBox.Checked)
            {
                AddWareHousWithReturnedItem();
            }
            else
            {
                AddWareHouseWithoutReturnedItem();
            }
            
        }

        private void AddWareHouseWithoutReturnedItem()
        {
            DialogResult dialogResult = MessageBox.Show("Czy jesteś pewny?", "Informacja", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (lblRightPanelMainName.Text == "Dodaj dostawe")
                {
                    AddNewDeliveryPreValidation();
                }
                else if (lblRightPanelMainName.Text == "Edytuj dostawe")
                {
                    EditNewDeliveryPreValidation();
                }
                else if (lblRightPanelMainName.Text == "Usuń dostawe")
                {
                    DeleteNewDeliveryPreValidation();
                }
            }
        }

        private void AddWareHousWithReturnedItem()
        {
            DialogResult dialogResult = MessageBox.Show("Czy jesteś pewny?", "Informacja", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (lblRightPanelMainName.Text == "Dodaj dostawe")
                {
                    AddNewDeliveryWithReturnedItemPreValidation();
                }
            }
        }

       

        private void DeleteNewDeliveryPreValidation()
        {
            throw new NotImplementedException();
        }

        private void EditNewDeliveryPreValidation()
        {
            throw new NotImplementedException();
        }
        private void AddNewDeliveryWithReturnedItemPreValidation()
        {
            AssignedValuesFromInputsToCreateReturn();
            CreateWareHouseDtoValidation wareHouseValidation = new CreateWareHouseDtoValidation();
            var result = wareHouseValidation.Validate(CreateWareHouseDto);
            if (!result.IsValid)
            {
                MessageBox.Show(string.Join("\n", result.Errors), "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddNewWareHouseToDataBase newWareHouse =
                    new AddNewWareHouseToDataBase(CreateWareHouseDto, WareHouseService, ProductRepository);
                MessageBox.Show("Operacja przebiegła pomyślnie!", "Sukces!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Timer.Start();
                TLPnlTop.Enabled = true;

            }
        }

        private void AssignedValuesFromInputsToCreateReturn()
        {
            //zmiana
            CreateWareHouseDto.ProductRegistrationNumber = Convert.ToInt32(txtRegistrationNumber.Text);
            CreateWareHouseDto.Date = DateTime.Now;
            CreateWareHouseDto.PurchasePrice = buyPriceNumeric.Value;
            CreateWareHouseDto.SellPrice = sellPriceNumeric.Value;
            CreateWareHouseDto.Quantity = Convert.ToInt32(quantityNumeric.Value);
        }

        private void AddNewDeliveryPreValidation()
        {
            AssignedValuesFromInputsToCreateWareHouse();
            CreateWareHouseDtoValidation wareHouseValidation = new CreateWareHouseDtoValidation();
            var result = wareHouseValidation.Validate(CreateWareHouseDto);
            if (!result.IsValid)
            {
                MessageBox.Show(string.Join("\n", result.Errors), "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddNewWareHouseToDataBase newWareHouse =
                    new AddNewWareHouseToDataBase(CreateWareHouseDto, WareHouseService, ProductRepository);
                MessageBox.Show("Operacja przebiegła pomyślnie!", "Sukces!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Timer.Start();
                TLPnlTop.Enabled = true;

            }
        }

        private void AssignedValuesFromInputsToCreateWareHouse()
        {
            CreateWareHouseDto.ProductRegistrationNumber = Convert.ToInt32(txtRegistrationNumber.Text);
            CreateWareHouseDto.Date = DateTime.Now;
            CreateWareHouseDto.PurchasePrice = buyPriceNumeric.Value;
            CreateWareHouseDto.SellPrice = sellPriceNumeric.Value;
            CreateWareHouseDto.Quantity = Convert.ToInt32(quantityNumeric.Value);
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
            var wareHouses = ReturnDataFromWareHouse();
            SetDataSource(wareHouses);
            dataGridView1.ClearSelection();
        }
        internal delegate void SetDataSourceDelegate(IEnumerable<WareHouseDto> wareHouses);
        private void SetDataSource(IEnumerable<WareHouseDto> wareHouses)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(SetDataSource), wareHouses);
            }
            else
            {
                dataGridView1.DataSource = null;
                foreach (var item in wareHouses)
                {
                    var productDetail = item.Products.Select(x => x.ProductDetail);
                    foreach (var product in productDetail)
                    {
                        dataGridView1.Rows.Add(new object[]
                        {
                            product.Name,
                            product.Product.RegistrationNumber,
                            product.Type, item.Quantity,
                            item.Unit, item.PurchasePrice, item.SellPrice, item.Date
                        });
                    }
                }
                progressBar.Visible = false;
            }
        }

        private IEnumerable<WareHouseDto> ReturnDataFromWareHouse()
        {
            var dataReturn = new ReturnWareHousesFromDB(WareHouseService,ProductRepository);
            
            return dataReturn.WareHouses;
        }

    }
}