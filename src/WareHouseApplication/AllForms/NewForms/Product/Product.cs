using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseApplication.NewForms
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            SetDateTimePicker();
            HidingArrowsInNumerics();

        }
        private void HidingArrowsInNumerics()
        {
            BarNumber.Controls[0].Visible = false;
        }
        private void SetDateTimePicker()
        {
            rjDatePicker1.Value=DateTime.Now;
            rjDatePicker1.Enabled = false;  
        }

       

      

        private void rjToggleButton1_Click(object sender, EventArgs e)
        {
            var statusOfButon = ExtraDescriptionTBox.Enabled;
            ExtraDescriptionTBox.Enabled = !statusOfButon;
        }
    }
}
