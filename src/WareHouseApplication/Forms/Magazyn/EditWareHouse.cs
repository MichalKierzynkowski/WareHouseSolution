using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using WareHouse.Data.SqlModels;

namespace WareHouseApplication.Forms.Magazyn;

public partial class EditWareHouse : Form
{
    private int? BarNumberInt;
    private string BuyingMethodDescription;
    private string ProductTypeDescription;

    public EditWareHouse()
    {
        InitializeComponent();
        
        
        EditButton.Enabled = false;
        SaveChangesButton.Enabled = false;
        DeletButton.Enabled = false;
    }

    
    private SqlDataAdapter DAdapter { get; set; }
    private DataSet Ds { get; set; }
    private SqlCommand Cmd { get; set; }
    private int SelectedRow { get; set; }
    private int? SelecterBarNumber { get; set; }

    

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

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        SelectedRow = e.RowIndex;
        if (SelectedRow >= 0)
        {
            DeletButton.Enabled = true;
            EditButton.Enabled = true;
            SaveChangesButton.Enabled = true;
            var selectedRow = dataGridView1.Rows[SelectedRow];
            OpisProduktuTBox.Text = selectedRow.Cells[0].Value.ToString();

            AmountNumeric.Value = Convert.ToDecimal(selectedRow.Cells[3].Value.ToString());
            BuyPriceNumeric.Value = Convert.ToDecimal(selectedRow.Cells[4].Value.ToString());
            SellPriceNumeric.Value = Convert.ToDecimal(selectedRow.Cells[5].Value.ToString());
            RodzajProduktuWyrazCBox.SelectedItem = selectedRow.Cells[1].Value.ToString();
            MetodaKupnaWyrazCBox.SelectedItem = selectedRow.Cells[2].Value.ToString();
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

    private void EditButton_Click(object sender, EventArgs e)
    {
        if (SelectedRow >= 0)
        {
            var newDataRow = dataGridView1.Rows[SelectedRow];
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
        
    }
}





//public int ReturnNumberOfProductType(string productType)
//{
//    var sqlReturnId = @"select Type_Product from Product_Type where Product_Type_Description=@productType";

//    using (var con = new SqlConnection(ConnectionString))
//    {
//        con.Open();


//        var purchase = con.Query<ProductType>(sqlReturnId,
//            new {productType}).FirstOrDefault();


//        return purchase.Type_Product;
//    }
//}





