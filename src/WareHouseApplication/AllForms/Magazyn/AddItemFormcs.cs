
using System;
using System.Windows.Forms;


namespace WareHouseApplication.Forms.Magazyn;

public partial class AddItemFormcs : Form
{

  
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
       

    }


}