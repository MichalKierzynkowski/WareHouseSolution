using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using FormsLogic.ProductForm.Logic.Data;

namespace WareHouseApplication.AllForms.NewForms.WareHouse
{
    public partial class SelectProduct : Form
    {
        public IProductService ProductService { get; set; }

        public SelectProduct(IProductService productService)
        {
            InitializeComponent();
            this.TopMost = true;
            ProductService = productService;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        internal delegate void SetDataSourceDelegate(IEnumerable<ProductDto> products);
        private void SetDataSource(IEnumerable<ProductDto> products)
        {
            // Invoke method if required:
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(SetDataSource), products);
            }
            else
            {
                dataGridView1.DataSource = null;
                foreach (var item in products)
                {
                    dataGridView1.Rows.Add(new object[] { item.RegistrationNumber, item.ProductDetailDto.Name, item.ProductDetailDto.Type, item.ProductDetailDto.ExtraDescription, item.AddedAt });
                }
                progressBar.Visible = false;
            }
        }

        private void SelectProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            CBoxSearchByCategory.SelectedIndex = 0;
        }

        public IEnumerable<ProductDto> ReturnDataFromDataBase()
        {
            var dataReturn = new ReturnDataFromDb(ProductService);
            return dataReturn.Products;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            System.Threading.Thread thread =
                new System.Threading.Thread(new System.Threading.ThreadStart(LoadTable));
            thread.Start();
        }

        private void LoadTable()
        {
            var products = ReturnDataFromDataBase();
            SetDataSource(products);
            dataGridView1.ClearSelection();
        }


    }
}
