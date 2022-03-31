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
    public MainMenu()
    {
        InitializeComponent();
        random = new Random();
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
           if (currentButton!=(Button)btnSender)
            {

                Task.Run(() => {
                    DisableButton();
                    Color color = SelectThemeColor();
                                                   
                    UpPanel.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);                   
                    this.Invoke((Action)delegate {

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
           

            this.Invoke((Action)delegate {

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
        ActivateButton(sender);
    }

    private void btnWareHouse_Click(object sender, EventArgs e)
    {
        ActivateButton(sender);
    }

    private void btnSales_Click(object sender, EventArgs e)
    {
        ActivateButton(sender);
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
        ActivateButton(sender);
    }

    private void btnHelp_Click(object sender, EventArgs e)
    {
        ActivateButton(sender);
    }
}