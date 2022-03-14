using ClassesLibrary.AddItemClasses.Validation;
using ClassesLibrary.AddItemClasses.Validation.ValidationModels;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using WareHouse.Data.Repository;
using WareHouse.Domain.ProductDto;
using WareHouse.Logic.AddItemClasses.Validation;
using WareHouse.Logic.ShowWareHouseClasses.Converter;
using WareHouse.Logic.ShowWareHouseClasses.Validation;

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
      
        AutoScaleMode = AutoScaleMode.Font;
        ObjMainMenu = objMainMenu;
        StoreProductsInDataGridView(productRepository.GetProducts());
        BarNumberNumeric.Controls[0].Visible = false;

    }

    private void StoreProductsInDataGridView(IEnumerable<ShowAllProductsDto> product)
    {
        


        dataGridView1.DataSource = null;
        dataGridView1.Rows.Clear();

     
        

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
        dataGridView1.AllowUserToResizeColumns = false;
        dataGridView1.AllowUserToResizeRows = false;

        var productDataSet = ConvertListToDataSet.ToDataSet(product);
        dataGridView1.DataSource = productDataSet.Tables[0];



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
        StoreProductsInDataGridView(productRepository.GetProducts());
    }

    private void ClearingOptions()
    {
        MetodaKupnaCyfraCBox.SelectedIndex = -1;
        RodzajProdCBox.SelectedIndex = -1;
        BuyingPriceCBox.SelectedIndex = -1;
        SellingPriceCBox.SelectedIndex = -1;
        BarNumberNumeric.Value = 0;
        IsReturnedComboBox.SelectedIndex = -1;
        AmountCBox.SelectedIndex = -1;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        var objAlert = new Alert.Alert(dataGridView1);
        objAlert.Show();
       
    }

   

    private void SzukajButton_Click(object sender, EventArgs e)
    {

        var barNumberObj = new BarNumberModel()
        {
            BarNumber = BarNumberNumeric.Value
        };

        
        ShowProductsFromBarNumberValidation validationbarNumber = new ShowProductsFromBarNumberValidation(barNumberObj);
        var result = validationbarNumber.ReturnValidatingResult();

        if (!result.IsValid)
        {
            MessageBox.Show(string.Join("\n", result.Errors), "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {

            StoreProductsInDataGridView(productRepository.ReturnProductsById(barNumberObj.BarNumber));
            
            
           
         

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
            parts.Add($"ProductTypeDescription like '%{ProductTypeDescription}%'");
        }

        if (string.IsNullOrWhiteSpace(BuyingMethodDescription) == false)
        {
            parts.Add($"PurchaseMethodDescription like '%{BuyingMethodDescription}%'");
        }
        if (BarNumberInt != null)
        {

            parts.Add($"BarNumber = {BarNumberInt}");
              

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
        string CenaZakupu = BuyingPriceCBox.Text.ToString();
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

        string CenaSprzedazy =SellingPriceCBox.Text.ToString();
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
        string Ilosc= AmountCBox.Text.ToString();
        if (Ilosc == "Od najmniejszej do największej")
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }
        else
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
        }
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void BuyingPriceCBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}