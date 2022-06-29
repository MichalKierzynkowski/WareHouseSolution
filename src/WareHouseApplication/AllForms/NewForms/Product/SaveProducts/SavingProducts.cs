using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseApplication.AllForms.NewForms.Product.SaveProducts
{
    public partial class SavingProducts : Form
    {

        #region ButtonsClick
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Constructor
        public SavingProducts()
        {
            InitializeComponent();
        }
        #endregion
    }
}
