using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WareHouseApplication.Forms.Magazyn;

public partial class EditWareHouse : Form
{
    private int? BarNumberInt;
    private string BuyingMethodDescription;
    private string ProductTypeDescription; 
    private int SelectedRow { get; set; } 
    private int? SelecterBarNumber { get; set; }


    public EditWareHouse()
    {
        InitializeComponent();
      
        TurnOffButtons();
        HidingArrowsInNumerics();
  
    }



   

    public void HidingArrowsInNumerics()
    {
        AmountNumeric.Controls[0].Visible = false;
        BuyPriceNumeric.Controls[0].Visible = false;
        SellPriceNumeric.Controls[0].Visible = false;
        BarNumberNumeric.Controls[0].Visible=false;

    }

    public void TurnOffButtons()
    {
        EditButton.Enabled = false;
        SaveChangesButton.Enabled = false;
        DeletButton.Enabled = false;
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

    private void RodzajProdSortowanieCyfraCBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        int selectedItemComboBox2 = Convert.ToInt16(ProductTypeIdNumberCBox.SelectedIndex);
        ProductTypeSortWordBox.SelectedIndex = selectedItemComboBox2;
        ProductTypeDescription = ProductTypeSortWordBox.SelectedItem.ToString();

        var list = dataGridView1.DataSource;

        var prodType = ProductTypeSortWordBox.SelectedItem.ToString();

        var bs = new BindingSource();
        bs.DataSource = dataGridView1.DataSource;


        bs.Filter = GetFilter();

        dataGridView1.DataSource = bs;
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
        ProductTypeIdNumberCBox.SelectedIndex = -1;
        ProductTypeSortWordBox.SelectedIndex = -1;
        BuyMethodIdNumberBox.SelectedIndex = -1;
        BuyMethodWordBox.SelectedIndex = -1;
        BarNumberNumeric.Value = 0;
        //StoreProductsInDataGridView(productRepository.GetProducts());
    }

    private void SortingButton_Click(object sender, EventArgs e)
    {
       

       
      
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
            ProductDescriptionTBox.Text = selectedRow.Cells[0].Value.ToString();

            AmountNumeric.Value = Convert.ToDecimal(selectedRow.Cells[3].Value.ToString());
            BuyPriceNumeric.Value = Convert.ToDecimal(selectedRow.Cells[4].Value.ToString());
            SellPriceNumeric.Value = Convert.ToDecimal(selectedRow.Cells[5].Value.ToString());
            ProductTypeWordCBox.SelectedItem = selectedRow.Cells[1].Value.ToString();
            BuyMethodWordCBox.SelectedItem = selectedRow.Cells[2].Value.ToString();
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
            newDataRow.Cells[0].Value = ProductDescriptionTBox.Text;
            newDataRow.Cells[1].Value = ProductTypeWordCBox.Text;
            newDataRow.Cells[2].Value = BuyMethodWordCBox.Text;
            newDataRow.Cells[3].Value = AmountNumeric.Value;
            newDataRow.Cells[4].Value = BuyPriceNumeric.Value;
            newDataRow.Cells[5].Value = SellPriceNumeric.Value;
        }
        else
        {
            WrongRowSelected();
        }
    }

    private void ProductTypeSortWordBox_SelectionChangeCommitted(object sender, EventArgs e)
    {

        int selectedItemComboBox3 = Convert.ToInt16(ProductTypeSortWordBox.SelectedIndex);
        ProductTypeIdNumberCBox.SelectedIndex = selectedItemComboBox3;
        ProductTypeDescription = ProductTypeSortWordBox.SelectedItem.ToString();

        var prodType = ProductTypeSortWordBox.SelectedItem.ToString();
        var bs = new BindingSource();
        var list = dataGridView1.DataSource;

        bs.DataSource = dataGridView1.DataSource;

        bs.Filter = GetFilter();
        dataGridView1.DataSource = null;

        dataGridView1.DataSource = bs;
    }
}










