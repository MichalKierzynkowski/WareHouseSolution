using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClassesLibrary.AddItemClasses.Validation;
using Dapper;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using WareHouse.Data.SqlModels;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace WareHouseApplication.Forms.Magazyn;

public partial class AddItemFormcs : Form
{
    public string ConnectionString { get; set; }
  
    public AddItemFormcs(MainMenu objMainMenu,string connectionString)
    {
        InitializeComponent();
        ObjMainMenu = objMainMenu;
       HidingArrowsInNumerics();
       ConnectionString = connectionString;

    }

    public MainMenu ObjMainMenu { get; }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        var dialogResult =
            MessageBox.Show("Czy chcesz wrócić do głównego Menu? Wszystkie nie zapisane dane zostaną stracone!",
                "Wyjście!", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes) Hide();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var dialogResult =
            MessageBox.Show(
                "Czy chcesz wrócić do głównego Menu?" + Environment.NewLine +
                " Wszystkie nie zapisane dane zostaną stracone!", "Wyjście!", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes) Hide();
    }

    private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
    {
        int selectedItemComboBox2 = Convert.ToInt16(ProductTypeDigitCBox.SelectedIndex);
        ProductTypeWordCBox.SelectedIndex = selectedItemComboBox2;
    }

    private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
    {
        int selectedItemComboBox3 = Convert.ToInt16(ProductTypeWordCBox.SelectedIndex);
        ProductTypeDigitCBox.SelectedIndex = selectedItemComboBox3;
    }

       

    private void MetodaKupnaCyfraCBox_SelectedValueChanged(object sender, EventArgs e)
    {
        int selectedItemMetodaKupnaCyfra = Convert.ToInt16(BuyMethodDigitCBox.SelectedIndex);
        BuyMethodWordCBox.SelectedIndex = selectedItemMetodaKupnaCyfra;
    }

    private void MetodaKupnaWyrazCBox_SelectedValueChanged(object sender, EventArgs e)
    {
        int selectedItemMetodaKupnaWyraz = Convert.ToInt16(BuyMethodWordCBox.SelectedIndex);
        BuyMethodDigitCBox.SelectedIndex = selectedItemMetodaKupnaWyraz;
    }

    public void DostepnoscButton_Click(object sender, EventArgs e)
    {
        var validateObj = new BarNumberValidation(ConnectionString,BarNumberTBox.Value);

    }

    public void HidingArrowsInNumerics()
    {
        SellPriceNumeric.Controls[0].Visible = false;
        OfferPriceNumeric.Controls[0].Visible = false;
        AmountOfProductTBox.Controls[0].Visible = false;
        BarNumberTBox.Controls[0].Visible = false;
    }
    private void ClearingMenu()
    {
        BarNumberTBox.Value = 0;
        SellPriceNumeric.Value = 0;
        OfferPriceNumeric.Value = 0;
        AmountOfProductTBox.Value = 0;
       
        ProductDescriptionTBox.Clear();
        
        BuyMethodDigitCBox.SelectedIndex = -1;
        ProductTypeDigitCBox.SelectedIndex = -1;
    }

   

    private void CreatingProduct()
    {
        var Type_Product = ProductTypeDigitCBox.Text;
        var Bar_Number = BarNumberTBox.Text;
        var Description = ProductDescriptionTBox.Text;
        var Purchase_Method = BuyMethodDigitCBox.Text;
        var Quantity = AmountOfProductTBox.Text;
        //var OfferPrice = SellPriceTBox.Text;

        string insertSql = @"INSERT INTO Product (Type_Product,Bar_Number,Description_Product,Purchase_Method,Quantity,Offer_Price,IsReturned) Values (@Type_Product,@Bar_Number,@Description,@Purchase_Method,@Quantity,@OfferPrice,'Nie');";

        SqlConnection cnn = new SqlConnection(ConnectionString);
        SqlCommand cmd = new SqlCommand(insertSql, cnn);

        cmd.Parameters.AddWithValue("@Type_Product", Type_Product);
        cmd.Parameters.AddWithValue("@Bar_Number", Bar_Number);
        cmd.Parameters.AddWithValue("@Description", Description);
        cmd.Parameters.AddWithValue("@Purchase_Method", Purchase_Method);
        cmd.Parameters.AddWithValue("@Quantity", Quantity);
      //  cmd.Parameters.AddWithValue("@OfferPrice", Convert.ToDouble(OfferPrice));
        cnn.Open();
        cmd.ExecuteNonQuery();
        cnn.Close();
    }

    private void CreatingPurchase()
    {
        var Bar_Number = BarNumberTBox.Text;
        var Quantity = AmountOfProductTBox.Text;
        //var BuyingPrice = BuyPriceTBox.Text;
       
        string From_Product_Create = "Tak";
        SqlConnection cnn2 = new SqlConnection(ConnectionString);
        DateTime Date_Purchase = DateTime.Now;
        var querySqlPurchase = @"Insert Into Purchase (Id_Product,Date_Purchase,Amount,Price,From_Product_Create) values(@Id_Product,@Date_Purchase,@Quantity,@BuyingPrice,@From_Product_Create)";
        SqlCommand cmdPurchase = new SqlCommand(querySqlPurchase, cnn2);
        
        cmdPurchase.Parameters.AddWithValue("@Date_Purchase", Date_Purchase);
        cmdPurchase.Parameters.AddWithValue("@Quantity", Quantity);
       // cmdPurchase.Parameters.AddWithValue("@BuyingPrice", Convert.ToDouble(BuyingPrice));
        cmdPurchase.Parameters.AddWithValue("@From_Product_Create",From_Product_Create);


        cnn2.Open();
        cmdPurchase.ExecuteNonQuery();
        cnn2.Close();
    }

   

    private void SuccessfullyProductAdded()
    {
        ClearingMenu();
        MessageBox.Show(

            "Pomyślnie dodano nowy produkt!", "Sukces!",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
   
    

    private void AddProductButton_Click(object sender, EventArgs e)
    {
        Guid idProductGuid = Guid.NewGuid();
        var product = new Product()
        {
            IdProduct = idProductGuid,
            DescriptionProduct = ProductDescriptionTBox.Text,
            IdTypeProduct = ProductTypeDigitCBox.Text,
            BarNumber = (int)BarNumberTBox.Value,
            OfferPrice = OfferPriceNumeric.Value,
            IsReturned = false,
            Quantity = (int)AmountOfProductTBox.Value,
            IdPurchaseMethod = BuyMethodDigitCBox.Text,
            Purchase = new Purchase
            {
                Amount = (int)AmountOfProductTBox.Value,
                DatePurchase = DateTime.UtcNow.Date,
                Price=SellPriceNumeric.Value,
               IdPurchase = Guid.NewGuid(),
               IdProduct = idProductGuid
            }
        };



        var result = ValidateAddProduct(product);
        if (!result.IsValid)
        {

            MessageBox.Show(string.Join("\n", result.Errors),"Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
      

        }
        else
        {
                SuccessfullyProductAdded();
        }

    }

    private  ValidationResult ValidateAddProduct(Product product)
    {
        AddProductAndPurchaseValidate addProductValidate = new AddProductAndPurchaseValidate();
        var result = addProductValidate.Validate(product);
        return result;

    }
}