namespace WareHouseApplication.Forms.Sale
{
    partial class AddSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSale));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumerKreskowyTBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RodzajProdSortowanieWyrazCBox = new System.Windows.Forms.ComboBox();
            this.RodzajProdSortowanieCyfraCBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MetodaZakupuWyrazCBox = new System.Windows.Forms.ComboBox();
            this.MetodaZakupuCyfraCBox = new System.Windows.Forms.ComboBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SortingButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OpisProduktuTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RodzajProduktuWyrazCBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DiscountUpDown = new System.Windows.Forms.NumericUpDown();
            this.SellItemButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BuyPriceBox = new System.Windows.Forms.TextBox();
            this.SellPriceBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 124);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(622, 13);
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
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(724, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dodaj Sprzedaż";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(132, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 41);
            this.label8.TabIndex = 44;
            this.label8.Text = "Wybierz Produkt:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(658, 181);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(916, 424);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // NumerKreskowyTBox
            // 
            this.NumerKreskowyTBox.Location = new System.Drawing.Point(274, 448);
            this.NumerKreskowyTBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumerKreskowyTBox.Multiline = true;
            this.NumerKreskowyTBox.Name = "NumerKreskowyTBox";
            this.NumerKreskowyTBox.Size = new System.Drawing.Size(264, 35);
            this.NumerKreskowyTBox.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.CausesValidation = false;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(30, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 32);
            this.label10.TabIndex = 59;
            this.label10.Text = "Kod Kreskowy:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.RodzajProdSortowanieWyrazCBox.Location = new System.Drawing.Point(361, 279);
            this.RodzajProdSortowanieWyrazCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RodzajProdSortowanieWyrazCBox.Name = "RodzajProdSortowanieWyrazCBox";
            this.RodzajProdSortowanieWyrazCBox.Size = new System.Drawing.Size(178, 28);
            this.RodzajProdSortowanieWyrazCBox.TabIndex = 55;
            this.RodzajProdSortowanieWyrazCBox.SelectionChangeCommitted += new System.EventHandler(this.RodzajProdSortowanieWyrazCBox_SelectionChangeCommitted);
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
            this.RodzajProdSortowanieCyfraCBox.Location = new System.Drawing.Point(275, 279);
            this.RodzajProdSortowanieCyfraCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RodzajProdSortowanieCyfraCBox.Name = "RodzajProdSortowanieCyfraCBox";
            this.RodzajProdSortowanieCyfraCBox.Size = new System.Drawing.Size(51, 28);
            this.RodzajProdSortowanieCyfraCBox.TabIndex = 54;
            this.RodzajProdSortowanieCyfraCBox.SelectionChangeCommitted += new System.EventHandler(this.RodzajProdSortowanieCyfraCBox_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.CausesValidation = false;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(31, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 32);
            this.label12.TabIndex = 53;
            this.label12.Text = "Rodzaj Produktu:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.CausesValidation = false;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(30, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 32);
            this.label11.TabIndex = 56;
            this.label11.Text = "Metoda Zakupu:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MetodaZakupuWyrazCBox
            // 
            this.MetodaZakupuWyrazCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MetodaZakupuWyrazCBox.FormattingEnabled = true;
            this.MetodaZakupuWyrazCBox.Items.AddRange(new object[] {
            "Faktura",
            "Paragon"});
            this.MetodaZakupuWyrazCBox.Location = new System.Drawing.Point(360, 374);
            this.MetodaZakupuWyrazCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MetodaZakupuWyrazCBox.Name = "MetodaZakupuWyrazCBox";
            this.MetodaZakupuWyrazCBox.Size = new System.Drawing.Size(178, 28);
            this.MetodaZakupuWyrazCBox.TabIndex = 57;
            this.MetodaZakupuWyrazCBox.SelectionChangeCommitted += new System.EventHandler(this.MetodaZakupuWyrazCBox_SelectionChangeCommitted);
            // 
            // MetodaZakupuCyfraCBox
            // 
            this.MetodaZakupuCyfraCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MetodaZakupuCyfraCBox.FormattingEnabled = true;
            this.MetodaZakupuCyfraCBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.MetodaZakupuCyfraCBox.Location = new System.Drawing.Point(274, 368);
            this.MetodaZakupuCyfraCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MetodaZakupuCyfraCBox.Name = "MetodaZakupuCyfraCBox";
            this.MetodaZakupuCyfraCBox.Size = new System.Drawing.Size(51, 28);
            this.MetodaZakupuCyfraCBox.TabIndex = 58;
            this.MetodaZakupuCyfraCBox.SelectionChangeCommitted += new System.EventHandler(this.MetodaZakupuCyfraCBox_SelectionChangeCommitted);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(251, 518);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(141, 76);
            this.ResetButton.TabIndex = 62;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SortingButton
            // 
            this.SortingButton.Location = new System.Drawing.Point(398, 518);
            this.SortingButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortingButton.Name = "SortingButton";
            this.SortingButton.Size = new System.Drawing.Size(141, 76);
            this.SortingButton.TabIndex = 61;
            this.SortingButton.Text = "Sortuj";
            this.SortingButton.UseVisualStyleBackColor = true;
            this.SortingButton.Click += new System.EventHandler(this.SortingButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(555, 923);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 32);
            this.label7.TabIndex = 73;
            this.label7.Text = "Cena Sprzedaży:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(555, 842);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 32);
            this.label6.TabIndex = 70;
            this.label6.Text = "Cena Zakupu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(602, 757);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 32);
            this.label5.TabIndex = 69;
            this.label5.Text = "Ilość:";
            // 
            // OpisProduktuTBox
            // 
            this.OpisProduktuTBox.Location = new System.Drawing.Point(271, 923);
            this.OpisProduktuTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpisProduktuTBox.Multiline = true;
            this.OpisProduktuTBox.Name = "OpisProduktuTBox";
            this.OpisProduktuTBox.ReadOnly = true;
            this.OpisProduktuTBox.Size = new System.Drawing.Size(247, 30);
            this.OpisProduktuTBox.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 923);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 67;
            this.label2.Text = "Opis Produktu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 845);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 32);
            this.label4.TabIndex = 65;
            this.label4.Text = "Rabat:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RodzajProduktuWyrazCBox
            // 
            this.RodzajProduktuWyrazCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RodzajProduktuWyrazCBox.Enabled = false;
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
            this.RodzajProduktuWyrazCBox.Location = new System.Drawing.Point(271, 757);
            this.RodzajProduktuWyrazCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RodzajProduktuWyrazCBox.Name = "RodzajProduktuWyrazCBox";
            this.RodzajProduktuWyrazCBox.Size = new System.Drawing.Size(247, 28);
            this.RodzajProduktuWyrazCBox.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 757);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 32);
            this.label3.TabIndex = 63;
            this.label3.Text = "Rodzaj Produktu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(31, 639);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1543, 16);
            this.panel2.TabIndex = 75;
            // 
            // DiscountUpDown
            // 
            this.DiscountUpDown.Location = new System.Drawing.Point(271, 845);
            this.DiscountUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DiscountUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DiscountUpDown.Name = "DiscountUpDown";
            this.DiscountUpDown.Size = new System.Drawing.Size(247, 27);
            this.DiscountUpDown.TabIndex = 76;
            // 
            // SellItemButton
            // 
            this.SellItemButton.Location = new System.Drawing.Point(1229, 879);
            this.SellItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SellItemButton.Name = "SellItemButton";
            this.SellItemButton.Size = new System.Drawing.Size(141, 76);
            this.SellItemButton.TabIndex = 77;
            this.SellItemButton.Text = "Sprzedaj Przedmiot";
            this.SellItemButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1082, 879);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 76);
            this.button2.TabIndex = 78;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(772, 764);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(112, 27);
            this.textBox1.TabIndex = 81;
            this.textBox1.Text = "1";
            // 
            // BuyPriceBox
            // 
            this.BuyPriceBox.Location = new System.Drawing.Point(772, 842);
            this.BuyPriceBox.Name = "BuyPriceBox";
            this.BuyPriceBox.ReadOnly = true;
            this.BuyPriceBox.Size = new System.Drawing.Size(112, 27);
            this.BuyPriceBox.TabIndex = 82;
            // 
            // SellPriceBox
            // 
            this.SellPriceBox.Location = new System.Drawing.Point(772, 923);
            this.SellPriceBox.Name = "SellPriceBox";
            this.SellPriceBox.ReadOnly = true;
            this.SellPriceBox.Size = new System.Drawing.Size(112, 27);
            this.SellPriceBox.TabIndex = 83;
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1614, 1048);
            this.Controls.Add(this.SellPriceBox);
            this.Controls.Add(this.BuyPriceBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SellItemButton);
            this.Controls.Add(this.DiscountUpDown);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OpisProduktuTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RodzajProduktuWyrazCBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SortingButton);
            this.Controls.Add(this.NumerKreskowyTBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MetodaZakupuCyfraCBox);
            this.Controls.Add(this.MetodaZakupuWyrazCBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RodzajProdSortowanieWyrazCBox);
            this.Controls.Add(this.RodzajProdSortowanieCyfraCBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "AddSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Sprzedaż";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NumerKreskowyTBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox RodzajProdSortowanieWyrazCBox;
        private System.Windows.Forms.ComboBox RodzajProdSortowanieCyfraCBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox MetodaZakupuWyrazCBox;
        private System.Windows.Forms.ComboBox MetodaZakupuCyfraCBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SortingButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OpisProduktuTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RodzajProduktuWyrazCBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown DiscountUpDown;
        private System.Windows.Forms.Button SellItemButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox BuyPriceBox;
        private System.Windows.Forms.TextBox SellPriceBox;
    }
}