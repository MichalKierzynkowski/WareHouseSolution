using System;
using System.Data.Entity.Validation;
using System.Windows.Forms;
using ClassesLibrary;
using EntityFrrameworkClasses;

namespace WareHouseApplication.Forms
{
    public partial class AddItemFormcs : Form
    {
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
                NumerKreskowyTBox.Text, MetodaKupnaCyfraCBox.Text, CenaZakupuTBox.Text, CenaSprzedTBox.Text,
                IloscProdTBox.Text);

            var rulesValidationObj = new RulesValidationAddingItem(OpisProduktuTBox.Text, RodzajProdCBox.Text,
                NumerKreskowyTBox.Text, MetodaKupnaCyfraCBox.Text, CenaZakupuTBox.Text, CenaSprzedTBox.Text,
                IloscProdTBox.Text);
            var list = notNullValidationObj.list;
            var isNull = notNullValidationObj.isNullValidation(list);

            var isCorrect = rulesValidationObj.Validation(OpisProduktuTBox.Text, RodzajProdCBox.Text,
                NumerKreskowyTBox.Text, MetodaKupnaCyfraCBox.Text, CenaZakupuTBox.Text,
                CenaSprzedTBox.Text, IloscProdTBox.Text);

            try
            {
                if (isNull == false)
                {
                    if (isCorrect)
                    {
                        var context = new WareHouseEntities1();
                        var product = new Product
                        {


                            Description = OpisProduktuTBox.Text,
                            Type = Convert.ToInt32(RodzajProdCBox.Text),
                            Bar_Number = Convert.ToInt32(NumerKreskowyTBox.Text),
                            Purchase_Method = Convert.ToInt32(Convert.ToInt32(MetodaKupnaCyfraCBox.Text)),
                            Purchase_Price = Convert.ToDecimal(CenaZakupuTBox.Text),
                            Sell_Price = Convert.ToDecimal(CenaSprzedTBox.Text),
                            Id_Warehouse = 0,


                        };
                        context.Product.Add(product);
                        context.SaveChanges();
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
            catch (DbEntityValidationException dbex)
            {
                foreach (var validationErrors in dbex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        var value = ("Property: {0} Error: {1}", validationError.PropertyName.ToString(),
                            validationError.ErrorMessage.ToString());
                        int x = 6;
                    }
                }
            }
           // catch (Exception dException)
            //{
              //  var value = dException.InnerException.Message;
            //    int x = 5;
            //}

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
    }
}