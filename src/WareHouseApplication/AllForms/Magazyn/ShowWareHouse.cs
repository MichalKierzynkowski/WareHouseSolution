using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace WareHouseApplication.Forms.Magazyn;

public partial class ShowWareHouse : Form
{
    private int? BarNumberInt;
    private string BuyingMethodDescription;


    private string ProductTypeDescription;

    public ShowWareHouse(MainMenu objMainMenu)
    {
        InitializeComponent();
     

        AutoScaleMode = AutoScaleMode.Font;
        ObjMainMenu = objMainMenu;
      
        BarNumberNumeric.Controls[0].Visible = false;
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
        BuyingPriceCBox.SelectedIndex = -1;
        SellingPriceCBox.SelectedIndex = -1;
        BarNumberNumeric.Value = 0;
        AddedAtCBox.SelectedIndex = -1;
        AmountCBox.SelectedIndex = -1;
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

        var prodType = RodzajProduktuWyrazCBox.SelectedItem.ToString();
        var bs = new BindingSource();
        var list = dataGridView1.DataSource;

        bs.DataSource = dataGridView1.DataSource;
      
        bs.Filter = GetFilter();
        dataGridView1.DataSource = null;

        dataGridView1.DataSource = bs;

        
    }

    private void RodzajProdCBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        int selectedItemComboBox2 = Convert.ToInt16(RodzajProdCBox.SelectedIndex);
        RodzajProduktuWyrazCBox.SelectedIndex = selectedItemComboBox2;
        ProductTypeDescription = RodzajProduktuWyrazCBox.SelectedItem.ToString();

        var list = dataGridView1.DataSource;

        var prodType = RodzajProduktuWyrazCBox.SelectedItem.ToString();

        var bs = new BindingSource();
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
        var buyingMethod = MetodaKupnaWyrazCBox.SelectedItem.ToString();
        var bs = new BindingSource();

        bs.DataSource = dataGridView1.DataSource;

 
       
        bs.Filter = GetFilter();
        dataGridView1.DataSource = null;
        dataGridView1.ResetBindings();
        dataGridView1.DataSource = bs;
       
    }

    private void MetodaKupnaWyrazCBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        int selectedItemMetodaKupnaWyraz = Convert.ToInt16(MetodaKupnaWyrazCBox.SelectedIndex);
        MetodaKupnaCyfraCBox.SelectedIndex = selectedItemMetodaKupnaWyraz;
        BuyingMethodDescription = MetodaKupnaWyrazCBox.SelectedItem.ToString();
        var buyingMethod = MetodaKupnaWyrazCBox.SelectedItem.ToString();
        var bs = new BindingSource();


        bs.DataSource = dataGridView1.DataSource;
        dataGridView1.DataSource = null;

   
        bs.Filter = GetFilter();
        dataGridView1.DataSource = null;
        dataGridView1.ResetBindings();
        dataGridView1.DataSource = bs;
    }

    private string GetFilter()
    {
        var parts = new List<string>();
        if (string.IsNullOrWhiteSpace(ProductTypeDescription) == false)
            parts.Add($"ProductTypeDescription like '%{ProductTypeDescription}%'");

        if (string.IsNullOrWhiteSpace(BuyingMethodDescription) == false)
            parts.Add($"PurchaseMethodDescription like '%{BuyingMethodDescription}%'");
        if (BarNumberInt != null) parts.Add($"BarNumber = {BarNumberInt}");


        var stringResult = string.Join(" and ", parts);

        return stringResult;
    }

    private void CenaZakupuCBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var CenaZakupu = BuyingPriceCBox.Text;
        if (CenaZakupu == "Od najmniejszej do największej")
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
        else
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
    }

    private void CenaSprzedazCBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var CenaSprzedazy = SellingPriceCBox.Text;
        if (CenaSprzedazy == "Od najmniejszej do największej")
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
        else
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
    }

    private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var Ilosc = AmountCBox.Text;
        if (Ilosc == "Od najmniejszej do największej")
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        else
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
    }

    private void AddedAtCBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var Ilosc = AddedAtCBox.Text;
        if (Ilosc == "Od najmłodszej do najstarszej")
            dataGridView1.Sort(dataGridView1.Columns[8], ListSortDirection.Ascending);
        else
            dataGridView1.Sort(dataGridView1.Columns[8], ListSortDirection.Descending);
    }
}