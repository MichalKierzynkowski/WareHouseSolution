using ClassesLibrary.AddItemClasses.Queries;
using ClassesLibrary.AddItemClasses.Validation.ValidationModels;
using System;
using System.Windows.Forms;
using WareHouse.Data.SqlModels;
using WareHouse.Logic.AddItemClasses.Validation;

namespace WareHouseApplication.Forms.Magazyn;

public partial class AddItemFormcs : Form
{

    private CreateProductAndPurchase _createProductAndPurchase { get; set; }
    public AddItemFormcs(MainMenu objMainMenu)
    {
        InitializeComponent();
        ObjMainMenu = objMainMenu;
        HidingArrowsInNumerics();



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
        var barNumberObj = new BarNumberModel()
        {
            BarNumber = BarNumberTBox.Value
        };

        ValidationBarNumber validationBarNumber = new ValidationBarNumber(barNumberObj);
        var result = validationBarNumber.ReturnValidatingResult();
        if (!result.IsValid)
        {
            MessageBox.Show(string.Join("\n", result.Errors), "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            MessageBox.Show("Podany numer kodu kreskowego nie jest przypisany do żadnego produktu!", "Informacja",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }


    public void HidingArrowsInNumerics()
    {
        CurrentSellingPriceBox.Controls[0].Visible = false;
        PurchasePriceBox.Controls[0].Visible = false;
        AmountOfProductTBox.Controls[0].Visible = false;
        BarNumberTBox.Controls[0].Visible = false;
    }
    private void ClearingMenu()
    {
        BarNumberTBox.Value = 0;
        CurrentSellingPriceBox.Value = 0;
        PurchasePriceBox.Value = 0;
        AmountOfProductTBox.Value = 0;

        ProductDescriptionTBox.Clear();

        BuyMethodDigitCBox.SelectedIndex = -1;
        ProductTypeDigitCBox.SelectedIndex = -1;
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
            CurrentSellingPrice = CurrentSellingPriceBox.Value,
            IsReturned = false,
            Quantity = (int)AmountOfProductTBox.Value,
            IdPurchaseMethod = BuyMethodDigitCBox.Text,
            AddedAt = DateTime.Now,
            Purchase = new Purchase
            {
                Amount = (int)AmountOfProductTBox.Value,
                DatePurchase = DateTime.Now,
                PurchasePrice = PurchasePriceBox.Value,
                IdPurchase = Guid.NewGuid(),
                IdProduct = idProductGuid
            }
        };



        ValidateAddProduct validateAddProduct = new ValidateAddProduct(product);

        var result = validateAddProduct.ReturnValidatingResult();
        if (!result.IsValid)
        {

            MessageBox.Show(string.Join("\n", result.Errors), "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        else
        {

            _createProductAndPurchase = new CreateProductAndPurchase(product);
            SuccessfullyProductAdded();


        }

    }


}