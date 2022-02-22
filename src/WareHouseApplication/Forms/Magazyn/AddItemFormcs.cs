using ClassesLibrary;
using ClassesLibrary.SqlModels;
using ClassesLibrary.ValidationClasses;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WareHouseApplication.Forms
{
    public partial class AddItemFormcs : Form
    {
        public string connectionString { get; set; }
        public AddItemFormcs(MainMenu objMainMenu, string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            ObjMainMenu = objMainMenu;
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

        private void button1_Click(object sender, EventArgs e)
        {

            var product = new Product
            {
                Description_Product = ProductDescriptionTBox.Text,Type_Product = Convert.ToInt32(ProductTypeDigitCBox.Text),
                Bar_Number = Convert.ToInt32(BarNumberTBox.Text),Offer_Price = Convert.ToInt32(SellPriceTBox.Text),

            };
            
            var notNullValidationObj = new IsNullIAddingItemValidation(ProductDescriptionTBox.Text, ProductTypeDigitCBox.Text,
                BarNumberTBox.Text, BuyMethodDigitCBox.Text, SellPriceTBox.Text,
                AmountOfProductTBox.Text, BuyPriceTBox.Text);

            var rulesValidationObj = new RulesValidationAddingItem(ProductDescriptionTBox.Text, ProductTypeDigitCBox.Text,
                BarNumberTBox.Text, BuyMethodDigitCBox.Text,
                AmountOfProductTBox.Text);
            var list = notNullValidationObj.list;
            var isNull = notNullValidationObj.isNullValidation(list);

            var isCorrect = rulesValidationObj.Validation(ProductDescriptionTBox.Text, ProductTypeDigitCBox.Text,
                BarNumberTBox.Text, BuyMethodDigitCBox.Text,
                 AmountOfProductTBox.Text);
            var isMoneyCorrect = rulesValidationObj.MoneyValidation(BuyPriceTBox.Text, SellPriceTBox.Text);

            if (isNull == false)
            {
                if (isCorrect)
                {
                    if (isMoneyCorrect)
                    {
                        var objBarNumbValid = new BarNumberValidation();
                        var exists = objBarNumbValid.Validation(BarNumberTBox.Text, connectionString);
                        if (exists == true)
                        {
                            BarNumberDuplicateBox();
                        }
                        else
                        {
                            CreatingProduct();
                            CreatingPurchase();
                            SuccessfullyProductAdded();

                            ClearingMenu();
                        }
                    }
                    else
                    {
                        ErrorWithPriceBox();
                    }
                }
                else
                {
                    FieldNotCorrectBox();
                }
            }
            else
            {
                FieldNullBox();
            }
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
            string bar_Number = BarNumberTBox.Text;
            var notNullValidationObj = new IsNullIAddingItemValidation(bar_Number);
            var list = notNullValidationObj.list;
            var isNull = notNullValidationObj.isNullValidation(list);
            var rulesValidationObj = new RulesValidationAddingItem(bar_Number);
            var isCorrect = rulesValidationObj.Validation(bar_Number);

            if (isNull == false)
            {
                if (isCorrect)
                {
                    var objBarNumbValid = new BarNumberValidation();
                    var exists = objBarNumbValid.Validation(bar_Number, connectionString);

                    if (exists == true)
                    {
                        string message = "Instnieje w bazie taki produkt!";
                        string title = "Informacja";
                        MessageBox.Show(message, title);
                    }
                    else
                    {
                        string message = "Nie istnieje w bazie taki produkt!";
                        string title = "Informacja";
                        MessageBox.Show(message, title);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Formularz nie został wypełniony prawidłowo!" + Environment.NewLine +
                        "Jeśli chcesz sprawdzić dostępność produktu wypełni pole Numer_Kreskowy!", "Błąd!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "Formularz nie został wypełniony prawidłowo!" + Environment.NewLine +
                    "Jeśli chcesz sprawdzić dostepność produktu, wprowadź odpowiednie znaki!", "Błąd!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearingMenu()
        {
            SellPriceTBox.Clear();
            BuyPriceTBox.Clear();
            AmountOfProductTBox.Clear();
            ProductDescriptionTBox.Clear();
            BarNumberTBox.Clear();
            BuyMethodDigitCBox.SelectedIndex = -1;
            ProductTypeDigitCBox.SelectedIndex = -1;
        }

        private int TakingIdProduct(string BarNumber)

        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                int iBarNumber = Convert.ToInt32(BarNumber);
                var car = con.QueryFirst<Product>(@"SELECT Id_Product FROM Product WHERE Bar_Number= @Bar_Number",
                    new { Bar_Number = iBarNumber });

                return car.Id_Product;
            }
        }

        private void CreatingProduct()
        {
            var Type_Product = ProductTypeDigitCBox.Text;
            var Bar_Number = BarNumberTBox.Text;
            var Description = ProductDescriptionTBox.Text;
            var Purchase_Method = BuyMethodDigitCBox.Text;
            var Quantity = AmountOfProductTBox.Text;
            var OfferPrice = SellPriceTBox.Text;

            string insertSql = @"INSERT INTO Product (Type_Product,Bar_Number,Description_Product,Purchase_Method,Quantity,Offer_Price,IsReturned) Values (@Type_Product,@Bar_Number,@Description,@Purchase_Method,@Quantity,@OfferPrice,'Nie');";

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(insertSql, cnn);

            cmd.Parameters.AddWithValue("@Type_Product", Type_Product);
            cmd.Parameters.AddWithValue("@Bar_Number", Bar_Number);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@Purchase_Method", Purchase_Method);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@OfferPrice", Convert.ToDouble(OfferPrice));
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        private void CreatingPurchase()
        {
            var Bar_Number = BarNumberTBox.Text;
            var Quantity = AmountOfProductTBox.Text;
            var BuyingPrice = BuyPriceTBox.Text;
            var Id_Product = TakingIdProduct(Bar_Number);
            string From_Product_Create = "Tak";
            SqlConnection cnn2 = new SqlConnection(connectionString);
            DateTime Date_Purchase = DateTime.Now;
            var querySqlPurchase = @"Insert Into Purchase (Id_Product,Date_Purchase,Amount,Price,From_Product_Create) values(@Id_Product,@Date_Purchase,@Quantity,@BuyingPrice,@From_Product_Create)";
            SqlCommand cmdPurchase = new SqlCommand(querySqlPurchase, cnn2);
            cmdPurchase.Parameters.AddWithValue("@Id_Product", Id_Product);
            cmdPurchase.Parameters.AddWithValue("@Date_Purchase", Date_Purchase);
            cmdPurchase.Parameters.AddWithValue("@Quantity", Quantity);
            cmdPurchase.Parameters.AddWithValue("@BuyingPrice", Convert.ToDouble(BuyingPrice));
            cmdPurchase.Parameters.AddWithValue("@From_Product_Create",From_Product_Create);


            cnn2.Open();
            cmdPurchase.ExecuteNonQuery();
            cnn2.Close();
        }

        private void BarNumberDuplicateBox()
        {
            MessageBox.Show(
                                      "Błąd bazy danych!" + Environment.NewLine +
                                      "Baza zawiera już produkt o takim kodzie kreskowym!", "Błąd!",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SuccessfullyProductAdded()
        {
            MessageBox.Show(

                      "Pomyślnie dodano nowy produkt!", "Sukces!",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ErrorWithPriceBox()
        {
            MessageBox.Show(
                      "Formularz nie został wypełniony prawidłowo!" + Environment.NewLine +
                      "Pamiętaj, że cena musi być zdefiniowana z przecinkiem!", "Błąd!",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void FieldNullBox()
        {
            MessageBox.Show(
                   "Formularz nie został wypełniony prawidłowo!" + Environment.NewLine +
                   "Formularz zawiera puste pola!", "Błąd!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void FieldNotCorrectBox()
        {
            MessageBox.Show(
                                   "Formularz nie został wypełniony prawidłowo!" + Environment.NewLine +
                                   "Pola nie zostały wypełnione prawidłowo!", "Błąd!",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}