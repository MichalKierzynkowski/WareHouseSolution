
namespace WareHouseApplication.Forms
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
            this.wareHouseDataSet = new WareHouseApplication.WareHouseDataSet();
            this.wareHouseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ResetButton = new System.Windows.Forms.Button();
            this.ZapiszProduktyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RodzajProduktuWyrazCBox = new System.Windows.Forms.ComboBox();
            this.RodzajProdCBox = new System.Windows.Forms.ComboBox();
            this.SzukajButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MetodaKupnaCyfraCBox = new System.Windows.Forms.ComboBox();
            this.MetodaKupnaWyrazCBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumerKreskowyTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CenaZakupuCBox = new System.Windows.Forms.ComboBox();
            this.CenaSprzedazCBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1967, 86);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(572, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(678, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Magazyn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(838, 527);
            this.dataGridView1.TabIndex = 1;
            // 
            // wareHouseDataSet
            // 
            this.wareHouseDataSet.DataSetName = "WareHouseDataSet";
            this.wareHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wareHouseDataSetBindingSource
            // 
            this.wareHouseDataSetBindingSource.DataSource = this.wareHouseDataSet;
            this.wareHouseDataSetBindingSource.Position = 0;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResetButton.Location = new System.Drawing.Point(911, 593);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(151, 44);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ZapiszProduktyButton
            // 
            this.ZapiszProduktyButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ZapiszProduktyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZapiszProduktyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZapiszProduktyButton.Location = new System.Drawing.Point(1308, 593);
            this.ZapiszProduktyButton.Name = "ZapiszProduktyButton";
            this.ZapiszProduktyButton.Size = new System.Drawing.Size(177, 44);
            this.ZapiszProduktyButton.TabIndex = 4;
            this.ZapiszProduktyButton.Text = "Zapisz Produkty";
            this.ZapiszProduktyButton.UseVisualStyleBackColor = false;
            this.ZapiszProduktyButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1015, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opcje Sortowania:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(905, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
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
            this.RodzajProduktuWyrazCBox.Location = new System.Drawing.Point(1180, 179);
            this.RodzajProduktuWyrazCBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RodzajProduktuWyrazCBox.Name = "RodzajProduktuWyrazCBox";
            this.RodzajProduktuWyrazCBox.Size = new System.Drawing.Size(169, 21);
            this.RodzajProduktuWyrazCBox.TabIndex = 20;
            this.RodzajProduktuWyrazCBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
            this.RodzajProduktuWyrazCBox.SelectedValueChanged += new System.EventHandler(this.comboBox3_SelectedValueChanged);
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
            this.RodzajProdCBox.Location = new System.Drawing.Point(1122, 179);
            this.RodzajProdCBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RodzajProdCBox.Name = "RodzajProdCBox";
            this.RodzajProdCBox.Size = new System.Drawing.Size(40, 21);
            this.RodzajProdCBox.TabIndex = 19;
            this.RodzajProdCBox.SelectionChangeCommitted += new System.EventHandler(this.RodzajProdCBox_SelectionChangeCommitted);
            this.RodzajProdCBox.SelectedValueChanged += new System.EventHandler(this.RodzajProdCBox_SelectedValueChanged);
            // 
            // SzukajButton
            // 
            this.SzukajButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SzukajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SzukajButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SzukajButton.Location = new System.Drawing.Point(1122, 593);
            this.SzukajButton.Name = "SzukajButton";
            this.SzukajButton.Size = new System.Drawing.Size(151, 44);
            this.SzukajButton.TabIndex = 21;
            this.SzukajButton.Text = "Szukaj";
            this.SzukajButton.UseVisualStyleBackColor = false;
            this.SzukajButton.Click += new System.EventHandler(this.SzukajButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(911, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 30);
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
            this.MetodaKupnaCyfraCBox.Location = new System.Drawing.Point(1122, 250);
            this.MetodaKupnaCyfraCBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MetodaKupnaCyfraCBox.Name = "MetodaKupnaCyfraCBox";
            this.MetodaKupnaCyfraCBox.Size = new System.Drawing.Size(40, 21);
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
            this.MetodaKupnaWyrazCBox.Location = new System.Drawing.Point(1180, 250);
            this.MetodaKupnaWyrazCBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MetodaKupnaWyrazCBox.Name = "MetodaKupnaWyrazCBox";
            this.MetodaKupnaWyrazCBox.Size = new System.Drawing.Size(169, 21);
            this.MetodaKupnaWyrazCBox.TabIndex = 23;
            this.MetodaKupnaWyrazCBox.SelectionChangeCommitted += new System.EventHandler(this.MetodaKupnaWyrazCBox_SelectionChangeCommitted);
            this.MetodaKupnaWyrazCBox.SelectedValueChanged += new System.EventHandler(this.MetodaKupnaWyrazCBox_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(911, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 30);
            this.label5.TabIndex = 25;
            this.label5.Text = "Kod Kreskowy:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumerKreskowyTBox
            // 
            this.NumerKreskowyTBox.Location = new System.Drawing.Point(1122, 324);
            this.NumerKreskowyTBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumerKreskowyTBox.Multiline = true;
            this.NumerKreskowyTBox.Name = "NumerKreskowyTBox";
            this.NumerKreskowyTBox.Size = new System.Drawing.Size(227, 24);
            this.NumerKreskowyTBox.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(911, 384);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 30);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cena Zakupu:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(911, 447);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 30);
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
            this.CenaZakupuCBox.Location = new System.Drawing.Point(1122, 396);
            this.CenaZakupuCBox.Name = "CenaZakupuCBox";
            this.CenaZakupuCBox.Size = new System.Drawing.Size(227, 21);
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
            this.CenaSprzedazCBox.Location = new System.Drawing.Point(1122, 458);
            this.CenaSprzedazCBox.Name = "CenaSprzedazCBox";
            this.CenaSprzedazCBox.Size = new System.Drawing.Size(227, 21);
            this.CenaSprzedazCBox.TabIndex = 32;
            this.CenaSprzedazCBox.SelectionChangeCommitted += new System.EventHandler(this.CenaSprzedazCBox_SelectionChangeCommitted);
            // 
            // ShowWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1497, 689);
            this.Controls.Add(this.CenaSprzedazCBox);
            this.Controls.Add(this.CenaZakupuCBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumerKreskowyTBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MetodaKupnaCyfraCBox);
            this.Controls.Add(this.MetodaKupnaWyrazCBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SzukajButton);
            this.Controls.Add(this.RodzajProduktuWyrazCBox);
            this.Controls.Add(this.RodzajProdCBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ZapiszProduktyButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ShowWareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazyn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource wareHouseDataSetBindingSource;
        private WareHouseDataSet wareHouseDataSet;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ZapiszProduktyButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RodzajProduktuWyrazCBox;
        private System.Windows.Forms.ComboBox RodzajProdCBox;
        private System.Windows.Forms.Button SzukajButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MetodaKupnaCyfraCBox;
        private System.Windows.Forms.ComboBox MetodaKupnaWyrazCBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumerKreskowyTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CenaZakupuCBox;
        private System.Windows.Forms.ComboBox CenaSprzedazCBox;
    }
}