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
      dataGridView1.DataSource  = productRepository.GetProducts();
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
        //var validateObj = new IsNullIAddingItemValidation();
        //var rulesValidationObj = new RulesValidationAddingItem();
        //if (validateObj.CheckSingleString(NumerKreskowyTBox.Text))
        //{
        //    MessageBoxFailure();
        //}
        //else
        //{

        //    if (rulesValidationObj.Validation(NumerKreskowyTBox.Text))
        //    {
        //        BarNumberInt = Convert.ToInt32(NumerKreskowyTBox.Text);
        //        BindingSource bs = new BindingSource();
        //        bs.DataSource = dataGridView1.DataSource;


        //        bs.Filter = GetFilter();

        //        dataGridView1.DataSource = bs;
        //    }
        //    else
        //    {
        //        WrongFormatMessageBox();
        //    }


               
        //}
          



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