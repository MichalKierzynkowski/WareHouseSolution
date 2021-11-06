using ClassesLibrary;
using ClassesLibrary.ValidationClasses;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WareHouseApplication.Forms
{
    public partial class AddItemFormcs : Form
    {
        const string connectionString = "Data Source=DESKTOP-DQ7DARP\\SQLEXPRESS; Initial Catalog=WareHouse;User ID=; Integrated Security=SSPI;Persist Security Info=False;";
        public AddItemFormcs(MainMenu objMainMenu)
        {
            
            InitializeComponent();
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
                NumerKreskowyTBox.Text, MetodaKupnaCyfraCBox.Text, CenaSprzedTBox.Text,
                IloscProdTBox.Text, CenaZakupuTBox.Text);
            var list = notNullValidationObj.list;
            var isNull = notNullValidationObj.isNullValidation(list);

            var isCorrect = rulesValidationObj.Validation(OpisProduktuTBox.Text, RodzajProdCBox.Text,
                NumerKreskowyTBox.Text, MetodaKupnaCyfraCBox.Text,
                CenaSprzedTBox.Text, IloscProdTBox.Text, CenaZakupuTBox.Text);



            if (isNull == false)
            {
                if (isCorrect)
                {
                    var objBarNumbValid = new BarNumberValidation();
                    var exists = objBarNumbValid.Validation(NumerKreskowyTBox.Text);
                    if (exists == true)
                    {
                        MessageBox.Show(
                       "Błąd bazy danych!" + Environment.NewLine +
                       "Baza zawiera już produkt o takim kodzie kreskowym!", "Błąd!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var objInsData = new ProductModelOperations(OpisProduktuTBox.Text, RodzajProdCBox.Text, NumerKreskowyTBox.Text, MetodaKupnaCyfraCBox.Text, CenaSprzedTBox.Text, IloscProdTBox.Text);
                        

                        string insertSql = @"INSERT INTO Product (Type_Product,Bar_Number,Descripton_Product,Purchase_Method,Quantity,Offer_Price) Values (@Type_Product1,@Bar_Number1,@Desctription_Method1,@Purchase_Method1,@Quantity1,@Offer_Price1);";
                        using (var connection = new SqlConnection(connectionString))
                        {
                            connection.Execute(insertSql);
                            




                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Formularz nie został wypełniony prawidłowo!" + Environment.NewLine +
                        "Pola nie zostały wypełnione prawidłowo!", "Błąd!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "Formularz nie został wypełniony prawidłowo!" + Environment.NewLine +
                    "Formularz zawiera puste pola!", "Błąd!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var exists = objBarNumbValid.Validation(bar_Number);

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
    }
}
