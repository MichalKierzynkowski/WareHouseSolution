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
        #region AdjustmentWinFormsControls
        private void SelectTxt(TextBox txt)
        {
            txt.BackColor =  Color.FromArgb(139, 199, 255);
        }
        private void SelectComboBox(ComboBox cBox)
        {
            cBox.BackColor = Color.FromArgb(139, 199, 255);
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
        private void LeaveComboBox(ComboBox cBox)
        {
            cBox.BackColor = Color.White;
        }



        private void HidingArrowsInNumerics()
        {
            txtBarNumber.Controls[0].Visible = false;
        }
        private void SetDateTimePicker()
        {
            rjDatePicker1.Value=DateTime.Now;
            rjDatePicker1.Enabled = false;  
        }

        #endregion



        private void rjToggleButton1_Click(object sender, EventArgs e)
        {
            var statusOfButon = ExtraDescriptionTBox.Enabled;
            ExtraDescriptionTBox.Enabled = !statusOfButon;
        }

        private void txtBarNumber_MouseClick(object sender, MouseEventArgs e)
        {
            SelectBarNumber(txtBarNumber);
        }

        private void ProductTypeComboBox_Click(object sender, EventArgs e)
        {

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

        private void ProductTypeComboBox_Leave(object sender, EventArgs e)
        {
            LeaveComboBox(ProductTypeComboBox);
        }

        private void ExtraDescriptionTBox_Leave(object sender, EventArgs e)
        {
            LeaveTxt(ExtraDescriptionTBox);
        }
    }
}
