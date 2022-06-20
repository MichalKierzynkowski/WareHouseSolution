using FormsLogic.ProductForm.DatePickPopUp.Entities;
using FormsLogic.ProductForm.DatePickPopUp.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseApplication.AllForms.NewForms.Product.DatePickPopUp
{
    public partial class DatePicker : Form
    {
        public bool IsFormatCorrect { get; set; }

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

            var date = new SelectedDate(dTPickerDateFrom.Value, dTPickerDateTo.Value);
            var dateValidation = new SelectedDateValidation();
            var result = dateValidation.Validate(date);
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
