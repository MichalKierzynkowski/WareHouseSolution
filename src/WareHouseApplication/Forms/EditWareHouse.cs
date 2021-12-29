using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesLibrary;

namespace WareHouseApplication.Forms
{
    public partial class EditWareHouse : Form
    {
        public string ConnectionString { get; set; }
        private string ProductTypeDescription;
        private string BuyingMethodDescription;

        private int? BarNumberInt;
        public EditWareHouse(string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;
            DefaultFillingGridView();
        }

        private void DefaultFillingGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            using (var conn = new SqlConnection(ConnectionString))
            {
                //retrieve the SQL Server instance version
                var query =
                    @"SELECT Product.Description_Product, Purchase_Methods.Purchase_Method_Description, Product.Quantity, Product.Offer_Price, Purchase.Price, Product_Type.Product_Type_Description,Product.Bar_Number
                    FROM     Product INNER JOIN
                  Product_Type ON Product.Type_Product = Product_Type.Type_Product INNER JOIN
                  Purchase ON Product.Id_Product = Purchase.Id_Product INNER JOIN
                  Purchase_Methods ON Product.Purchase_Method = Purchase_Methods.Purchase_Method";


                //define the SqlCommand object
                var cmd = new SqlCommand(query, conn);

                //Set the SqlDataAdapter object
                var dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                var ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set DataGridView control to read-only
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.ColumnCount = 7;
                dataGridView1.Columns[0].HeaderText = "Opis";
                dataGridView1.Columns[0].DataPropertyName = "Description_Product";
                dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[1].HeaderText = "Rodzaj Produktu";
                dataGridView1.Columns[1].DataPropertyName = "Product_Type_Description";
                dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[2].HeaderText = "Metoda Zakupu";
                dataGridView1.Columns[2].DataPropertyName = "Purchase_Method_Description";
                dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[3].HeaderText = "Ilość";
                dataGridView1.Columns[3].DataPropertyName = "Quantity";
                dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[4].HeaderText = "Cena zakupu";
                dataGridView1.Columns[4].DataPropertyName = "Price";
                dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[5].HeaderText = "Cena sprzedaży";
                dataGridView1.Columns[5].DataPropertyName = "Offer_Price";
                dataGridView1.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[6].HeaderText = "Kod Kreskowy";
                dataGridView1.Columns[6].DataPropertyName = "Bar_Number";
                dataGridView1.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;



                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.BackgroundColor = SystemColors.Control;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
                dataGridView1.RowsDefaultCellStyle.Font = new Font("Arial", 7);
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //set the DataGridView control's data source/data table
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.AllowUserToResizeRows = false;
                
                dataGridView1.Columns[3].Width = 70;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 130;
                dataGridView1.Columns[6].Width = 100;
                
                //dataGridView1.Columns[]
                //close connection
                conn.Close();
            }
        }
        private string GetFilter()
        {

            List<string> parts = new List<string>();
            if (string.IsNullOrWhiteSpace(ProductTypeDescription) == false)
            {
                parts.Add($"Product_Type_Description like '%{ProductTypeDescription}%'");
            }

            if (string.IsNullOrWhiteSpace(BuyingMethodDescription) == false)
            {
                parts.Add($"Purchase_Method_Description like '%{BuyingMethodDescription}%'");
            }
            if (BarNumberInt != null)
            {

                parts.Add($"Bar_Number = {BarNumberInt}");


            }
           





            var stringResult = string.Join(" and ", parts);

            return stringResult;

        }

        private void RodzajProdSortowanieCyfraCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            int selectedItemComboBox2 = Convert.ToInt16(RodzajProdSortowanieCyfraCBox.SelectedIndex);
            RodzajProdSortowanieWyrazCBox.SelectedIndex = selectedItemComboBox2;
            ProductTypeDescription = RodzajProdSortowanieWyrazCBox.SelectedItem.ToString();

            var list = dataGridView1.DataSource;

            string prodType = RodzajProdSortowanieWyrazCBox.SelectedItem.ToString();

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;


            bs.Filter = GetFilter();

