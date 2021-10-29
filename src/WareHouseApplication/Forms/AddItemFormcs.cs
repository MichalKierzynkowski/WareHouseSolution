using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseApplication.Forms
{
    public partial class AddItemFormcs : Form
    {
        public MainMenu ObjMainMenu { get; private set; }
        public AddItemFormcs(MainMenu objMainMenu)
        {
            InitializeComponent();
            this.ObjMainMenu = objMainMenu;
            
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz wrócić do głównego Menu? Wszystkie nie zapisane dane zostaną stracone!", "Wyjście!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz wrócić do głównego Menu? Wszystkie nie zapisane dane zostaną stracone!", "Wyjście!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


                this.Hide();
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedItemComboBox2 = Convert.ToInt16(comboBox2.SelectedIndex);
            comboBox3.SelectedIndex= selectedItemComboBox2;
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedItemComboBox3 = Convert.ToInt16(comboBox3.SelectedIndex);
            comboBox2.SelectedIndex = selectedItemComboBox3;

        }
    }
}
