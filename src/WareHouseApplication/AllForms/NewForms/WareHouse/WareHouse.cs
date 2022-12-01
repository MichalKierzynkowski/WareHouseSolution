
using System;
using System.Windows.Forms;
using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;

namespace WareHouseApplication.AllForms.NewForms.WareHouse
{
    public partial class WareHouse : Form
    {
        public IProductService ProductService { get; set; }
        public GetProductDto GetProductDto { get; set; }
        public WareHouse(IProductService productService)
        {
            InitializeComponent();
            ProductService=productService;
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
            txtRegistrationNumber.Text = GetProductDto.Name;
            txtProductType.Text = GetProductDto.Type;
            txtName.Text = GetProductDto.RegistrationNumber.ToString();
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
            DialogResult dialogResult = MessageBox.Show("Czy jesteś pewny?", "Informacja", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (lblRightPanelMainName.Text == "Dodaj produkt")
                {
                    AddNewDeliveryPreValidation();
                }
                else if (lblRightPanelMainName.Text == "Edytuj Produkt")
                {
                    
                }
                else if (lblRightPanelMainName.Text == "Usuń Produkt")
                {
                    
                }
            }
        }

        private void AddNewDeliveryPreValidation()
        {
            
        }
    }
}