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
        int mov;
        int movX;
        int movY;

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
            //this.Location= Screen.AllScreens[0].WorkingArea.Location;
        }

        private void wyświetlMagazynToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new ShowWareHouse(ObjMainMenu);
            obj.Show();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov==1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
