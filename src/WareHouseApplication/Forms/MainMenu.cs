using System;
using System.Windows.Forms;
using ClassesLibrary.SqlClassesInterfaces;
using WareHouseApplication.Forms.Magazyn;
using WareHouseApplication.Forms.Program;
using WareHouseApplication.Forms.Sale;

namespace WareHouseApplication.Forms;

public partial class MainMenu : Form
{
    int mov;
    int movX;
    int movY;
    public string connectionString { get; set; }

    public MainMenu ObjMainMenu { get; private set; }
    public ReturnSqlConnection objReturnSql { get; set; }
    public MainMenu()
    {
        InitializeComponent();
        objReturnSql = new ReturnSqlConnection();
        connectionString = objReturnSql.ReturnSqlPc();
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
        var obj = new AddItemFormcs(ObjMainMenu, connectionString);
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
        var obj = new ShowWareHouse(ObjMainMenu, connectionString);
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
        if (mov == 1)
        {
            this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
        mov = 0;
    }

    private void zwróćProduktToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var obj = new ReturnForm(connectionString);
        obj.Show();
    }

    private void edycjaMagazynuToolStripMenuItem_Click(object sender, EventArgs e)
    {
    //    var obj = new EditWareHouse(connectionString);
    //    obj.Show();
    }

    private void informacjeOWersjiToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var obj = new VersionInformation();
        obj.Show();
    }

    private void sprzedajPrzedmiotToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var obj = new AddSale(connectionString);
        obj.Show();
    }
}