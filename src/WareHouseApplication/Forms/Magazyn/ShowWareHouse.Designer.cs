
namespace WareHouseApplication.Forms.Magazyn
{
    partial class ShowWareHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowWareHouse));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wareHouseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ResetButton = new System.Windows.Forms.Button();
            this.ZapiszProduktyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RodzajProduktuWyrazCBox = new System.Windows.Forms.ComboBox();
            this.RodzajProdCBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MetodaKupnaCyfraCBox = new System.Windows.Forms.ComboBox();
            this.MetodaKupnaWyrazCBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CenaZakupuCBox = new System.Windows.Forms.ComboBox();
            this.CenaSprzedazCBox = new System.Windows.Forms.ComboBox();
            this.IsReturnedComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BarNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarNumberNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2295, 99);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(666, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(791, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Magazyn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 127);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 608);
            this.dataGridView1.TabIndex = 1;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(1120, 684);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(176, 51);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ZapiszProduktyButton
            // 
            this.ZapiszProduktyButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ZapiszProduktyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZapiszProduktyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ZapiszProduktyButton.Location = new System.Drawing.Point(1551, 684);
            this.ZapiszProduktyButton.Margin = new System.Windows.Forms.Padding(4);
            this.ZapiszProduktyButton.Name = "ZapiszProduktyButton";
            this.ZapiszProduktyButton.Size = new System.Drawing.Size(206, 51);
            this.ZapiszProduktyButton.TabIndex = 4;
            this.ZapiszProduktyButton.Text = "Zapisz Produkty";
            this.ZapiszProduktyButton.UseVisualStyleBackColor = false;
            this.ZapiszProduktyButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1184, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opcje Sortowania:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1114, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rodzaj Produktu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.RodzajProduktuWyrazCBox.Location = new System.Drawing.Point(1435, 185);
            this.RodzajProduktuWyrazCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RodzajProduktuWyrazCBox.Name = "RodzajProduktuWyrazCBox";
            this.RodzajProduktuWyrazCBox.Size = new System.Drawing.Size(196, 23);
            this.RodzajProduktuWyrazCBox.TabIndex = 20;
            this.RodzajProduktuWyrazCBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
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
            this.RodzajProdCBox.Location = new System.Drawing.Point(1368, 185);
            this.RodzajProdCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RodzajProdCBox.Name = "RodzajProdCBox";
            this.RodzajProdCBox.Size = new System.Drawing.Size(46, 23);
            this.RodzajProdCBox.TabIndex = 19;
            this.RodzajProdCBox.SelectionChangeCommitted += new System.EventHandler(this.RodzajProdCBox_SelectionChangeCommitted);
            this.RodzajProdCBox.SelectedValueChanged += new System.EventHandler(this.RodzajProdCBox_SelectedValueChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(1336, 684);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(176, 51);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "Szukaj";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SzukajButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1121, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Metoda Zakupu:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MetodaKupnaCyfraCBox
            // 
            this.MetodaKupnaCyfraCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MetodaKupnaCyfraCBox.FormattingEnabled = true;
            this.MetodaKupnaCyfraCBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.MetodaKupnaCyfraCBox.Location = new System.Drawing.Point(1368, 267);
            this.MetodaKupnaCyfraCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MetodaKupnaCyfraCBox.Name = "MetodaKupnaCyfraCBox";
            this.MetodaKupnaCyfraCBox.Size = new System.Drawing.Size(46, 23);
            this.MetodaKupnaCyfraCBox.TabIndex = 24;
            this.MetodaKupnaCyfraCBox.SelectionChangeCommitted += new System.EventHandler(this.MetodaKupnaCyfraCBox_SelectionChangeCommitted);
            this.MetodaKupnaCyfraCBox.SelectedValueChanged += new System.EventHandler(this.MetodaKupnaCyfraCBox_SelectedValueChanged);
            // 
            // MetodaKupnaWyrazCBox
            // 
            this.MetodaKupnaWyrazCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MetodaKupnaWyrazCBox.FormattingEnabled = true;
            this.MetodaKupnaWyrazCBox.Items.AddRange(new object[] {
            "Faktura",
            "Paragon"});
            this.MetodaKupnaWyrazCBox.Location = new System.Drawing.Point(1435, 267);
            this.MetodaKupnaWyrazCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MetodaKupnaWyrazCBox.Name = "MetodaKupnaWyrazCBox";
            this.MetodaKupnaWyrazCBox.Size = new System.Drawing.Size(196, 23);
            this.MetodaKupnaWyrazCBox.TabIndex = 23;
            this.MetodaKupnaWyrazCBox.SelectionChangeCommitted += new System.EventHandler(this.MetodaKupnaWyrazCBox_SelectionChangeCommitted);
            this.MetodaKupnaWyrazCBox.SelectedValueChanged += new System.EventHandler(this.MetodaKupnaWyrazCBox_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1121, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Numer Ewidencyjny:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1121, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cena Zakupu:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1121, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cena Sprzedaży:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CenaZakupuCBox
            // 
            this.CenaZakupuCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CenaZakupuCBox.FormattingEnabled = true;
            this.CenaZakupuCBox.Items.AddRange(new object[] {
            "Od najmniejszej do największej",
            "Od najwiekszej do najmniejszej"});
            this.CenaZakupuCBox.Location = new System.Drawing.Point(1368, 436);
            this.CenaZakupuCBox.Margin = new System.Windows.Forms.Padding(4);
            this.CenaZakupuCBox.Name = "CenaZakupuCBox";
            this.CenaZakupuCBox.Size = new System.Drawing.Size(264, 23);
            this.CenaZakupuCBox.TabIndex = 31;
            this.CenaZakupuCBox.SelectionChangeCommitted += new System.EventHandler(this.CenaZakupuCBox_SelectionChangeCommitted);
            // 
            // CenaSprzedazCBox
            // 
            this.CenaSprzedazCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CenaSprzedazCBox.FormattingEnabled = true;
            this.CenaSprzedazCBox.Items.AddRange(new object[] {
            "Od najmniejszej do największej",
            "Od najwiekszej do najmniejszej"});
            this.CenaSprzedazCBox.Location = new System.Drawing.Point(1368, 493);
            this.CenaSprzedazCBox.Margin = new System.Windows.Forms.Padding(4);
            this.CenaSprzedazCBox.Name = "CenaSprzedazCBox";
            this.CenaSprzedazCBox.Size = new System.Drawing.Size(264, 23);
            this.CenaSprzedazCBox.TabIndex = 32;
            this.CenaSprzedazCBox.SelectionChangeCommitted += new System.EventHandler(this.CenaSprzedazCBox_SelectionChangeCommitted);
            // 
            // IsReturnedComboBox
            // 
            this.IsReturnedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsReturnedComboBox.FormattingEnabled = true;
            this.IsReturnedComboBox.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.IsReturnedComboBox.Location = new System.Drawing.Point(1368, 561);
            this.IsReturnedComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.IsReturnedComboBox.Name = "IsReturnedComboBox";
            this.IsReturnedComboBox.Size = new System.Drawing.Size(264, 23);
            this.IsReturnedComboBox.TabIndex = 34;
            this.IsReturnedComboBox.SelectionChangeCommitted += new System.EventHandler(this.IsReturnedComboBox_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1121, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Towar Zwrócony:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Od najmniejszej do największej",
            "Od najwiekszej do najmniejszej"});
            this.comboBox1.Location = new System.Drawing.Point(1368, 613);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 23);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1123, 606);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ilość:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarNumberNumeric
            // 
            this.BarNumberNumeric.Location = new System.Drawing.Point(1368, 349);
            this.BarNumberNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BarNumberNumeric.Name = "BarNumberNumeric";
            this.BarNumberNumeric.Size = new System.Drawing.Size(263, 23);
            this.BarNumberNumeric.TabIndex = 37;
            // 
            // ShowWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1872, 795);
            this.Controls.Add(this.BarNumberNumeric);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IsReturnedComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CenaSprzedazCBox);
            this.Controls.Add(this.CenaZakupuCBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MetodaKupnaCyfraCBox);
            this.Controls.Add(this.MetodaKupnaWyrazCBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RodzajProduktuWyrazCBox);
            this.Controls.Add(this.RodzajProdCBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ZapiszProduktyButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ShowWareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazyn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarNumberNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource wareHouseDataSetBindingSource;
      
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ZapiszProduktyButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RodzajProduktuWyrazCBox;
        private System.Windows.Forms.ComboBox RodzajProdCBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MetodaKupnaCyfraCBox;
        private System.Windows.Forms.ComboBox MetodaKupnaWyrazCBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CenaZakupuCBox;
        private System.Windows.Forms.ComboBox CenaSprzedazCBox;
        private System.Windows.Forms.ComboBox IsReturnedComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown BarNumberNumeric;
    }
}