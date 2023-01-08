using System;
using System.Windows.Forms;
using ApplicationLayer.Interfaces;
using Domain.Interfaces;
using Infrastructure.Repositories;
using WareHouseApplication.AllForms.NewForms.BaseForm;
using WareHouseApplication.AllForms.NewForms.Product;
using WareHouseApplication.AllForms.NewForms.Settings;

namespace WareHouseApplication.AllForms.MainMenu
{
    public partial class MainMenu : BaseForm
    {
        private readonly IProductRepository _productRepository;
        private readonly IReturnService _returnService;
        private readonly ISaleService _saleService;
        private readonly IWareHouseRepository _wareHouseRepository;
        private readonly IReturnRepository _returnRepository;

        #region Properties
        private Random _random;
        private Form _activeForm;
        public IProductService ProductService { get; set; }
        public IWareHouseService WareHouseService { get; set; }
        #endregion

        #region Constructor
        public MainMenu(IProductService productService, IWareHouseService wareHouseService,IProductRepository productRepository,
            IReturnService returnService,ISaleService saleService,IWareHouseRepository wareHouseRepository,IReturnRepository returnRepository)
        {
            _productRepository = productRepository;
            _returnService = returnService;
            InitializeComponent();
            _random = new Random();
            timer1.Start();
            ProductService = productService;
            WareHouseService = wareHouseService;
            _saleService = saleService;
            _wareHouseRepository = wareHouseRepository;
            _returnRepository = returnRepository;
        }
        #endregion

        #region ButtonsClickEvents

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Product(ProductService));
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllForms.NewForms.WareHouse.WareHouse(ProductService,WareHouseService,_productRepository,_returnService));
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllForms.NewForms.Sale.Sale(ProductService,WareHouseService,_returnService,_saleService,_returnRepository,_wareHouseRepository));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Settings());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllForms.NewForms.Help.Help());
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
        #endregion
        
        #region OpenForms
        private void OpenChildForm(Form childForm)
        {

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDekstopPane.Controls.Add(childForm);
            this.panelDekstopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }
        #endregion

    }
}