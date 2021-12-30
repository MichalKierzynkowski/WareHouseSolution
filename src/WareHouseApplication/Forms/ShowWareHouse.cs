using ClassesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ClassesLibrary.ValidationClasses;

namespace WareHouseApplication.Forms
{
    public partial class ShowWareHouse : Form
    {

        private string ProductTypeDescription;
        private string BuyingMethodDescription;
        
        private int? BarNumberInt;
        private string IsReturning;

        public ShowWareHouse(MainMenu objMainMenu, string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Font;
            ObjMainMenu = objMainMenu;
            DefaultFillingGridView();
            ObjValidationAddingItem = new RulesValidationAddingItem();


        }

        public RulesValidationAddingItem ObjValidationAddingItem { get; set; }
        public string connectionString { get; set; }

        public MainMenu ObjMainMenu { get; }



        private void ShowSpecificProducts(string query, string queryItem)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            using (var conn = new SqlConnection(connectionString))
            {



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
            RodzajProduktuWyrazCBox.SelectedIndex = selectedItemComboBox2;






        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {






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
            DefaultFillingGridView();
            ProductTypeDescription = string.Empty;
            BuyingMethodDescription = string.Empty;
            BarNumberInt = null;
        }

        private void ClearingOptions()
        {
            MetodaKupnaCyfraCBox.SelectedIndex = -1;
            RodzajProdCBox.SelectedIndex = -1;
            CenaZakupuCBox.SelectedIndex = -1;
            CenaSprzedazCBox.SelectedIndex = -1;
            NumerKreskowyTBox.Clear();
            IsReturnedComboBox.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var objAlert = new Alert.Alert(dataGridView1);
            objAlert.Show();
            // SavingProductsExcel();
        }

        private void DefaultFillingGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            using (var conn = new SqlConnection(connectionString))
            {
                //retrieve the SQL Server instance version
                var query =
                    @"SELECT   Product.Bar_Number,Product.IsReturned, Product.Description_Product, Product.Purchase_Method, Product.Quantity, Product.Offer_Price, Product_Type.Product_Type_Description, Purchase.Price, Purchase_Methods.Purchase_Method_Description
FROM      Product INNER JOIN
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
                dataGridView1.ColumnCount = 8;
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
                dataGridView1.Columns[7].HeaderText = "Towar Zwrócony";
                dataGridView1.Columns[7].DataPropertyName = "IsReturned";
                dataGridView1.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;


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
                dataGridView1.Columns[0].Width = 75;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 75;
                //dataGridView1.Columns[]
                //close connection
                conn.Close();
            }
        }

        private void SzukajButton_Click(object sender, EventArgs e)
        {
            /*
            BarNumber = NumerKreskowyTBox.Text.ToString();

            bool isCorrect=ObjValidationAddingItem.ShowHouseBarNumberValidation(BarNumber);

            if(isCorrect==false)
            {
                string message = "Pole Kod Kreskowy jest puste lub źle wypełnione!";
                string title = "Błąd!";
                MessageBox.Show(message, title,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                BarNumber = string.Empty;
            }
            else
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;


                bs.Filter = GetFilter();

                dataGridView1.DataSource = bs;

            }
            */
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

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedItemComboBox3 = Convert.ToInt16(RodzajProduktuWyrazCBox.SelectedIndex);
            RodzajProdCBox.SelectedIndex = selectedItemComboBox3;
            ProductTypeDescription = RodzajProduktuWyrazCBox.SelectedItem.ToString();

            string prodType = RodzajProduktuWyrazCBox.SelectedItem.ToString();
            BindingSource bs = new BindingSource();
            var list = dataGridView1.DataSource;

            bs.DataSource = dataGridView1.DataSource;
            // bs.Filter = "Product_Type_Description like '%" + prodType + "%'";
            bs.Filter = GetFilter();
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = bs;

            var list2 = dataGridView1.DataSource;




        }

        private void RodzajProdCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedItemComboBox2 = Convert.ToInt16(RodzajProdCBox.SelectedIndex);
            RodzajProduktuWyrazCBox.SelectedIndex = selectedItemComboBox2;
            ProductTypeDescription = RodzajProduktuWyrazCBox.SelectedItem.ToString();

            var list = dataGridView1.DataSource;

            string prodType = RodzajProduktuWyrazCBox.SelectedItem.ToString();

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;

           
            bs.Filter = GetFilter();

            dataGridView1.DataSource = bs;
           

        }

        private void MetodaKupnaCyfraCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedItemMetodaKupnaCyfra = Convert.ToInt16(MetodaKupnaCyfraCBox.SelectedIndex);
            MetodaKupnaWyrazCBox.SelectedIndex = selectedItemMetodaKupnaCyfra;
            var list = dataGridView1.DataSource;

            BuyingMethodDescription = MetodaKupnaWyrazCBox.SelectedItem.ToString();
            string buyingMethod = MetodaKupnaWyrazCBox.SelectedItem.ToString();
            BindingSource bs = new BindingSource();

            bs.DataSource = dataGridView1.DataSource;


            //bs.Filter = "Purchase_Method_Description like '%" + buyingMethod + "%'";
            bs.Filter = GetFilter();
            dataGridView1.DataSource = null;
            dataGridView1.ResetBindings();
            dataGridView1.DataSource = bs;
            var list2 = dataGridView1.DataSource;



        }

        private void MetodaKupnaWyrazCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedItemMetodaKupnaWyraz = Convert.ToInt16(MetodaKupnaWyrazCBox.SelectedIndex);
            MetodaKupnaCyfraCBox.SelectedIndex = selectedItemMetodaKupnaWyraz;
            BuyingMethodDescription = MetodaKupnaWyrazCBox.SelectedItem.ToString();
            string buyingMethod = MetodaKupnaWyrazCBox.SelectedItem.ToString();
            BindingSource bs = new BindingSource();
          



            bs.DataSource = dataGridView1.DataSource;
            dataGridView1.DataSource = null;

            // bs.Filter = "Purchase_Method_Description like '%" + buyingMethod+ "%'";
            bs.Filter = GetFilter();
            dataGridView1.DataSource = null;
            dataGridView1.ResetBindings();
            dataGridView1.DataSource = bs;
           

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
            if (string.IsNullOrWhiteSpace(IsReturning)==false)
            {
                parts.Add($"IsReturned like '%{IsReturning}%'");
            }





            var stringResult = string.Join(" and ", parts);

            return stringResult;

        }

        private void CenaZakupuCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string CenaZakupu = CenaZakupuCBox.Text.ToString();
            if (CenaZakupu == "Od najmniejszej do największej")
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            }
            else
             {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            }







        }

        private void CenaSprzedazCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            string CenaSprzedazy =CenaSprzedazCBox.Text.ToString();
            if (CenaSprzedazy == "Od najmniejszej do największej")
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
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

        private void IsReturnedComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            IsReturning = IsReturnedComboBox.SelectedItem.ToString();



            bs.DataSource = dataGridView1.DataSource;
            dataGridView1.DataSource = null;

            // bs.Filter = "Purchase_Method_Description like '%" + buyingMethod+ "%'";
            bs.Filter = GetFilter();
            dataGridView1.DataSource = null;
            dataGridView1.ResetBindings();
            dataGridView1.DataSource = bs;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Ilosc= comboBox1.Text.ToString();
            if (Ilosc == "Od najmniejszej do największej")
            {
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
            }
        }
    }
}