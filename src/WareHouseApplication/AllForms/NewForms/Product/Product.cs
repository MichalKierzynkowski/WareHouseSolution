using ApplicationLayer.Dto.ProductDetailDtos;
using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using FluentValidation;
using FormsLogic.ProductForm.Logic.Data;
using FormsLogic.ProductForm.Logic.Edit;
using FormsLogic.ProductForm.Validation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WareHouseApplication.NewForms
{
    public partial class Product : Form
    {
        public ReturnDataFromDb dataReturn { get; set; }
        public IProductService ProductService { get; set; }
        public UpdateProductDto UpdateProductDto { get; set; }
        public UpdateProductDetailDto EditProductDetailDto { get; set; }
        public bool IsExtraDescriptionOpen { get; set; }

        public Product(IProductService productService)
        {
            InitializeComponent();
            SetDateTimePicker();
            HidingArrowsInNumerics();
            ProductService = productService;
            EditProductDetailDto = new UpdateProductDetailDto();
            UpdateProductDto = new UpdateProductDto(EditProductDetailDto);
        }

        #region AdjustmentWinFormsControls

        private void SelectTxt(TextBox txt)
        {
            txt.BackColor = Color.FromArgb(139, 199, 255);
        }

        private void SelectBarNumber(NumericUpDown numeric)
        {
            numeric.BackColor = Color.FromArgb(139, 199, 255);
        }

        private void LeaveNumeric(NumericUpDown numeric)
        {
            numeric.BackColor = Color.White;
        }

        private void LeaveTxt(TextBox text)
        {
            text.BackColor = Color.White;
        }

        private void HidingArrowsInNumerics()
        {
            txtBarNumber.Controls[0].Visible = false;
        }

        private void SetDateTimePicker()
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.BackColor = Color.PaleVioletRed;
        }

        #endregion AdjustmentWinFormsControls

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

        private void rjToggleButton1_Click(object sender, EventArgs e)
        {
            var statusOfButon = ExtraDescriptionTBox.Enabled;
            ExtraDescriptionTBox.Enabled = !statusOfButon;
        }

        private void txtBarNumber_MouseClick(object sender, MouseEventArgs e)
        {
            SelectBarNumber(txtBarNumber);
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            SelectTxt(txtName);
        }

        private void ExtraDescriptionTBox_Click(object sender, EventArgs e)
        {
            SelectTxt(ExtraDescriptionTBox);
        }

        private void txtBarNumber_Leave(object sender, EventArgs e)
        {
            LeaveNumeric(txtBarNumber);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            LeaveTxt(txtName);
        }

        private void ExtraDescriptionTBox_Leave(object sender, EventArgs e)
        {
            LeaveTxt(ExtraDescriptionTBox);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Timer.Start();
            TLPnlTop.Enabled = false;
            lblRightPanelMainName.Text = "Dodaj produkt";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Timer.Start();
            TLPnlTop.Enabled = true;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            PnlAdd.Width = 0;
            var products = ReturnDataFromDataBase();
            foreach (var item in products)
            {
                dataGridView1.Rows.Add(new object[] { item.RegistrationNumber, item.ProductDetailDto.Name, item.ProductDetailDto.Type, item.ProductDetailDto.ExtraDescription, item.AddedAt });
            }
        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            SelectTxt(TxtSearch);
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            LeaveTxt(TxtSearch);
        }

        private void btnResetValues_Click(object sender, EventArgs e)
        {
            txtBarNumber.Value = 0;
            txtName.Clear();
            ProductTypeComboBox.SelectedIndex = -1;
            ExtraDescriptionTBox.Clear();
            btnIsExtraDescriptionOn.Checked = false;
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            SetTimer();
            RightPanelEditAdjustment();
        }

        private void AssignmentDataFromEditProductDtoToEditInputs()
        {
            txtBarNumber.Enabled = false;
            txtBarNumber.Value = UpdateProductDto.RegistrationNumber;
            txtName.Text = UpdateProductDto.EditProductDetailDto.Name;
            ProductTypeComboBox.SelectedItem = UpdateProductDto.EditProductDetailDto.Type;
            dateTimePicker1.Value = UpdateProductDto.AddedAt;
            CheckExistenceOfDescriptionInEditPanel();
        }

        private void CheckExistenceOfDescriptionInEditPanel()
        {
            ExtraDescriptionTBox.Clear();
            if (UpdateProductDto.EditProductDetailDto.ExtraDescription == null)
            {
                ExtraDescriptionTBox.Enabled = false;
                btnIsExtraDescriptionOn.Checked = false;
            }
            else
            {
                ExtraDescriptionTBox.Enabled = true;
                btnIsExtraDescriptionOn.Checked = true;
                ExtraDescriptionTBox.Text = UpdateProductDto.EditProductDetailDto.ExtraDescription;
            }
        }

        private void RightPanelEditAdjustment()
        {
            TLPnlTop.Enabled = false;
            lblRightPanelMainName.Text = "Edytuj Produkt";
            btnResetValues.Enabled = false;
            btnCheckAvailability.Enabled = false;
        }

        private void SetTimer()
        {
            Timer.Start();
        }

        public IEnumerable<ProductDto> ReturnDataFromDataBase()
        {
            var dataReturn = new ReturnDataFromDb(ProductService);
            return dataReturn.Products;
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            var checkAvailability = new CheckRegisterNumberAvailability(txtBarNumber.Value, ProductService);
            if (checkAvailability.StatusCode == "Failed")
            {
                MessageBox.Show(checkAvailability.AvailabilityInformation, "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkAvailability.StatusCode == "Success")
            {
                MessageBox.Show(checkAvailability.AvailabilityInformation, "Informacja",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AssignmentDataToEditProductDto(e.RowIndex);
            AssignmentDataFromEditProductDtoToEditInputs();
        }

        private void AssignmentDataToEditProductDto(int digitOfSelectedRow)
        {
            if (digitOfSelectedRow >= 0)
            {
                var selectedRow = dataGridView1.Rows[digitOfSelectedRow];
                UpdateProductDto.RegistrationNumber = (int)selectedRow.Cells[0].Value;
                UpdateProductDto.EditProductDetailDto.Name = selectedRow.Cells[1].Value.ToString();
                UpdateProductDto.EditProductDetailDto.Type = selectedRow.Cells[2].Value.ToString();
                var validateDesctription = new DescriptionValidation(selectedRow.Cells[3].Value.ToString());
                UpdateProductDto.EditProductDetailDto.ExtraDescription = validateDesctription.ReturnValidateDescription();
                UpdateProductDto.AddedAt = (DateTime)selectedRow.Cells[4].Value;
            }
            else
            {
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy jesteś pewny?", "Informacja", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (lblRightPanelMainName.Text == "Dodaj produkt")
                {
                    AddNewProductPreValidation();
                }
                else
                {
                    EditProductPreValidation();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void EditProductPreValidation()
        {
            AssignedValuesFromInputsToEditProductDto();
            EditProductDtoValidation productValidation = new EditProductDtoValidation(IsExtraDescriptionOpen);
            var result = productValidation.Validate(UpdateProductDto);
            if (!result.IsValid)
            {
                MessageBox.Show(string.Join("\n", result.Errors), "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SwapProductWithEditProduct swapProducts = new SwapProductWithEditProduct(ProductService);
            }
        }

        private void AssignedValuesFromInputsToEditProductDto()
        {
            UpdateProductDto.EditProductDetailDto.Name = txtName.Text;
            UpdateProductDto.EditProductDetailDto.Type = ProductTypeComboBox.Text;
            UpdateProductDto.EditProductDetailDto.LastChangedAt = DateTime.Now;
            if (btnIsExtraDescriptionOn.Checked == true)
            {
                UpdateProductDto.EditProductDetailDto.ExtraDescription = ExtraDescriptionTBox.Text;
                IsExtraDescriptionOpen = true;
            }
            else
            {
                UpdateProductDto.EditProductDetailDto.ExtraDescription = null;
                IsExtraDescriptionOpen = false;
            }
        }

        private void AddNewProductPreValidation()
        {
        }
    }
}