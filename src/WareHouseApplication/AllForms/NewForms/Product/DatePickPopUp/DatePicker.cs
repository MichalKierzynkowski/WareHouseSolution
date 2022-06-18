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
        #endregion

        #region SetInitialElements
        private void DatePicker_Load(object sender, EventArgs e)
        {
            dTPickerDateFrom.Value = DateTime.Today;
        }
        #endregion


    }
}
