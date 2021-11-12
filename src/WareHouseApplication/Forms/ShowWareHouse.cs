using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WareHouseApplication.Forms
{
    public partial class ShowWareHouse : Form
    {
        private const string connection = "Data Source=DESKTOP-DQ7DARP\\SQLEXPRESS; Initial Catalog=WareHouse;User ID=; Integrated Security=SSPI;Persist Security Info=False;";

        public ShowWareHouse(MainMenu objMainMenu)
        {
            InitializeComponent();

            ObjMainMenu = objMainMenu;
            ShowAllProducts();
        }

        public MainMenu ObjMainMenu { get; }

        private void ShowWareHouse_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ShowAllProducts()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                //retrieve the SQL Server instance version
                string query = @"SELECT Product.Bar_Number, Product.Description_Product, Product.Quantity, Product.Offer_Price, Product_Type.Product_Type_Description, Purchase_Methods.Purchase_Method_Description
FROM     Product INNER JOIN
                  Product_Type ON Product.Type_Product = Product_Type.Type_Product INNER JOIN
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
                dataGridView1.ColumnCount = 6;
               dataGridView1.Columns[0].HeaderText = "Kod Kreskowy";
                dataGridView1.Columns[0].DataPropertyName = "Bar_Number";
               dataGridView1.Columns[1].HeaderText = "Opis Produktu";
                dataGridView1.Columns[1].DataPropertyName = "Description_Product";

                dataGridView1.Columns[2].HeaderText = "Ilość";
                dataGridView1.Columns[2].DataPropertyName = "Quantity";
                dataGridView1.Columns[3].HeaderText = "Cena sprzedażowa";
                dataGridView1.Columns[3].DataPropertyName = "Offer_Price";
                dataGridView1.Columns[4].HeaderText = "Rodzaj Produktu";
                dataGridView1.Columns[4].DataPropertyName = "Product_Type_Description";
                dataGridView1.Columns[5].HeaderText = "Metoda Zakupu";
                dataGridView1.Columns[5].DataPropertyName = "Purchase_Method_Description";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView1.AllowUserToAddRows = false;
                dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
                dataGridView1.RowHeadersVisible= false;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial",9F,FontStyle.Bold);
                dataGridView1.RowsDefaultCellStyle.Font = new System.Drawing.Font("Arial",8);
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //set the DataGridView control's data source/data table
                dataGridView1.DataSource = ds.Tables[0];
                

                //close connection
                conn.Close();
            }
        }

       
    }
    }
