using FormsLogic.ProductForm.DatePickPopUp.Entities;
using System;
using System.Windows.Forms;
using FormsLogic.ProductForm.DatePickPopUp.Validation;

namespace WareHouseApplication.AllForms.NewForms.Product.DatePickPopUp
{
    public partial class DatePicker : Form
    {
        #region Properties
        public bool IsFormatCorrect { get; set; }
        public SelectedDate SelectedDate { get; set; }
        #endregion

        #region Constructor
        public DatePicker()
        {
            InitializeComponent();
        }
        #endregion

        #region MenuButtons
        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {

            SelectedDate = new SelectedDate(dTPickerDateFrom.Value, dTPickerDateTo.Value);
            var dateValidation = new SelectedDateValidation();
            var result = dateValidation.Validate(SelectedDate);
            if (!result.IsValid)
            {
                IsFormatCorrect = false;
                MessageBox.Show(string.Join("\n", result.Errors), "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IsFormatCorrect = true;

            }

        }
        #endregion

        #region SetInitialElements
        private void DatePicker_Load(object sender, EventArgs e)
        {
            dTPickerDateFrom.Value = DateTime.Today;
        }

        #endregion

    }
}