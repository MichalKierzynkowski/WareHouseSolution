using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WareHouseApplication.Forms.Sale;

public partial class AddSale : Form
{

    private DataSet Ds { get; set; }
    
    public string ConnectionString { get; }
    private int? BarNumberInt;
    private string BuyingMethodDescription;
    private string ProductTypeDescription;
    private int SelectedRow { get; set; }
    private int? SelecterBarNumber { get; set; }

    public AddSale()
    {
        InitializeComponent();

       
        SellItemButton.Enabled = false;

    }
  
      
    
    public void ResetSortingFields()
    {
        RodzajProdSortowanieCyfraCBox.SelectedIndex = -1;
        RodzajProdSortowanieWyrazCBox.SelectedIndex = -1;
        MetodaZakupuCyfraCBox.SelectedIndex = -1;
        MetodaZakupuWyrazCBox.SelectedIndex = -1;
        NumerKreskowyTBox.Clear();
    }
    private void ResetButton_Click(object sender, EventArgs e)
    {
       
        ResetSortingFields();
    }

    private void SortingButton_Click(object sender, EventArgs e)
    {
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
        //        var bs = new BindingSource();
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
    private void MessageBoxFailure()
    {
        MessageBox.Show("Nie wypełniono pola - Kod Kreskowy!", " Błąd", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
    }

    private void WrongFormatMessageBox()
    {
        MessageBox.Show("Pole Kod Kreskowy zawiera niepoprawne znaki!", " Błąd", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
    }
    private string GetFilter()
    {
        var parts = new List<string>();
        if (string.IsNullOrWhiteSpace(ProductTypeDescription) == false)
            parts.Add($"Product_Type_Description like '%{ProductTypeDescription}%'");

        if (string.IsNullOrWhiteSpace(BuyingMethodDescription) == false)
            parts.Add($"Purchase_Method_Description like '%{BuyingMethodDescription}%'");
        if (BarNumberInt != null) parts.Add($"Bar_Number = {BarNumberInt}");


        var stringResult = string.Join(" and ", parts);

        return stringResult;
    }

    private void RodzajProdSortowanieCyfraCBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        int selectedItemComboBox2 = Convert.ToInt16(RodzajProdSortowanieCyfraCBox.SelectedIndex);
        RodzajProdSortowanieWyrazCBox.SelectedIndex = selectedItemComboBox2;
        ProductTypeDescription = RodzajProdSortowanieWyrazCBox.SelectedItem.ToString();

        var list = dataGridView1.DataSource;

        var prodType = RodzajProdSortowanieWyrazCBox.SelectedItem.ToString();

        var bs = new BindingSource();
        bs.DataSource = dataGridView1.DataSource;


        bs.Filter = GetFilter();

        dataGridView1.DataSource = bs;
    }

    private void RodzajProdSortowanieWyrazCBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        int selectedItemComboBox3 = Convert.ToInt16(RodzajProdSortowanieWyrazCBox.SelectedIndex);
        RodzajProdSortowanieCyfraCBox.SelectedIndex = selectedItemComboBox3;
        ProductTypeDescription = RodzajProdSortowanieWyrazCBox.SelectedItem.ToString();

        var prodType = RodzajProdSortowanieWyrazCBox.SelectedItem.ToString();
        var bs = new BindingSource();
        var list = dataGridView1.DataSource;

        bs.DataSource = dataGridView1.DataSource;
        // bs.Filter = "Product_Type_Description like '%" + prodType + "%'";
        bs.Filter = GetFilter();
        dataGridView1.DataSource = null;

        dataGridView1.DataSource = bs;


    }

    private void MetodaZakupuCyfraCBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        int selectedItemMetodaKupnaCyfra = Convert.ToInt16(MetodaZakupuCyfraCBox.SelectedIndex);
        MetodaZakupuWyrazCBox.SelectedIndex = selectedItemMetodaKupnaCyfra;
        var list = dataGridView1.DataSource;

        BuyingMethodDescription = MetodaZakupuWyrazCBox.SelectedItem.ToString();
        var buyingMethod = MetodaZakupuWyrazCBox.SelectedItem.ToString();
        var bs = new BindingSource();

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
        var buyingMethod = MetodaZakupuWyrazCBox.SelectedItem.ToString();
        var bs = new BindingSource();


        bs.DataSource = dataGridView1.DataSource;
        dataGridView1.DataSource = null;

        // bs.Filter = "Purchase_Method_Description like '%" + buyingMethod+ "%'";
        bs.Filter = GetFilter();
        dataGridView1.DataSource = null;
        dataGridView1.ResetBindings();
        dataGridView1.DataSource = bs;
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        SelectedRow = e.RowIndex;
        if (SelectedRow >= 0)
        {
            SellItemButton.Enabled = true;

            var selectedRow = dataGridView1.Rows[SelectedRow];
            OpisProduktuTBox.Text = selectedRow.Cells[0].Value.ToString();


            BuyPriceBox.Text = selectedRow.Cells[4].Value.ToString();
            SellPriceBox.Text = selectedRow.Cells[5].Value.ToString();
            RodzajProduktuWyrazCBox.SelectedItem = selectedRow.Cells[1].Value.ToString();

            SelecterBarNumber = Convert.ToInt32(selectedRow.Cells[6].Value.ToString());
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

    private void button2_Click(object sender, EventArgs e)
    {
        this.Hide();
    }
}