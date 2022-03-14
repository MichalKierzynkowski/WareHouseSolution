using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using WareHouse.Data.Repository;

namespace WareHouseApplication.Forms.Magazyn;

public partial class ShowWareHouse : Form
{

    private string ProductTypeDescription;
    private string BuyingMethodDescription;     
    private int? BarNumberInt;
    private string IsReturning;
    IProductRepository productRepository;
    public ShowWareHouse(MainMenu objMainMenu)
    {
        InitializeComponent();
        productRepository = new ProductRepository();
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Font;
        ObjMainMenu = objMainMenu;
        StoreProductsInDataGridView();    


    }

    private void StoreProductsInDataGridView()
    {
     
        dataGridView1.ReadOnly = true;
        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.ColumnCount = 9;
        dataGridView1.Columns[0].HeaderText = "Numer Ewidencyjny";
        dataGridView1.Columns[0].DataPropertyName = "BarNumber";
        dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridView1.Columns[1].HeaderText = "Opis Produktu";
        dataGridView1.Columns[1].DataPropertyName = "DescriptionProduct";
        dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridView1.Columns[2].HeaderText = "Ilość";
        dataGridView1.Columns[2].DataPropertyName = "Quantity";
        dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridView1.Columns[3].HeaderText = "Cena Sprzedaży";
        dataGridView1.Columns[3].DataPropertyName = "CurrentSellingPrice";
        dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridView1.Columns[4].HeaderText = "Cena Zakupu";
        dataGridView1.Columns[4].DataPropertyName = "PurchasePrice";
        dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridView1.Columns[5].HeaderText = "Metoda Zakupu";
        dataGridView1.Columns[5].DataPropertyName = "PurchaseMethodDescription";
        dataGridView1.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridView1.Columns[6].HeaderText = "Rodzaj Produktu";
        dataGridView1.Columns[6].DataPropertyName = "ProductTypeDescription";
        dataGridView1.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridView1.Columns[7].HeaderText = "Zwrócony";
        dataGridView1.Columns[7].DataPropertyName = "IsReturned";
        dataGridView1.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridView1.Columns[8].HeaderText = "Data Dodania";
        dataGridView1.Columns[8].DataPropertyName = "AddedAt";
        dataGridView1.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.BackgroundColor = SystemColors.Control;
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
        dataGridView1.RowsDefaultCellStyle.Font = new Font("Arial", 7);
        dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //set the DataGridView control's data source/data table
     
        dataGridView1.AllowUserToResizeColumns = false;
        dataGridView1.AllowUserToResizeRows = false;
        dataGridView1.Columns[0].Width = 75;
        dataGridView1.Columns[1].Width = 150;
        dataGridView1.Columns[2].Width = 75;
        dataGridView1.DataSource = productRepository.GetProducts();

    }

    public MainMenu ObjMainMenu { get; }



   

    private void RodzajProdCBox_SelectedValueChanged(object sender, EventArgs e)
    {
        int selectedItemComboBox2 = Convert.ToInt16(RodzajProdCBox.SelectedIndex);
        RodzajProduktuWyrazCBox.SelectedIndex = selectedItemComboBox2;


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
       
    }

   

    private void SzukajButton_Click(object sender, EventArgs e)
    {
       
          



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