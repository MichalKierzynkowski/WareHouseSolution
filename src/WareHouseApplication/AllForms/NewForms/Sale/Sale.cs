using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using ApplicationLayer.Services;
using System.Windows.Forms;

namespace WareHouseApplication.AllForms.NewForms.Sale
{
    public partial class Sale : Form
    {
        public  IWareHouseService WareHouseService;
        public IProductService ProductService { get; set; }
        public Sale(IProductService productService,IWareHouseService wareHouseService)
        {
            WareHouseService = wareHouseService;
            InitializeComponent();
            SetOffDeleteAndEditButtons();
            ProductService = productService;
        }

        private void SetOffDeleteAndEditButtons()
        {
            btnDelete.Enabled = false;
            btnEditProduct.Enabled = false;
        }
        private void SetOnDeleteAndEditButtons()
        {
            btnDelete.Enabled = true;
            btnEditProduct.Enabled = true;
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            if (PnlAdd.Width == 395)
            {
                for (int i = 0; i < 5; i++)
                    PnlAdd.Width = PnlAdd.Width - 79;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    PnlAdd.Width = PnlAdd.Width + 79;
            }

            Timer.Stop();
        }

        private void SetTimer()
        {
            Timer.Start();
        }

        private void btnAddProduct_Click(object sender, System.EventArgs e)
        {
            SetTimer();
        }

        private void Sale_Load(object sender, System.EventArgs e)
        {
            PnlAdd.Width = 0;
            CBoxSearchByCategory.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Timer.Start();
            TLPnlTop.Enabled = true;
        }

        private void btnSelectProduct_Click(object sender, System.EventArgs e)
        {
            using (SelectProduct selectProduct = new SelectProduct(ProductService,WareHouseService))
            {
                selectProduct.ShowDialog();
            }
        }
    }
}