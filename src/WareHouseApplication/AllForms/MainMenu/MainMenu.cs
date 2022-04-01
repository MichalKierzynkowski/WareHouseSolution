using RJCodeAdvance.RJControls;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseApplication.Desing;

namespace WareHouseApplication.Forms;

public partial class MainMenu : Form
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

                Task.Run(() => {
                    DisableButton();
                    Color color = SelectThemeColor();

                    UpPanel.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);



                    this.Invoke((Action)delegate
                    {

                        currentButton = (Button)btnSender;
                        currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                        currentButton.BackColor = color;
                        currentButton.ForeColor = Color.White;

                    });

                });


            }

        }
    }

    private void DisableButton()
    {
        Task.Run(() => {


            this.Invoke((Action)delegate
            {

                foreach (Control previousBtn in PanelTitleBar.Controls)
                {
                    if (previousBtn.GetType() == typeof(Button))
                    {
                        previousBtn.BackColor = SystemColors.Highlight;
                        previousBtn.ForeColor = Color.Gainsboro;
                        previousBtn.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    }
                }

            });

        });
    }

    private void btnProducts_Click(object sender, EventArgs e)
    {
        OpenChildForm(new NewForms.Product(), sender);
        //Open_DropdownMenu(DropDownMenu,sender);
    }

    private void btnWareHouse_Click(object sender, EventArgs e)
    {
        //ActivateButton(sender);
    }

    private void btnSales_Click(object sender, EventArgs e)
    {
        // ActivateButton(sender);
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
        OpenChildForm(new NewForms.Settings(), sender);
    }

    private void btnHelp_Click(object sender, EventArgs e)
    {
        // ActivateButton(sender);
    }

    private void Open_DropdownMenu(RJDropdownMenu dropdownMenu, object sender)
    {
        Control control = (Control)sender;
        dropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
            => rjDropdownMenu1_VisibleChanged(sender2, ev, control));
        dropdownMenu.Show(control, control.Width, 0);
    }

    private void rjDropdownMenu1_VisibleChanged(object sender, EventArgs e, Control control)
    {
        RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
        if (!DesignMode)
        {
            if (dropdownMenu.Visible)
                control.BackColor = Color.FromArgb(159, 161, 224);
            else
                control.BackColor = Color.FromArgb(98, 102, 224);
        }
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
        //if (activeForm != null)
        //{
        //    ActiveForm.Close();
        //}
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
}