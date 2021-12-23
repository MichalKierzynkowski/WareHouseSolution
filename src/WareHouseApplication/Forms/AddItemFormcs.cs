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
            int selectedItemComboBox2 = Convert.ToInt16(RodzajProdCBox.SelectedIndex);
            comboBox3.SelectedIndex = selectedItemComboBox2;
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedItemComboBox3 = Convert.ToInt16(comboBox3.SelectedIndex);
            RodzajProdCBox.SelectedIndex = selectedItemComboBox3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var notNullValidationObj = new IsNullIAddingItemValidation(OpisProduktuTBox.Text, RodzajProdCBox.Text,
                NumerKreskowyTBox.Text, MetodaKupnaCyfraCBox.Text, CenaSprzedTBox.Text,
                IloscProdTBox.Text, CenaZakupuTBox.Text);

            var rulesValidationObj = new RulesValidationAddingItem(OpisProduktuTBox.Text, RodzajProdCBox.Text,
                NumerKreskowyTBox.Text, MetodaKupnaCyfraCBox.Text,
                IloscProdTBox.Text);
            var list = notNullValidationObj.list;
            var isNull = notNullValidationObj.isNullValidation(list);

            var isCorrect = rulesValidationObj.Validation(OpisProduktuTBox.Text, RodzajProdCBox.Text,
                NumerKreskowyTBox.Text, MetodaKupnaCyfraCBox.Text,
                 IloscProdTBox.Text);
            var isMoneyCorrect = rulesValidationObj.MoneyValidation(CenaZakupuTBox.Text, CenaSprzedTBox.Text);

            if (isNull == false)
            {
                if (isCorrect)
                {
                    if (isMoneyCorrect)
                    {
                        var objBarNumbValid = new BarNumberValidation();
                        var exists = objBarNumbValid.Validation(NumerKreskowyTBox.Text, connectionString);
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
            int selectedItemMetodaKupnaCyfra = Convert.ToInt16(MetodaKupnaCyfraCBox.SelectedIndex);
            MetodaKupnaWyrazCBox.SelectedIndex = selectedItemMetodaKupnaCyfra;
        }

        private void MetodaKupnaWyrazCBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedItemMetodaKupnaWyraz = Convert.ToInt16(MetodaKupnaWyrazCBox.SelectedIndex);
            MetodaKupnaCyfraCBox.SelectedIndex = selectedItemMetodaKupnaWyraz;
        }

        private void DostepnoscButton_Click(object sender, EventArgs e)
        {
            string bar_Number = NumerKreskowyTBox.Text;
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
            CenaSprzedTBox.Clear();
            CenaZakupuTBox.Clear();
            IloscProdTBox.Clear();
            OpisProduktuTBox.Clear();
            NumerKreskowyTBox.Clear();
            MetodaKupnaCyfraCBox.SelectedIndex = -1;
            RodzajProdCBox.SelectedIndex = -1;
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
            var Type_Product = RodzajProdCBox.Text;
            var Bar_Number = NumerKreskowyTBox.Text;
            var Description = OpisProduktuTBox.Text;
            var Purchase_Method = MetodaKupnaCyfraCBox.Text;
            var Quantity = IloscProdTBox.Text;
            var OfferPrice = CenaSprzedTBox.Text;

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
            var Bar_Number = NumerKreskowyTBox.Text;
            var Quantity = IloscProdTBox.Text;
            var BuyingPrice = CenaZakupuTBox.Text;
            var Id_Product = TakingIdProduct(Bar_Number);

            SqlConnection cnn2 = new SqlConnection(connectionString);
            DateTime Date_Purchase = DateTime.Now;
            var querySqlPurchase = @"Insert Into Purchase (Id_Product,Date_Purchase,Amount,Price) values(@Id_Product,@Date_Purchase,@Quantity,@BuyingPrice)";
            SqlCommand cmdPurchase = new SqlCommand(querySqlPurchase, cnn2);
            cmdPurchase.Parameters.AddWithValue("@Id_Product", Id_Product);
            cmdPurchase.Parameters.AddWithValue("@Date_Purchase", Date_Purchase);
            cmdPurchase.Parameters.AddWithValue("@Quantity", Quantity);
            cmdPurchase.Parameters.AddWithValue("@BuyingPrice", Convert.ToDouble(BuyingPrice));

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