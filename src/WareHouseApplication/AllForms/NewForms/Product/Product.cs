using ApplicationLayer.Dto.ProductDetailDtos;
using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using FormsLogic.ProductForm.DatePickPopUp.Entities;
using FormsLogic.ProductForm.Logic.Data;
using FormsLogic.ProductForm.Logic.Edit;
using FormsLogic.ProductForm.Logic.Entities;
using FormsLogic.ProductForm.Logic.Filtering;
using FormsLogic.ProductForm.Logic.FilteringOptionsManagement;
using FormsLogic.ProductForm.Validation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WareHouseApplication.AllForms.NewForms.Product.DatePickPopUp;

namespace WareHouseApplication.NewForms
{
    public partial class Product : Form
    {
        #region Properties
        public IProductService ProductService { get; set; }
        public DeleteProductDto DeleteProductDto { get; set; }
        public DeleteProductDetailDto DeleteProductDetailDto { get; set; }
        public UpdateProductDto UpdateProductDto { get; set; }
        public UpdateProductDetailDto UpdateProductDetailDto { get; set; }
        public CreateProductDto CreateProductDto { get; set; }
        public CreateProductDetailDto CreateProductDetailDto { get; set; }
        public bool IsExtraDescriptionOpen { get; set; }
        #endregion

        #region Constructor
        public Product(IProductService productService)
        {
            InitializeComponent();
            SetDateTimePicker();
            HidingArrowsInNumerics();
            ProductService = productService;
            UpdateProductDetailDto = new UpdateProductDetailDto();
            UpdateProductDto = new UpdateProductDto(UpdateProductDetailDto);
            CreateProductDetailDto = new CreateProductDetailDto();
            CreateProductDto = new CreateProductDto(CreateProductDetailDto);
            DeleteProductDetailDto = new DeleteProductDetailDto();
            DeleteProductDto = new DeleteProductDto(DeleteProductDetailDto);

        }
        #endregion

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

        #region MenuButtons
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
        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy jesteś pewny?", "Informacja", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (lblRightPanelMainName.Text == "Dodaj produkt")
                {
                    AddNewProductPreValidation();
                }
                else if (lblRightPanelMainName.Text == "Edytuj Produkt")
                {
                    EditProductPreValidation();
                }
                else if (lblRightPanelMainName.Text == "Usuń Produkt")
                {
                    DeleteProductPreValidation();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetValuesInDataGridAndFillWithValuesAgain();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SetTimer();
            RightPanelDeleteProductAdjustment();

        }

        private void rjToggleButton1_Click(object sender, EventArgs e)
        {
            var statusOfButon = ExtraDescriptionTBox.Enabled;
            ExtraDescriptionTBox.Enabled = !statusOfButon;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Timer.Start();
            RightPanelAddProductAdjustment();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Timer.Start();
            TLPnlTop.Enabled = true;
        }

