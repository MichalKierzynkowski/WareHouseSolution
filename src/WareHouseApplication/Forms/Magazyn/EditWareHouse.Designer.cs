
namespace WareHouseApplication.Forms.Magazyn
{
    partial class EditWareHouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWareHouse));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MetodaKupnaWyrazCBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RodzajProduktuWyrazCBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OpisProduktuTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.BuyPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.SellPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.SortingButton = new System.Windows.Forms.Button();
            this.DeletButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NumerKreskowyTBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MetodaZakupuCyfraCBox = new System.Windows.Forms.ComboBox();
            this.MetodaZakupuWyrazCBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RodzajProdSortowanieWyrazCBox = new System.Windows.Forms.ComboBox();
            this.RodzajProdSortowanieCyfraCBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellPriceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1539, 125);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(486, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(590, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Edytuj Magazyn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 680);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1502, 424);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // 
            // MetodaKupnaWyrazCBox
            // 
            this.MetodaKupnaWyrazCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MetodaKupnaWyrazCBox.FormattingEnabled = true;
            this.MetodaKupnaWyrazCBox.Items.AddRange(new object[] {
            "Faktura",
            "Paragon"});
            this.MetodaKupnaWyrazCBox.Location = new System.Drawing.Point(261, 352);
            this.MetodaKupnaWyrazCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MetodaKupnaWyrazCBox.Name = "MetodaKupnaWyrazCBox";
            this.MetodaKupnaWyrazCBox.Size = new System.Drawing.Size(247, 28);
            this.MetodaKupnaWyrazCBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Metoda Zakupu:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RodzajProduktuWyrazCBox
            // 
            this.RodzajProduktuWyrazCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RodzajProduktuWyrazCBox.FormattingEnabled = true;
            this.RodzajProduktuWyrazCBox.Items.AddRange(new object[] {
            "Bluzka",
            "Bluza",
            "Spodnie",
            "Dres",
            "Sukienka",
            "Sweter",
            "Spódnica",
            "Spodenki",
            "Kurtka",
            "Body",
            "Buty",
            "Czapka",
            "Gumka do Włosów",
            "Kamizelka",
            "Klapki",
            "Kombinezon",
            "Komin/Szalik",
            "Komplet Odzieży",
            "Koszula",
            "Koszulka",
            "Leginsy",
            "Marynarka/Żakiet",
            "Opaska",
            "Plecak",
            "Płaszcz",
            "Rękawiczki",
            "Szalik",
            "T_Shirt",
            "Top",
            "Torebka",
            "Tunika",
            "Bransoletka",
            "Broszka",
            "Kolczyki",
            "Naszyjnik",
            "Pierścionki",
            "Komplet Biżuterii",
            "Okulary",
            "Pasek",
            "Brelok",
            "Pudełko",
            "Zegarek",
            "Apaszka",
            "Perfumy"});
            this.RodzajProduktuWyrazCBox.Location = new System.Drawing.Point(261, 264);
            this.RodzajProduktuWyrazCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RodzajProduktuWyrazCBox.Name = "RodzajProduktuWyrazCBox";
            this.RodzajProduktuWyrazCBox.Size = new System.Drawing.Size(247, 28);
            this.RodzajProduktuWyrazCBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Rodzaj Produktu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpisProduktuTBox
            // 
            this.OpisProduktuTBox.Location = new System.Drawing.Point(261, 430);
            this.OpisProduktuTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpisProduktuTBox.Multiline = true;
            this.OpisProduktuTBox.Name = "OpisProduktuTBox";
            this.OpisProduktuTBox.Size = new System.Drawing.Size(247, 30);
            this.OpisProduktuTBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "Opis Produktu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(592, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 32);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ilość:";
            // 
            // AmountNumeric
            // 
            this.AmountNumeric.Location = new System.Drawing.Point(762, 266);
            this.AmountNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AmountNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AmountNumeric.Name = "AmountNumeric";
            this.AmountNumeric.Size = new System.Drawing.Size(112, 27);
            this.AmountNumeric.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(545, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "Cena Zakupu:";
            // 
            // BuyPriceNumeric
            // 
            this.BuyPriceNumeric.Location = new System.Drawing.Point(762, 365);
            this.BuyPriceNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuyPriceNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BuyPriceNumeric.Name = "BuyPriceNumeric";
            this.BuyPriceNumeric.Size = new System.Drawing.Size(112, 27);
            this.BuyPriceNumeric.TabIndex = 37;
            // 
            // SellPriceNumeric
            // 
            this.SellPriceNumeric.Location = new System.Drawing.Point(762, 434);
            this.SellPriceNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SellPriceNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SellPriceNumeric.Name = "SellPriceNumeric";
            this.SellPriceNumeric.Size = new System.Drawing.Size(112, 27);
            this.SellPriceNumeric.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(545, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 32);
            this.label7.TabIndex = 38;
            this.label7.Text = "Cena Sprzedaży:";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(324, 546);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(141, 76);
            this.EditButton.TabIndex = 42;
            this.EditButton.Text = "Edytuj";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SortingButton
            // 
            this.SortingButton.Location = new System.Drawing.Point(1355, 546);
            this.SortingButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortingButton.Name = "SortingButton";
            this.SortingButton.Size = new System.Drawing.Size(141, 76);
            this.SortingButton.TabIndex = 41;
            this.SortingButton.Text = "Sortuj";
            this.SortingButton.UseVisualStyleBackColor = true;
            this.SortingButton.Click += new System.EventHandler(this.SortingButton_Click);
            // 
            // DeletButton
            // 
            this.DeletButton.Location = new System.Drawing.Point(177, 546);
            this.DeletButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeletButton.Name = "DeletButton";
            this.DeletButton.Size = new System.Drawing.Size(141, 76);
            this.DeletButton.TabIndex = 40;
            this.DeletButton.Text = "Usuń";
            this.DeletButton.UseVisualStyleBackColor = true;
            
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(373, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 41);
            this.label8.TabIndex = 43;
            this.label8.Text = "Opcje Edycji:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1135, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 41);
            this.label9.TabIndex = 44;
            this.label9.Text = "Opcje Sortowania:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumerKreskowyTBox
            // 
            this.NumerKreskowyTBox.Location = new System.Drawing.Point(1232, 434);
            this.NumerKreskowyTBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumerKreskowyTBox.Multiline = true;
            this.NumerKreskowyTBox.Name = "NumerKreskowyTBox";
            this.NumerKreskowyTBox.Size = new System.Drawing.Size(264, 35);
            this.NumerKreskowyTBox.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.CausesValidation = false;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(988, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 32);
            this.label10.TabIndex = 51;
            this.label10.Text = "Kod Kreskowy:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MetodaZakupuCyfraCBox
            // 
            this.MetodaZakupuCyfraCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MetodaZakupuCyfraCBox.FormattingEnabled = true;
            this.MetodaZakupuCyfraCBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.MetodaZakupuCyfraCBox.Location = new System.Drawing.Point(1232, 354);
            this.MetodaZakupuCyfraCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MetodaZakupuCyfraCBox.Name = "MetodaZakupuCyfraCBox";
            this.MetodaZakupuCyfraCBox.Size = new System.Drawing.Size(51, 28);
            this.MetodaZakupuCyfraCBox.TabIndex = 50;
            //this.MetodaZakupuCyfraCBox.SelectionChangeCommitted += new System.EventHandler(this.MetodaZakupuCyfraCBox_SelectionChangeCommitted);
            //this.MetodaZakupuCyfraCBox.SelectedValueChanged += new System.EventHandler(this.MetodaZakupuCyfraCBox_SelectedValueChanged);
            // 
            // MetodaZakupuWyrazCBox
            // 
            this.MetodaZakupuWyrazCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MetodaZakupuWyrazCBox.FormattingEnabled = true;
            this.MetodaZakupuWyrazCBox.Items.AddRange(new object[] {
            "Faktura",
            "Paragon"});
            this.MetodaZakupuWyrazCBox.Location = new System.Drawing.Point(1318, 360);
            this.MetodaZakupuWyrazCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MetodaZakupuWyrazCBox.Name = "MetodaZakupuWyrazCBox";
            this.MetodaZakupuWyrazCBox.Size = new System.Drawing.Size(178, 28);
            this.MetodaZakupuWyrazCBox.TabIndex = 49;
            //this.MetodaZakupuWyrazCBox.SelectionChangeCommitted += new System.EventHandler(this.MetodaZakupuWyrazCBox_SelectionChangeCommitted);
            //this.MetodaZakupuWyrazCBox.SelectedValueChanged += new System.EventHandler(this.MetodaZakupuWyrazCBox_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.CausesValidation = false;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(988, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 32);
            this.label11.TabIndex = 48;
            this.label11.Text = "Metoda Zakupu:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RodzajProdSortowanieWyrazCBox
            // 
            this.RodzajProdSortowanieWyrazCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RodzajProdSortowanieWyrazCBox.FormattingEnabled = true;
            this.RodzajProdSortowanieWyrazCBox.Items.AddRange(new object[] {
            "Bluzka",
            "Bluza",
            "Spodnie",
            "Dres",
            "Sukienka",
            "Sweter",
            "Spódnica",
            "Spodenki",
            "Kurtka",
            "Body",
            "Buty",
            "Czapka",
            "Gumka do Włosów",
            "Kamizelka",
            "Klapki",
            "Kombinezon",
            "Komin/Szalik",
            "Komplet Odzieży",
            "Koszula",
            "Koszulka",
            "Leginsy",
            "Marynarka/Żakiet",
            "Opaska",
            "Plecak",
            "Płaszcz",
            "Rękawiczki",
            "Szalik",
            "T_Shirt",
            "Top",
            "Torebka",
            "Tunika",
            "Bransoletka",
            "Broszka",
            "Kolczyki",
            "Naszyjnik",
            "Pierścionki",
            "Komplet Biżuterii",
            "Okulary",
            "Pasek",
            "Brelok",
            "Pudełko",
            "Zegarek",
            "Apaszka",
            "Perfumy"});
            this.RodzajProdSortowanieWyrazCBox.Location = new System.Drawing.Point(1318, 264);
            this.RodzajProdSortowanieWyrazCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RodzajProdSortowanieWyrazCBox.Name = "RodzajProdSortowanieWyrazCBox";
            this.RodzajProdSortowanieWyrazCBox.Size = new System.Drawing.Size(178, 28);
            this.RodzajProdSortowanieWyrazCBox.TabIndex = 47;
            //this.RodzajProdSortowanieWyrazCBox.SelectionChangeCommitted += new System.EventHandler(this.RodzajProdSortowanieWyrazCBox_SelectionChangeCommitted);
            // 
            // RodzajProdSortowanieCyfraCBox
            // 
            this.RodzajProdSortowanieCyfraCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RodzajProdSortowanieCyfraCBox.FormattingEnabled = true;
            this.RodzajProdSortowanieCyfraCBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "55"});
            this.RodzajProdSortowanieCyfraCBox.Location = new System.Drawing.Point(1232, 264);
            this.RodzajProdSortowanieCyfraCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RodzajProdSortowanieCyfraCBox.Name = "RodzajProdSortowanieCyfraCBox";
            this.RodzajProdSortowanieCyfraCBox.Size = new System.Drawing.Size(51, 28);
            this.RodzajProdSortowanieCyfraCBox.TabIndex = 46;
            this.RodzajProdSortowanieCyfraCBox.SelectionChangeCommitted += new System.EventHandler(this.RodzajProdSortowanieCyfraCBox_SelectionChangeCommitted);
            this.RodzajProdSortowanieCyfraCBox.SelectedValueChanged += new System.EventHandler(this.RodzajProdSortowanieCyfraCBox_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.CausesValidation = false;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(988, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 32);
            this.label12.TabIndex = 45;
            this.label12.Text = "Rodzaj Produktu:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(933, 170);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 452);
            this.panel2.TabIndex = 53;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(1208, 546);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(141, 76);
            this.ResetButton.TabIndex = 54;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(471, 546);
            this.SaveChangesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(141, 76);
            this.SaveChangesButton.TabIndex = 55;
            this.SaveChangesButton.Text = "Zatwierdź Zmiany";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // EditWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1540, 1192);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NumerKreskowyTBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MetodaZakupuCyfraCBox);
            this.Controls.Add(this.MetodaZakupuWyrazCBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RodzajProdSortowanieWyrazCBox);
            this.Controls.Add(this.RodzajProdSortowanieCyfraCBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SortingButton);
            this.Controls.Add(this.DeletButton);
            this.Controls.Add(this.SellPriceNumeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BuyPriceNumeric);
            this.Controls.Add(this.AmountNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OpisProduktuTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MetodaKupnaWyrazCBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RodzajProduktuWyrazCBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "EditWareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditWareHouse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyPriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellPriceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox MetodaKupnaWyrazCBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RodzajProduktuWyrazCBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OpisProduktuTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown AmountNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown BuyPriceNumeric;
        private System.Windows.Forms.NumericUpDown SellPriceNumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SortingButton;
        private System.Windows.Forms.Button DeletButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NumerKreskowyTBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox MetodaZakupuCyfraCBox;
        private System.Windows.Forms.ComboBox MetodaZakupuWyrazCBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox RodzajProdSortowanieWyrazCBox;
        private System.Windows.Forms.ComboBox RodzajProdSortowanieCyfraCBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveChangesButton;
    }
}