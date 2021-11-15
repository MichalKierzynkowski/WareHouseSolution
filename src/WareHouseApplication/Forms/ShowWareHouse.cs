using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WareHouseApplication.Forms
{
    public partial class ShowWareHouse : Form
    {
        public string connectionString { get; set; }

        public ShowWareHouse(MainMenu objMainMenu, string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ObjMainMenu = objMainMenu;
            ShowAllProducts();
          


        }

        public MainMenu ObjMainMenu { get; }

        private void ShowWareHouse_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
      
        private void ShowAllProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //retrieve the SQL Server instance version
                string query = @"SELECT   Product.Bar_Number, Product.Description_Product, Product.Purchase_Method, Product.Quantity, Product.Offer_Price, Product_Type.Product_Type_Description, Purchase.Price, Purchase_Methods.Purchase_Method_Description
FROM      Product INNER JOIN
                Product_Type ON Product.Type_Product = Product_Type.Type_Product INNER JOIN
                Purchase ON Product.Id_Product = Purchase.Id_Product INNER JOIN
                Purchase_Methods ON Product.Purchase_Method = Purchase_Methods.Purchase_Method";


                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                //Set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set DataGridView control to read-only
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.ColumnCount = 7;
                dataGridView1.Columns[0].HeaderText = "Kod Kreskowy";
                dataGridView1.Columns[0].DataPropertyName = "Bar_Number";
                dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[1].HeaderText = "Opis Produktu";
                dataGridView1.Columns[1].DataPropertyName = "Description_Product";
                dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[2].HeaderText = "Ilość";
                dataGridView1.Columns[2].DataPropertyName = "Quantity";
                dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[3].HeaderText = "Cena sprzedaży";
                dataGridView1.Columns[3].DataPropertyName = "Offer_Price";
                dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[4].HeaderText = "Cena zakupu";
                dataGridView1.Columns[4].DataPropertyName = "Price";
                dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

                dataGridView1.Columns[5].HeaderText = "Rodzaj Produktu";
                dataGridView1.Columns[5].DataPropertyName = "Product_Type_Description";
                dataGridView1.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[6].HeaderText = "Metoda Zakupu";
                dataGridView1.Columns[6].DataPropertyName = "Purchase_Method_Description";
                dataGridView1.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView1.AllowUserToAddRows = false;
                dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, FontStyle.Bold);
                dataGridView1.RowsDefaultCellStyle.Font = new System.Drawing.Font("Arial", 7);
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //set the DataGridView control's data source/data table
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.AllowUserToResizeRows = false;
                dataGridView1.Columns[0].Width = 75;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 75;
              
                //close connection
                conn.Close();
            }
        }

        private void RodzajProdCBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedItemComboBox2 = Convert.ToInt16(RodzajProdCBox.SelectedIndex);
            comboBox3.SelectedIndex = selectedItemComboBox2;
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedItemComboBox3 = Convert.ToInt16(comboBox3.SelectedIndex);
            RodzajProdCBox.SelectedIndex = selectedItemComboBox3;
        }

        private void MetodaKupnaCyfraCBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedItemMetodaKupnaCyfra = Convert.ToInt16(MetodaKupnaCyfraCBox.SelectedIndex);
            MetodaKupnaWyrazCBox.SelectedIndex = selectedItemMetodaKupnaCyfra;
        }

        private void MetodaKupnaWyrazCBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedItemMetodaKupnaWyraz = Convert.ToInt16(MetodaKupnaWyrazCBox.SelectedIndex);
            MetodaKupnaCyfraCBox.SelectedIndex = selectedItemMetodaKupnaWyraz;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearingOptions();
        }

        private void ClearingOptions()
        {
            MetodaKupnaCyfraCBox.SelectedIndex = -1;
            RodzajProdCBox.SelectedIndex = -1;
            CenaZakupuCBox.SelectedIndex = -1;
            CenaSprzedazCBox.SelectedIndex = -1;
            NumerKreskowyTBox.Clear();
            
        }
    }
}