        private void btnResetValues_Click(object sender, EventArgs e)
        {
            ResetValuesInInputs();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            SetTimer();
            RightPanelEditAdjustment();
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

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            SelectTxt(TxtSearch);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lblRightPanelMainName.Text == "Edytuj Produkt")
            {
                AssignmentDataToEditProductDto(e.RowIndex);
                AssignmentDataFromEditProductDtoToEditInputs();
            }
            else if (lblRightPanelMainName.Text == "Usuń Produkt")
            {

                AssigmentDataToDeleteProductDto(e.RowIndex);
                AssignmentDataFromDeleteProductDtoToDeleteInputs();
                ExtraDescriptionTBox.Enabled = false;
            }
        }
        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            TxtSearch.Clear();
            CBoxSearchByCategory.SelectedIndex = 0;
            ResetValuesInDataGridAndFillWithValuesAgain();
        }

        #endregion

        #region TimerSettings
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
        private void SetTimer()
        {
            Timer.Start();
        }
        #endregion

        #region RighPanelAdjustment
        private void RightPanelEditAdjustment()
        {
            TLPnlTop.Enabled = false;
            lblRightPanelMainName.Text = "Edytuj Produkt";
            btnResetValues.Enabled = false;
            btnCheckAvailability.Enabled = false;
            txtBarNumber.Enabled = true;
            txtName.Enabled = true;
            btnIsExtraDescriptionOn.Enabled = true;
            ProductTypeComboBox.Enabled = true;
        }

        private void RightPanelAddProductAdjustment()
        {
            TLPnlTop.Enabled = false;
            lblRightPanelMainName.Text = "Dodaj produkt";
            btnResetValues.Enabled = true;
            btnCheckAvailability.Enabled = true;
            txtBarNumber.Enabled = true;
            dateTimePicker1.Value = DateTime.Now;
            ResetValuesInInputs();
        }
        private void RightPanelDeleteProductAdjustment()
        {
            TLPnlTop.Enabled = false;
            lblRightPanelMainName.Text = "Usuń Produkt";
            btnResetValues.Enabled = false;
            btnCheckAvailability.Enabled = false;
            txtBarNumber.Enabled = false;
            txtName.Enabled = false;
            btnIsExtraDescriptionOn.Enabled = false;
            ProductTypeComboBox.Enabled = false;

        }

        #endregion

        #region LeaveFunctions
        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            LeaveTxt(TxtSearch);
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
        #endregion

        #region AssignmentFunctions

        private void AssignmentDataFromDeleteProductDtoToDeleteInputs()
        {
            txtBarNumber.Enabled = false;
            txtBarNumber.Value = DeleteProductDto.RegistrationNumber;
            txtName.Text = DeleteProductDto.DeleteProductDetailDto.Name;
            ProductTypeComboBox.SelectedItem = DeleteProductDto.DeleteProductDetailDto.Type;
            dateTimePicker1.Value = DeleteProductDto.AddedAt;
            CheckExistenceOfDescriptionInDeletePanel();
        }
        private void AssignedValuesFromInputsToCreateProductDto()
        {
            CreateProductDto.RegistrationNumber = (int)txtBarNumber.Value;
            CreateProductDetailDto.Name = txtName.Text;
            CreateProductDetailDto.Type = ProductTypeComboBox.Text;
            CreateProductDto.AddedAt = DateTime.Now;
            CreateProductDetailDto.CreateProductDto = CreateProductDto;
            if (btnIsExtraDescriptionOn.Checked == true)
            {
                CreateProductDto.CreateProductDetailDto.ExtraDescription = ExtraDescriptionTBox.Text;
                IsExtraDescriptionOpen = true;
            }
            else
            {
                CreateProductDto.CreateProductDetailDto.ExtraDescription = null;
                IsExtraDescriptionOpen = false;
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
        }
        private void AssigmentDataToDeleteProductDto(int digitOfSelectedRow)
        {
            if (digitOfSelectedRow >= 0)
            {
                var selectedRow = dataGridView1.Rows[digitOfSelectedRow];
                DeleteProductDto.RegistrationNumber = (int)selectedRow.Cells[0].Value;
                DeleteProductDto.DeleteProductDetailDto.Name = selectedRow.Cells[1].Value.ToString();
                DeleteProductDto.DeleteProductDetailDto.Type = selectedRow.Cells[2].Value.ToString();
                var validateDesctription = new DescriptionValidation(selectedRow.Cells[3].Value.ToString());
                DeleteProductDto.DeleteProductDetailDto.ExtraDescription = validateDesctription.ReturnValidateDescription();
                DeleteProductDto.AddedAt = (DateTime)selectedRow.Cells[4].Value;
            }
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
        #endregion

        #region ResetValuesFunctions
        private void ResetValuesInDataGridAndFillWithValuesAgain()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            var products = ReturnDataFromDataBase();
            LoadProductsToDataGridView(products);
        }
        private void ResetValuesInInputs()
        {
            txtBarNumber.Value = 0;
            txtName.Clear();
            ProductTypeComboBox.SelectedIndex = -1;
            ExtraDescriptionTBox.Clear();
            ExtraDescriptionTBox.Enabled = false;
            btnIsExtraDescriptionOn.Checked = false;
        }
        #endregion

        #region PreValidations
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
                SwapProductWithEditProduct swapProducts = new SwapProductWithEditProduct(ProductService, UpdateProductDto);
                MessageBox.Show("Operacja przebiegła pomyślnie!", "Sukces!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesInDataGridAndFillWithValuesAgain();
                Timer.Start();
                TLPnlTop.Enabled = true;
            }
        }
        private void AddNewProductPreValidation()
        {
            AssignedValuesFromInputsToCreateProductDto();
            CreateProductDtoValidation productValidation = new CreateProductDtoValidation(IsExtraDescriptionOpen, ProductService);
            var result = productValidation.Validate(CreateProductDto);
            if (!result.IsValid)
            {
                MessageBox.Show(string.Join("\n", result.Errors), "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddNewProductToDataBase newProduct = new AddNewProductToDataBase(CreateProductDto, ProductService);
                MessageBox.Show("Operacja przebiegła pomyślnie!", "Sukces!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesInDataGridAndFillWithValuesAgain();
                Timer.Start();
                TLPnlTop.Enabled = true;

                ExtraDescriptionTBox.Enabled = false;
            }
        }
        public void DeleteProductPreValidation()
        {
            var deleteProductValidation = new DeleteProductValidation(DeleteProductDto);
            if (deleteProductValidation.IsFormatCorrect)
            {
                var deleteProduct = new DeleteProductFromDataBase(DeleteProductDto.RegistrationNumber, ProductService);
                MessageBox.Show("Operacja przebiegła pomyślnie!", "Sukces!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesInDataGridAndFillWithValuesAgain();
                Timer.Start();
                TLPnlTop.Enabled = true;

            }
            else
            {
                MessageBox.Show("Nie wybrano produktu do usunięcia!", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region LoadData
        public IEnumerable<ProductDto> ReturnDataFromDataBase()
        {
            var dataReturn = new ReturnDataFromDb(ProductService);
            return dataReturn.Products;
        }
        private void Product_Load(object sender, EventArgs e)
        {
            PnlAdd.Width = 0;
            var products = ReturnDataFromDataBase();
            LoadProductsToDataGridView(products);
            dataGridView1.ClearSelection();
            CBoxSearchByCategory.SelectedIndex = 0;

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
        #endregion

        #region CheckExistence

        private void CheckExistenceOfDescriptionInDeletePanel()
        {
            ExtraDescriptionTBox.Clear();
            if (DeleteProductDto.DeleteProductDetailDto.ExtraDescription == null)
            {
                ExtraDescriptionTBox.Enabled = false;
                btnIsExtraDescriptionOn.Checked = false;
            }
            else
            {
                ExtraDescriptionTBox.Enabled = true;
                btnIsExtraDescriptionOn.Checked = true;
                ExtraDescriptionTBox.Text = DeleteProductDto.DeleteProductDetailDto.ExtraDescription;
            }
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





        #endregion

        #region SelectionChangeCommitted 
        private void CBoxSearchByCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CBoxSearchByCategory.SelectedItem == "Data Dodania")
            {
                TxtSearch.Enabled = false;
                TxtSearch.Clear();

                using (DatePicker datePicker = new DatePicker())
                {
                    if (datePicker.ShowDialog() == DialogResult.OK && datePicker.IsFormatCorrect)
                    {
                        var filteringDataByDate = new FilteringDataGridViewByDate(datePicker.SelectedDate, ProductService);
                        var products = filteringDataByDate.ProductsAfterFiltering;
                        LoadProductsToDataGridView(products);

                    }
                }

            }
            else
            {
                TxtSearch.Enabled = true;
            }
        }
        #endregion


    }
}