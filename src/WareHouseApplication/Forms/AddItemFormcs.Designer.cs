
namespace WareHouseApplication.Forms
{
    partial class AddItemFormcs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemFormcs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OpisProduktuTBox = new System.Windows.Forms.TextBox();
            this.NumerKreskowyTBox = new System.Windows.Forms.TextBox();
            this.MetodaKupnaWyrazCBox = new System.Windows.Forms.ComboBox();
            this.CenaSprzedTBox = new System.Windows.Forms.TextBox();
            this.DodajProduktButton = new System.Windows.Forms.Button();
            this.AnulujButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.IloscProdTBox = new System.Windows.Forms.TextBox();
            this.RodzajProdCBox = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.MetodaKupnaCyfraCBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OpisProdInfo = new System.Windows.Forms.PictureBox();
            this.RodzajProdInfo = new System.Windows.Forms.PictureBox();
            this.NumerKreskInfo = new System.Windows.Forms.PictureBox();
            this.MetKupnaInfo = new System.Windows.Forms.PictureBox();
            this.CenaSprzedInfo = new System.Windows.Forms.PictureBox();
            this.IloscProduktuInfo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DostepnoscButton = new System.Windows.Forms.Button();
            this.CenaZakupuTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpisProdInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodzajProdInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerKreskInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetKupnaInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenaSprzedInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IloscProduktuInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 114);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(405, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodaj Produkt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(307, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WareHouseApplication.Properties.Resources.icons8_close_window_48__1_;
            this.pictureBox1.Location = new System.Drawing.Point(909, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(194, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis Produktu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(194, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rodzaj Produktu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(194, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numer Kreskowy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(194, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Metoda Kupna";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(194, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cena sprzedaży produktu";
            // 
            // OpisProduktuTBox
            // 
            this.OpisProduktuTBox.Location = new System.Drawing.Point(484, 207);
            this.OpisProduktuTBox.Multiline = true;
            this.OpisProduktuTBox.Name = "OpisProduktuTBox";
            this.OpisProduktuTBox.Size = new System.Drawing.Size(327, 25);
            this.OpisProduktuTBox.TabIndex = 7;
            // 
            // NumerKreskowyTBox
            // 
            this.NumerKreskowyTBox.Location = new System.Drawing.Point(484, 342);
            this.NumerKreskowyTBox.Multiline = true;
            this.NumerKreskowyTBox.Name = "NumerKreskowyTBox";
            this.NumerKreskowyTBox.Size = new System.Drawing.Size(327, 28);
            this.NumerKreskowyTBox.TabIndex = 9;
            // 
            // MetodaKupnaWyrazCBox
            // 
            this.MetodaKupnaWyrazCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MetodaKupnaWyrazCBox.FormattingEnabled = true;
            this.MetodaKupnaWyrazCBox.Items.AddRange(new object[] {
            "Faktura",
            "Paragon"});
            this.MetodaKupnaWyrazCBox.Location = new System.Drawing.Point(587, 421);
            this.MetodaKupnaWyrazCBox.Name = "MetodaKupnaWyrazCBox";
            this.MetodaKupnaWyrazCBox.Size = new System.Drawing.Size(224, 24);
            this.MetodaKupnaWyrazCBox.TabIndex = 10;
            this.MetodaKupnaWyrazCBox.SelectedValueChanged += new System.EventHandler(this.MetodaKupnaWyrazCBox_SelectedValueChanged);
            // 
            // CenaSprzedTBox
            // 
            this.CenaSprzedTBox.Location = new System.Drawing.Point(484, 504);
            this.CenaSprzedTBox.Multiline = true;
            this.CenaSprzedTBox.Name = "CenaSprzedTBox";
            this.CenaSprzedTBox.Size = new System.Drawing.Size(327, 25);
            this.CenaSprzedTBox.TabIndex = 12;
            // 
            // DodajProduktButton
            // 
            this.DodajProduktButton.Location = new System.Drawing.Point(707, 701);
            this.DodajProduktButton.Name = "DodajProduktButton";
            this.DodajProduktButton.Size = new System.Drawing.Size(141, 61);
            this.DodajProduktButton.TabIndex = 13;
            this.DodajProduktButton.Text = "Dodaj Produkt";
            this.DodajProduktButton.UseVisualStyleBackColor = true;
            this.DodajProduktButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnulujButton
            // 
            this.AnulujButton.Location = new System.Drawing.Point(413, 701);
            this.AnulujButton.Name = "AnulujButton";
            this.AnulujButton.Size = new System.Drawing.Size(141, 61);
            this.AnulujButton.TabIndex = 14;
            this.AnulujButton.Text = "Anuluj";
            this.AnulujButton.UseVisualStyleBackColor = true;
            this.AnulujButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(196, 609);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ilość Produktu";
            // 
            // IloscProdTBox
            // 
            this.IloscProdTBox.Location = new System.Drawing.Point(484, 612);
            this.IloscProdTBox.Multiline = true;
            this.IloscProdTBox.Name = "IloscProdTBox";
            this.IloscProdTBox.Size = new System.Drawing.Size(327, 25);
            this.IloscProdTBox.TabIndex = 16;
            // 
            // RodzajProdCBox
            // 
            this.RodzajProdCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RodzajProdCBox.FormattingEnabled = true;
            this.RodzajProdCBox.Items.AddRange(new object[] {
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
            this.RodzajProdCBox.Location = new System.Drawing.Point(484, 277);
            this.RodzajProdCBox.Name = "RodzajProdCBox";
            this.RodzajProdCBox.Size = new System.Drawing.Size(52, 24);
            this.RodzajProdCBox.TabIndex = 17;
            this.RodzajProdCBox.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
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
            this.comboBox3.Location = new System.Drawing.Point(587, 277);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(224, 24);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.SelectedValueChanged += new System.EventHandler(this.comboBox3_SelectedValueChanged);
            // 
            // MetodaKupnaCyfraCBox
            // 
            this.MetodaKupnaCyfraCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MetodaKupnaCyfraCBox.FormattingEnabled = true;
            this.MetodaKupnaCyfraCBox.Items.AddRange(new object[] {
            "0",
            "1"});
            this.MetodaKupnaCyfraCBox.Location = new System.Drawing.Point(484, 423);
            this.MetodaKupnaCyfraCBox.Name = "MetodaKupnaCyfraCBox";
            this.MetodaKupnaCyfraCBox.Size = new System.Drawing.Size(52, 24);
            this.MetodaKupnaCyfraCBox.TabIndex = 19;
            this.MetodaKupnaCyfraCBox.SelectedValueChanged += new System.EventHandler(this.MetodaKupnaCyfraCBox_SelectedValueChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // OpisProdInfo
            // 
            this.OpisProdInfo.Image = ((System.Drawing.Image)(resources.GetObject("OpisProdInfo.Image")));
            this.OpisProdInfo.Location = new System.Drawing.Point(817, 207);
            this.OpisProdInfo.Name = "OpisProdInfo";
            this.OpisProdInfo.Size = new System.Drawing.Size(25, 25);
            this.OpisProdInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OpisProdInfo.TabIndex = 20;
            this.OpisProdInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.OpisProdInfo, "Pole służące do  wpisania opisu produktu.\r\nPole nie może być puste!");
            // 
            // RodzajProdInfo
            // 
            this.RodzajProdInfo.Image = ((System.Drawing.Image)(resources.GetObject("RodzajProdInfo.Image")));
            this.RodzajProdInfo.Location = new System.Drawing.Point(817, 277);
            this.RodzajProdInfo.Name = "RodzajProdInfo";
            this.RodzajProdInfo.Size = new System.Drawing.Size(25, 25);
            this.RodzajProdInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RodzajProdInfo.TabIndex = 21;
            this.RodzajProdInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.RodzajProdInfo, "Pole służące do  zaznaczenia  rodzaju produktu.\r\nW tym polu musi być wybrana opcj" +
        "a!\r\n");
            // 
            // NumerKreskInfo
            // 
            this.NumerKreskInfo.Image = ((System.Drawing.Image)(resources.GetObject("NumerKreskInfo.Image")));
            this.NumerKreskInfo.Location = new System.Drawing.Point(817, 345);
            this.NumerKreskInfo.Name = "NumerKreskInfo";
            this.NumerKreskInfo.Size = new System.Drawing.Size(25, 25);
            this.NumerKreskInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.NumerKreskInfo.TabIndex = 22;
            this.NumerKreskInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.NumerKreskInfo, "Pole służące do  wpisania numeru kreskowego produktu.\r\nPole nie może być puste i " +
        "musi zawierać tylko liczby!\r\n\r\n\r\n");
            // 
            // MetKupnaInfo
            // 
            this.MetKupnaInfo.Image = ((System.Drawing.Image)(resources.GetObject("MetKupnaInfo.Image")));
            this.MetKupnaInfo.Location = new System.Drawing.Point(817, 420);
            this.MetKupnaInfo.Name = "MetKupnaInfo";
            this.MetKupnaInfo.Size = new System.Drawing.Size(25, 25);
            this.MetKupnaInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MetKupnaInfo.TabIndex = 23;
            this.MetKupnaInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.MetKupnaInfo, "Pole służące do  zaznaczenia metody kupna.\r\nPole musi być zaznaczone.\r\n");
            // 
            // CenaSprzedInfo
            // 
            this.CenaSprzedInfo.Image = ((System.Drawing.Image)(resources.GetObject("CenaSprzedInfo.Image")));
            this.CenaSprzedInfo.Location = new System.Drawing.Point(817, 504);
            this.CenaSprzedInfo.Name = "CenaSprzedInfo";
            this.CenaSprzedInfo.Size = new System.Drawing.Size(25, 25);
            this.CenaSprzedInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CenaSprzedInfo.TabIndex = 25;
            this.CenaSprzedInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.CenaSprzedInfo, "Pole służące do  wpisania cen sprzedaży produktu.\r\nPole nie może być puste i musi" +
        " zawierać tylko cyfry!\r\n\r\n");
            // 
            // IloscProduktuInfo
            // 
            this.IloscProduktuInfo.Image = ((System.Drawing.Image)(resources.GetObject("IloscProduktuInfo.Image")));
            this.IloscProduktuInfo.Location = new System.Drawing.Point(817, 612);
            this.IloscProduktuInfo.Name = "IloscProduktuInfo";
            this.IloscProduktuInfo.Size = new System.Drawing.Size(25, 25);
            this.IloscProduktuInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.IloscProduktuInfo.TabIndex = 26;
            this.IloscProduktuInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.IloscProduktuInfo, "Pole służące do  wpisania ilości produktu.\r\nPole nie może być puste i musi zawier" +
        "ać tylko cyfry!\r\n\r\n");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(817, 561);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Pole służące do  wpisania ceny zakupu produktu.\r\nPole nie może być puste i musi z" +
        "awierać tylko cyfry!\r\n\r\n");
            // 
            // DostepnoscButton
            // 
            this.DostepnoscButton.Location = new System.Drawing.Point(560, 701);
            this.DostepnoscButton.Name = "DostepnoscButton";
            this.DostepnoscButton.Size = new System.Drawing.Size(141, 61);
            this.DostepnoscButton.TabIndex = 27;
            this.DostepnoscButton.Text = "Sprawdz Dostępność Produktu";
            this.DostepnoscButton.UseVisualStyleBackColor = true;
            this.DostepnoscButton.Click += new System.EventHandler(this.DostepnoscButton_Click);
            // 
            // CenaZakupuTBox
            // 
            this.CenaZakupuTBox.Location = new System.Drawing.Point(484, 561);
            this.CenaZakupuTBox.Multiline = true;
            this.CenaZakupuTBox.Name = "CenaZakupuTBox";
            this.CenaZakupuTBox.Size = new System.Drawing.Size(327, 25);
            this.CenaZakupuTBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(194, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cena Zakupu Produktu";
            // 
            // AddItemFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1029, 810);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.CenaZakupuTBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DostepnoscButton);
            this.Controls.Add(this.IloscProduktuInfo);
            this.Controls.Add(this.CenaSprzedInfo);
            this.Controls.Add(this.MetKupnaInfo);
            this.Controls.Add(this.NumerKreskInfo);
            this.Controls.Add(this.RodzajProdInfo);
            this.Controls.Add(this.OpisProdInfo);
            this.Controls.Add(this.MetodaKupnaCyfraCBox);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.RodzajProdCBox);
            this.Controls.Add(this.IloscProdTBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AnulujButton);
            this.Controls.Add(this.DodajProduktButton);
            this.Controls.Add(this.CenaSprzedTBox);
            this.Controls.Add(this.MetodaKupnaWyrazCBox);
            this.Controls.Add(this.NumerKreskowyTBox);
            this.Controls.Add(this.OpisProduktuTBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItemFormcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemFormcs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpisProdInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodzajProdInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerKreskInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetKupnaInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenaSprzedInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IloscProduktuInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OpisProduktuTBox;
        private System.Windows.Forms.TextBox NumerKreskowyTBox;
        private System.Windows.Forms.ComboBox MetodaKupnaWyrazCBox;
        private System.Windows.Forms.TextBox CenaSprzedTBox;
        private System.Windows.Forms.Button DodajProduktButton;
        private System.Windows.Forms.Button AnulujButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IloscProdTBox;
        private System.Windows.Forms.ComboBox RodzajProdCBox;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox MetodaKupnaCyfraCBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox OpisProdInfo;
        private System.Windows.Forms.PictureBox RodzajProdInfo;
        private System.Windows.Forms.PictureBox NumerKreskInfo;
        private System.Windows.Forms.PictureBox MetKupnaInfo;
        private System.Windows.Forms.PictureBox CenaSprzedInfo;
        private System.Windows.Forms.PictureBox IloscProduktuInfo;
        private System.Windows.Forms.Button DostepnoscButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox CenaZakupuTBox;
        private System.Windows.Forms.Label label6;
    }
}