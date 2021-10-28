using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseApplication.Forms;

namespace WareHouseApplication
{
    public partial class MainMenu : Form
    {
        public MainMenu ObjMainMenu { get; private set; }

        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz wyjść z aplikacji?", "Wyjście!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void dodajProduktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new AddItemFormcs(ObjMainMenu);
            obj.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz wyjść z aplikacji?", "Wyjście!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            var objMainMenu = new MainMenu();
            this.ObjMainMenu = objMainMenu;
        }
    }
}
