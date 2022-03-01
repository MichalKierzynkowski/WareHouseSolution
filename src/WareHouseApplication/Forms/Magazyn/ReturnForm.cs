using System.Windows.Forms;

namespace WareHouseApplication.Forms.Magazyn;

public partial class ReturnForm : Form
{
    public string ConnectionString { get; set; }
      
    public ReturnForm(string connectionString)
    {
        InitializeComponent();
        ConnectionString = connectionString;
          
    }



}