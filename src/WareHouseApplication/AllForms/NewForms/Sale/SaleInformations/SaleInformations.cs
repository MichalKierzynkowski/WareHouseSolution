using System.Linq;
using System.Windows.Forms;
using ApplicationLayer.Dto.Sale;
using ApplicationLayer.Interfaces;
namespace WareHouseApplication.AllForms.NewForms.Sale
{
    public partial class SaleInformations : Form
    {
        private readonly ISaleService _saleService;
        private readonly int _idOfSale;

        public SaleInformations(ISaleService saleService, int idOfSale)
        {
            _saleService = saleService;
            _idOfSale = idOfSale;
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, System.EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            System.Threading.Thread thread =
                new System.Threading.Thread(new System.Threading.ThreadStart(LoadTable));
            thread.Start();
            
        }
        internal delegate void SetDataSourceDelegate(SaleDto sale);
        private void SetDataSource(SaleDto sale)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(SetDataSource), sale);
            }
            else
            {
                var productsFromWarehouses = sale.WareHouses;
                var productsFromReturns = sale.Returns;
               
                foreach (var item in productsFromWarehouses)
                {
                    var product = item.Products.FirstOrDefault();
                    if (product != null)
                    {
                        dataGridView1.Rows.Add(new object[] { product.RegistrationNumber, product.ProductDetail.Name, product.ProductDetail.Type, product.ProductDetail.ExtraDescription, item.Quantity, "Nie" });
                    }
                    
                }
                foreach (var item in productsFromReturns)
                {
                    var product = item.Products.FirstOrDefault();
                    if (product != null)
                    {
                        dataGridView1.Rows.Add(new object[] { product.RegistrationNumber, product.ProductDetail.Name, product.ProductDetail.Type, product.ProductDetail.ExtraDescription, item.Quantity, "Tak" });
                    }
                   
                }

                dataGridView1.DataSource = null;
                progressBar.Visible = false;
            }
        }
        private void LoadTable()
        {
            var sale = _saleService.GetById(_idOfSale);
            SetDataSource(sale);
            dataGridView1.ClearSelection();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
} 