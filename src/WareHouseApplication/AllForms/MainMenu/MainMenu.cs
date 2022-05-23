using Infrastructure.Data;
using Infrastructure.Repositories;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseApplication.AllForms.NewForms.BaseForm;
using WareHouseApplication.Desing;

namespace WareHouseApplication.Forms;

public partial class MainMenu : BaseForm
{
    private Button currentButton;
    private Random random;
    private int tempIndex;
    private Form activeForm;

    public MainMenu()
    {
        InitializeComponent();
        random = new Random();
        timer1.Start();
    }

    private Color SelectThemeColor()
    {
        int index = random.Next(Desing.ThemeColor.ColorList.Count);
        while (tempIndex == index)
        {
            random.Next(Desing.ThemeColor.ColorList.Count);
        }
        tempIndex = index;
        string color = ThemeColor.ColorList[index];
        return ColorTranslator.FromHtml(color);
    }

    private void ActivateButton(object btnSender)
    {
        if (btnSender != null)
        {
            if (currentButton != (Button)btnSender)
            {
                Task.Run(() =>
                {
                    Color color = SelectThemeColor();
                    UpPanel.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                });
            }
        }
    }

    private void btnProducts_Click(object sender, EventArgs e)
    {
        OpenChildForm(new NewForms.Product(), sender);
    }

    private void btnWareHouse_Click(object sender, EventArgs e)
    {
        OpenChildForm(new AllForms.NewForms.WareHouse.WareHouse(), sender);
    }

    private void btnSales_Click(object sender, EventArgs e)
    {
        OpenChildForm(new AllForms.NewForms.Sale.Sale(), sender);
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
        OpenChildForm(new NewForms.Settings(), sender);
    }

    private void btnHelp_Click(object sender, EventArgs e)
    {
        OpenChildForm(new AllForms.NewForms.Help.Help(), sender);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        lblTime.Text = DateTime.Now.ToString("HH:mm");
        lblsecond.Text = DateTime.Now.ToString("ss");
        lblDate.Text = DateTime.Now.ToString("MM dd yyyy");
        lblDay.Text = DateTime.Now.ToString("dddd");
    }

    private void OpenChildForm(Form childForm, object btnSender)
    {
        ActivateButton(btnSender);

        activeForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        this.panelDekstopPane.Controls.Add(childForm);
        this.panelDekstopPane.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
        lblTitle.Text = childForm.Text;
    }

    private void btnMinimalize_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Jesteś pewny wyjścia z programu?", "Wyjście", MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
            Application.Exit();
        }
    }
}