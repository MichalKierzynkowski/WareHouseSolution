using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using WareHouse.Data.Repository;
using WareHouse.Data.SqlModels;
using WareHouse.Domain.ProductDto;
using WareHouse.Logic.ShowWareHouseClasses.Converter;

namespace WareHouseApplication.Forms.Magazyn;

public partial class EditWareHouse : Form
{
    private int? BarNumberInt;
    private string BuyingMethodDescription;
    private string ProductTypeDescription; 
    private int SelectedRow { get; set; } 
    private int? SelecterBarNumber { get; set; }
    private readonly IProductRepository productRepository;

    public EditWareHouse()
    {
        InitializeComponent();
        productRepository = new ProductRepository();
        TurnOffButtons();
        HidingArrowsInNumerics();
       StoreProductsInDataGridView(productRepository.GetProducts());
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

        var productDataSet = product.ToDataSet();
        dataGridView1.DataSource = productDataSet.Tables[0];
    }

    public void HidingArrowsInNumerics()
    {
        AmountNumeric.Controls[0].Visible = false;
        BuyPriceNumeric.Controls[0].Visible = false;
        SellPriceNumeric.Controls[0].Visible = false;
       
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

  
}










