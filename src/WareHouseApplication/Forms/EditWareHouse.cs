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
using ClassesLibrary.SqlModels;
using Dapper;
using Dapper.Transaction;
using Microsoft.EntityFrameworkCore.Update;

namespace WareHouseApplication.Forms
{
    public partial class EditWareHouse : Form
    {
        public string ConnectionString { get; set; }
        private string ProductTypeDescription;
        private string BuyingMethodDescription;
        private SqlDataAdapter DAdapter { get; set; }
        private DataSet Ds { get; set; }
        private SqlCommand Cmd { get; set; }
        private int? BarNumberInt;
        private int SelectedRow { get; set; }
        public EditWareHouse(string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;
            DefaultFillingGridView();
            EditButton.Enabled = false;
            SaveChangesButton.Enabled = false;
            DeletButton.Enabled = false;
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
                  Purchase_Methods ON Product.Purchase_Method = Purchase_Methods.Purchase_Method
				  where Purchase.From_Product_Create='Tak'";


                //define the SqlCommand object
                Cmd = new SqlCommand(query, conn);

                //Set the SqlDataAdapter object
                 DAdapter = new SqlDataAdapter(Cmd);

                //define dataset
                Ds = new DataSet();

                //fill dataset with query results
                DAdapter.Fill(Ds);

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
                dataGridView1.DataSource = Ds.Tables[0];
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.AllowUserToResizeRows = false;
                
                dataGridView1.Columns[3].Width = 70;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 130;
                dataGridView1.Columns[6].Width = 100;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
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
           

        }

        private void MetodaZakupuCyfraCBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void MetodaZakupuWyrazCBox_SelectedValueChanged(object sender, EventArgs e)
        {
          
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (SelectedRow>=0)
            {
                DeletButton.Enabled = true;
                EditButton.Enabled = true;
                SaveChangesButton.Enabled = true;
                DataGridViewRow selectedRow = dataGridView1.Rows[SelectedRow];
                OpisProduktuTBox.Text = selectedRow.Cells[0].Value.ToString();

                AmountNumeric.Value = Convert.ToDecimal(selectedRow.Cells[3].Value.ToString());
                BuyPriceNumeric.Value = Convert.ToDecimal(selectedRow.Cells[4].Value.ToString());
                SellPriceNumeric.Value = Convert.ToDecimal(selectedRow.Cells[5].Value.ToString());
                RodzajProduktuWyrazCBox.SelectedItem = selectedRow.Cells[1].Value.ToString();
                MetodaKupnaWyrazCBox.SelectedItem = selectedRow.Cells[2].Value.ToString();
            }
            else
            {
                WrongRowSelected();
            }
           
          
           

        }
        private void WrongRowSelected()
        {
            MessageBox.Show("Zły obszar!", " Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {



            if (SelectedRow>=0)
            {
                DataGridViewRow newDataRow = dataGridView1.Rows[SelectedRow];
                newDataRow.Cells[0].Value = OpisProduktuTBox.Text;
                newDataRow.Cells[1].Value = RodzajProduktuWyrazCBox.Text;
                newDataRow.Cells[2].Value = MetodaKupnaWyrazCBox.Text;
                newDataRow.Cells[3].Value = AmountNumeric.Value;
                newDataRow.Cells[4].Value = BuyPriceNumeric.Value;
                newDataRow.Cells[5].Value = SellPriceNumeric.Value;

            }
            else
            {
                WrongRowSelected();
            }

           
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            string updateDescription =
                "Update Product set Description_Product=@Description_Product where Bar_Number=@Bar_Number";
            string updateProductType = "Update Product set Type_Product=@Type_Product where Bar_Number=@Bar_Number";
            string updateBuyMethod = "Update Product set Purchase_Method=@Purchase_Method where Bar_Number=@Bar_Number ";
            string updateAmountProduct="Update Product set Quantity=@Quantity where Bar_Number=@Bar_Number";
            string updateAmountPurchase = "Update Purchase set Amount=@Amount where Id_Product =@idProduct and From_Product_Create ='Tak'";


            DialogResult dialogResult = MessageBox.Show("Czy jesteś pewny edycji?", "Wyjście!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                for (int i = 0; i <=dataGridView1.Rows.Count-1; i++)
                {
                    int idProduct = ReturIdProduct((int)dataGridView1.Rows[i].Cells[6].Value);
                    int productTypeId = ReturnNumberOfProductType((string)dataGridView1.Rows[i].Cells[1].Value);
                    int buyMethodId = ReturnBuyMethodId((string)dataGridView1.Rows[i].Cells[2].Value);

                    SqlConnection cnn = new SqlConnection(ConnectionString);
                    ////////////////update kolumny Description
                    SqlCommand cmd2 = new SqlCommand(updateDescription,cnn);
                    cmd2.Parameters.AddWithValue("@Description_Product", dataGridView1.Rows[i].Cells[0].Value);
                    cmd2.Parameters.AddWithValue("@Bar_Number", dataGridView1.Rows[i].Cells[6].Value);
                    cnn.Open();
                    cmd2.ExecuteNonQuery();
                    cnn.Close();

                    //////////////////////////////////////
                    ////////////Update kolumny Rodzaj Produktu
                  
                    SqlCommand cmd3 = new SqlCommand(updateProductType, cnn);
                    cnn.Open();
                    cmd3.Parameters.AddWithValue("@Type_Product", productTypeId);
                    cmd3.Parameters.AddWithValue("@Bar_Number", dataGridView1.Rows[i].Cells[6].Value);
                    cmd3.ExecuteNonQuery();
                    cnn.Close();
                    //////////////////////////////////////////////////////////////////////////
                    //////////////Update Kolumny Metoda Zakupu
                    SqlCommand cmd4 = new SqlCommand(updateBuyMethod, cnn);
                    cnn.Open();
                    cmd4.Parameters.AddWithValue("@Purchase_Method", buyMethodId);
                    cmd4.Parameters.AddWithValue("@Bar_Number", dataGridView1.Rows[i].Cells[6].Value);
                    cmd4.ExecuteNonQuery();
                    cnn.Close();
                    /////////////////////////////////////////////////
                    //////////////Update Ilosc
                    SqlCommand cmd5 = new SqlCommand(updateAmountProduct, cnn);
                    SqlCommand cmd6 = new SqlCommand(updateAmountPurchase, cnn);
                    cnn.Open();
                    cmd5.Parameters.AddWithValue("@Quantity", (int)AmountNumeric.Value);
                    cmd5.Parameters.AddWithValue("@Bar_Number", dataGridView1.Rows[i].Cells[6].Value);
                    cmd5.ExecuteNonQuery();
                    cmd6.Parameters.AddWithValue("@Amount", (int)AmountNumeric.Value);
                    cmd6.Parameters.AddWithValue("@Bar_Number", dataGridView1.Rows[i].Cells[6].Value);
                    cmd6.ExecuteNonQuery();





                    cnn.Close();


                }
                SuccessfullyChangesCommit();
                DefaultFillingGridView();
                ResetSortingFields();
            }
            
        }

        private int ReturnBuyMethodId(string buyMethod)
        {
            string sqlReturnId = @"select Purchase_Method from Purchase_Methods where Purchase_Method_Description=@buyMethod";

            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();


                var purchaseMethods = con.Query<Purchase_Methods>(sqlReturnId,
                    new { buyMethod }).FirstOrDefault();


                return purchaseMethods.Purchase_Method;
            }

        }

        private void SuccessfullyChangesCommit()
        {
            MessageBox.Show("Edycja przeprowadzona pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public int ReturIdProduct(int productBarNumber)
        {
            string sqlReturnId = @"select Id_Product from Product where Bar_Number=@productBarNumber";

            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();

               
                var product = con.Query<Product>(sqlReturnId,
                    new { productBarNumber }).FirstOrDefault();
               

                return product.Id_Product;
            }



        }

        public int ReturnNumberOfProductType(string productType )
        {

            string sqlReturnId = @"select Type_Product from Product_Type where Product_Type_Description=@productType";

            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();


                var purchase = con.Query<Product_Type>(sqlReturnId,
                    new { productType }).FirstOrDefault();


                return purchase.Type_Product;
            }

        }

        
    }
}
