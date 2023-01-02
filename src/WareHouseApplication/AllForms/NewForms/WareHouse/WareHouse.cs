
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Dto.ReturnDtos;
using ApplicationLayer.Dto.WareHouse;
using ApplicationLayer.Interfaces;
using Domain.Interfaces;
using FormsLogic.Return.Logic.Data;
using FormsLogic.Return.Validation;
using FormsLogic.WareHouse.Logic.Data;
using FormsLogic.WareHouse.Validation;

namespace WareHouseApplication.AllForms.NewForms.WareHouse
{
    public partial class WareHouse : Form
    {
        private readonly IReturnService _returnService;
        public IProductService ProductService { get; set; }
        public ProductDto ProductDto { get; set; }
        public CreateWareHouseDto CreateWareHouseDto { get; set; }
        public IWareHouseService WareHouseService { get; set; }
        public IProductRepository ProductRepository { get; set; }
        public CreateReturnDto CreateReturnDto { get; set; }

        public WareHouse(IProductService productService, IWareHouseService wareHouseService,
            IProductRepository productRepository,IReturnService returnService)
        {
            _returnService = returnService;
            InitializeComponent();
            ProductService = productService;
            WareHouseService = wareHouseService;
            ProductRepository = productRepository;
            CreateWareHouseDto = new CreateWareHouseDto();
            CreateReturnDto= new CreateReturnDto();
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
                ProductDto = null;
                selectProduct.ShowDialog();
                if (selectProduct.ProductDto != null)
                {
                    ProductDto = selectProduct.ProductDto;
                    AssigneDataToInputs();
                }
            }

        }

        private void AssigneDataToInputs()
        {
            txtRegistrationNumber.Text = ProductDto.RegistrationNumber.ToString();
            txtProductType.Text = ProductDto.ProductDetailDto.Type;
            txtName.Text = ProductDto.ProductDetailDto.Name.ToString();
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
            CreateReturnValidation returnValidation = new CreateReturnValidation();
            var result = returnValidation.Validate(CreateReturnDto);
            if (!result.IsValid)
            {
                MessageBox.Show(string.Join("\n", result.Errors), "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddNewReturnToDataBase newReturn =
                    new AddNewReturnToDataBase(CreateReturnDto, _returnService, ProductRepository);
                MessageBox.Show("Operacja przebiegła pomyślnie!", "Sukces!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Timer.Start();
                TLPnlTop.Enabled = true;

            }
        }

        private void AssignedValuesFromInputsToCreateReturn()
        {
            CreateReturnDto.ProductRegistrationNumber = Convert.ToInt32(txtRegistrationNumber.Text);
            CreateReturnDto.Date = DateTime.Now;
            CreateReturnDto.PurchasePrice = buyPriceNumeric.Value;
            CreateReturnDto.SellPrice = sellPriceNumeric.Value;
            CreateReturnDto.Quantity = Convert.ToInt32(quantityNumeric.Value);
            CreateReturnDto.IsReturned= true;
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
            CreateWareHouseDto.IsReturned ="Nie";
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
            var returns = ReturnDataFromReturns();
            SetDataSource(wareHouses,returns);
            dataGridView1.ClearSelection();
        }

        private IEnumerable<ReturnDto> ReturnDataFromReturns()
        {
            var dataReturn = new ReturnReturnItemFromDB(_returnService, ProductRepository);

            return dataReturn.Returns;
        }

        internal delegate void SetDataSourceDelegate(IEnumerable<WareHouseDto> wareHouses, IEnumerable<ReturnDto> returns);
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
                    var productDetail = item.Products.Select(x => x.ProductDetail);
                    foreach (var product in productDetail)
                    {
                        dataGridView1.Rows.Add(new object[]
                        {
                            product.Name,
                            product.Product.RegistrationNumber,
                            product.Type, item.Quantity,
                            item.Unit, item.PurchasePrice, item.SellPrice, item.IsReturned
                        });
                    }
                }
                foreach (var item in returns)
                {
                    var productDetail = item.Products.Select(x => x.ProductDetail);
                    foreach (var product in productDetail)
                    {
                        dataGridView1.Rows.Add(new object[]
                        {
                            product.Name,
                            product.Product.RegistrationNumber,
                            product.Type, item.Quantity,
                            item.Unit, item.PurchasePrice, item.SellPrice,
                            item.IsReturned
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