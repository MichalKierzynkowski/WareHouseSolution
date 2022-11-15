
using System.Windows.Forms;

namespace WareHouseApplication.AllForms.NewForms.WareHouse
{
    public partial class WareHouse : Form
    {
        public WareHouse()
        {
            InitializeComponent();
        }

        private void btnSelectProduct_Click(object sender, System.EventArgs e)
        {
            SelectProduct selectProduct = new SelectProduct();
            selectProduct.Show();
        }
    }
}