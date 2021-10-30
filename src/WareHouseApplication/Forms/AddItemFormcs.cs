using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesLibrary;
using EntityFrrameworkClasses;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Internal;

namespace WareHouseApplication.Forms
{
    public partial class AddItemFormcs : Form
    {
        public MainMenu ObjMainMenu { get; private set; }
        public AddItemFormcs(MainMenu objMainMenu)
        {
            InitializeComponent();
            this.ObjMainMenu = objMainMenu;
            
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz wrócić do głównego Menu? Wszystkie nie zapisane dane zostaną stracone!", "Wyjście!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz wrócić do głównego Menu? Wszystkie nie zapisane dane zostaną stracone!", "Wyjście!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


                this.Hide();
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedItemComboBox2 = Convert.ToInt16(RodzajProdCBox.SelectedIndex);
            comboBox3.SelectedIndex= selectedItemComboBox2;
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedItemComboBox3 = Convert.ToInt16(comboBox3.SelectedIndex);
            RodzajProdCBox.SelectedIndex = selectedItemComboBox3;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var notNullValidationObj = new IsNullIAddingItemValidation(OpisProduktuTBox.Text.ToString(),RodzajProdCBox.Text,NumerKreskowyTBox.Text.ToString(),MetodaKupnaWyrazCBox.Text,CenaZakupuTBox.Text.ToString(),CenaSprzedTBox.Text.ToString(),IloscProdTBox.Text.ToString());

            var rulesValidationObj = new RulesValidationAddingItem(OpisProduktuTBox.Text.ToString(), RodzajProdCBox.Text, NumerKreskowyTBox.Text.ToString(), MetodaKupnaWyrazCBox.Text, CenaZakupuTBox.Text.ToString(), CenaSprzedTBox.Text.ToString(), IloscProdTBox.Text.ToString());
            var list = notNullValidationObj.list;
            var isNull = notNullValidationObj.isNullValidation(list);

            var isCorrect = rulesValidationObj.Validation(OpisProduktuTBox.Text.ToString(), RodzajProdCBox.Text,
                NumerKreskowyTBox.Text.ToString(), MetodaKupnaWyrazCBox.Text, CenaZakupuTBox.Text.ToString(),
                CenaSprzedTBox.Text.ToString(), IloscProdTBox.Text.ToString());


            if (isNull==false)
            {
                
                if (isCorrect==true)
                {
                    int c = 7;
                }
            }
            int x = 6;

            

            var context = new WareHouseEntities1();
                var product = new Product()
                {
                   

                };
                context.Product.Add(product);
                context.SaveChanges();
            




           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItemComboBox2 = Convert.ToInt16(RodzajProdCBox.SelectedIndex);
            comboBox3.SelectedIndex = selectedItemComboBox2;
        }

        private void MetodaKupnaCBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

