using System;
using System.Drawing;
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
            txt.BackColor = Color.FromArgb(139, 199, 255);
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
            rjDatePicker1.Value = DateTime.Now;
            rjDatePicker1.Enabled = false;
        }

        #endregion AdjustmentWinFormsControls

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(PnlAdd.Width==395)
            {
                for (int i = 0; i < 5; i++)
                    PnlAdd.Width = PnlAdd.Width - 79;
                    TLPnlAdd.Visible = true;
            }
            else
            {
                for (int i = 0; i <5; i++)
                    PnlAdd.Width = PnlAdd.Width +79;
                TLPnlAdd.Visible = false;
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

        private void ProductTypeComboBox_Click(object sender, EventArgs e)
        {
            SelectComboBox(ProductTypeComboBox);
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Timer.Start();
            TLPnlTop.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Timer.Start();
            TLPnlTop.Enabled = true;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            PnlAdd.Width = 0;
        }
    }
}