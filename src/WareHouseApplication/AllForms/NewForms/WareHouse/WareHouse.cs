
using System.Windows.Forms;
using ApplicationLayer.Interfaces;

namespace WareHouseApplication.AllForms.NewForms.WareHouse
{
    public partial class WareHouse : Form
    {
        public IProductService ProductService { get; set; }
        public WareHouse(IProductService productService)
        {
            InitializeComponent();
            ProductService=productService;
        }

        private void btnSelectProduct_Click(object sender, System.EventArgs e)
        {
            SelectProduct selectProduct = new SelectProduct(ProductService);
            selectProduct.Show();
        }
    }
}