            dataGridView1.DataSource = bs;
        }

        private void MetodaZakupuCyfraCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedItemMetodaKupnaCyfra = Convert.ToInt16(MetodaZakupuCyfraCBox.SelectedIndex);
            MetodaZakupuWyrazCBox.SelectedIndex = selectedItemMetodaKupnaCyfra;
            var list = dataGridView1.DataSource;

            BuyingMethodDescription = MetodaZakupuWyrazCBox.SelectedItem.ToString();
            string buyingMethod = MetodaZakupuWyrazCBox.SelectedItem.ToString();
            BindingSource bs = new BindingSource();

            bs.DataSource = dataGridView1.DataSource;


            //bs.Filter = "Purchase_Method_Description like '%" + buyingMethod + "%'";
            bs.Filter = GetFilter();
            dataGridView1.DataSource = null;
            dataGridView1.ResetBindings();
            dataGridView1.DataSource = bs;
            var list2 = dataGridView1.DataSource;
        }

        private void MetodaZakupuWyrazCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedItemMetodaKupnaWyraz = Convert.ToInt16(MetodaZakupuWyrazCBox.SelectedIndex);
            MetodaZakupuCyfraCBox.SelectedIndex = selectedItemMetodaKupnaWyraz;
            BuyingMethodDescription = MetodaZakupuWyrazCBox.SelectedItem.ToString();
            string buyingMethod = MetodaZakupuWyrazCBox.SelectedItem.ToString();
            BindingSource bs = new BindingSource();




            bs.DataSource = dataGridView1.DataSource;
            dataGridView1.DataSource = null;

            // bs.Filter = "Purchase_Method_Description like '%" + buyingMethod+ "%'";
            bs.Filter = GetFilter();
            dataGridView1.DataSource = null;
            dataGridView1.ResetBindings();
            dataGridView1.DataSource = bs;
        }

        private void RodzajProdSortowanieWyrazCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedItemComboBox3 = Convert.ToInt16(RodzajProdSortowanieWyrazCBox.SelectedIndex);
            RodzajProdSortowanieCyfraCBox.SelectedIndex = selectedItemComboBox3;
            ProductTypeDescription = RodzajProdSortowanieWyrazCBox.SelectedItem.ToString();

            string prodType = RodzajProdSortowanieWyrazCBox.SelectedItem.ToString();
            BindingSource bs = new BindingSource();
            var list = dataGridView1.DataSource;

            bs.DataSource = dataGridView1.DataSource;
            // bs.Filter = "Product_Type_Description like '%" + prodType + "%'";
            bs.Filter = GetFilter();
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = bs;

            var list2 = dataGridView1.DataSource;
        }

        private void RodzajProdSortowanieCyfraCBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedItemComboBox2 = Convert.ToInt16(RodzajProdCBox.SelectedIndex);
            RodzajProduktuWyrazCBox.SelectedIndex = selectedItemComboBox2;

        }

        private void MetodaZakupuCyfraCBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedItemMetodaKupnaCyfra = Convert.ToInt16(MetodaKupnaCyfraCBox.SelectedIndex);
            MetodaKupnaWyrazCBox.SelectedIndex = selectedItemMetodaKupnaCyfra;
        }

        private void MetodaZakupuWyrazCBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedItemMetodaKupnaWyraz = Convert.ToInt16(MetodaKupnaWyrazCBox.SelectedIndex);
            MetodaKupnaCyfraCBox.SelectedIndex = selectedItemMetodaKupnaWyraz;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetSortingFields();
            DefaultFillingGridView();
            ProductTypeDescription = string.Empty;
            BuyingMethodDescription = string.Empty;
            BarNumberInt = null;
        }

        public void ResetSortingFields()
        {
            RodzajProdSortowanieCyfraCBox.SelectedIndex = -1;
            RodzajProdSortowanieWyrazCBox.SelectedIndex = -1;
            MetodaZakupuCyfraCBox.SelectedIndex = -1;
            MetodaZakupuWyrazCBox.SelectedIndex = -1;
            NumerKreskowyTBox.Clear();
        }

        private void SortingButton_Click(object sender, EventArgs e)
        {
            var validateObj = new IsNullIAddingItemValidation();
            var rulesValidationObj = new RulesValidationAddingItem();
            if (validateObj.CheckSingleString(NumerKreskowyTBox.Text))
            {
                MessageBoxFailure();
            }
            else
            {

                if (rulesValidationObj.Validation(NumerKreskowyTBox.Text))
                {
                    BarNumberInt = Convert.ToInt32(NumerKreskowyTBox.Text);
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dataGridView1.DataSource;


                    bs.Filter = GetFilter();

                    dataGridView1.DataSource = bs;
                }
                else
                {
                    WrongFormatMessageBox();
                }
            }
        }
        private void MessageBoxFailure()
        {
            MessageBox.Show("Nie wypełniono pola - Kod Kreskowy!", " Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void WrongFormatMessageBox()
        {
            MessageBox.Show("Pole Kod Kreskowy zawiera niepoprawne znaki!", " Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
