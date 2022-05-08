using Infrastructure.Data;
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
            dataGridView1.Rows.Add(new object[] { "100", "test", "test", "test", "---" });
            dataGridView1.Rows.Add(new object[] { "1", "test", "test", "test", "---" });
            dataGridView1.Rows.Add(new object[] { "10", "test", "test", "test", "---" });

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
            SqlLiteDataAccess test = new SqlLiteDataAccess();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            Timer.Start();
            TLPnlTop.Enabled = false;
            lblRightPanelMainName.Text = "Edytuj Produkt";

        }


    }
}