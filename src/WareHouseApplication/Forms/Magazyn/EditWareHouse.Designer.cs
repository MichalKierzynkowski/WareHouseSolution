
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
            this.BuyMethodWordCBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductTypeWordCBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductDescriptionTBox = new System.Windows.Forms.TextBox();
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
            this.label10 = new System.Windows.Forms.Label();
            this.BuyMethodIdNumberBox = new System.Windows.Forms.ComboBox();
            this.BuyMethodWordBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ProductTypeSortWordBox = new System.Windows.Forms.ComboBox();
            this.ProductTypeIdNumberCBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.BarNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarNumberNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 94);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 9);
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
            this.label1.Location = new System.Drawing.Point(516, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Edytuj Magazyn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 510);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1314, 318);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BuyMethodWordCBox
            // 
            this.BuyMethodWordCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuyMethodWordCBox.FormattingEnabled = true;
            this.BuyMethodWordCBox.Items.AddRange(new object[] {
            "Faktura",
            "Paragon"});
            this.BuyMethodWordCBox.Location = new System.Drawing.Point(228, 264);
            this.BuyMethodWordCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuyMethodWordCBox.Name = "BuyMethodWordCBox";
            this.BuyMethodWordCBox.Size = new System.Drawing.Size(217, 23);
            this.BuyMethodWordCBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Metoda Zakupu:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductTypeWordCBox
            // 
            this.ProductTypeWordCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductTypeWordCBox.FormattingEnabled = true;
            this.ProductTypeWordCBox.Items.AddRange(new object[] {
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
            this.ProductTypeWordCBox.Location = new System.Drawing.Point(228, 198);
            this.ProductTypeWordCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductTypeWordCBox.Name = "ProductTypeWordCBox";
            this.ProductTypeWordCBox.Size = new System.Drawing.Size(217, 23);
            this.ProductTypeWordCBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Rodzaj Produktu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductDescriptionTBox
            // 
            this.ProductDescriptionTBox.Location = new System.Drawing.Point(228, 323);
            this.ProductDescriptionTBox.Multiline = true;
            this.ProductDescriptionTBox.Name = "ProductDescriptionTBox";
            this.ProductDescriptionTBox.Size = new System.Drawing.Size(217, 23);
            this.ProductDescriptionTBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Opis Produktu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(518, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ilość:";
            // 
            // AmountNumeric
            // 
            this.AmountNumeric.Location = new System.Drawing.Point(667, 199);
            this.AmountNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AmountNumeric.Name = "AmountNumeric";
            this.AmountNumeric.Size = new System.Drawing.Size(98, 23);
            this.AmountNumeric.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(477, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Cena Zakupu:";
            // 
            // BuyPriceNumeric
            // 
            this.BuyPriceNumeric.Location = new System.Drawing.Point(667, 274);
            this.BuyPriceNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BuyPriceNumeric.Name = "BuyPriceNumeric";
            this.BuyPriceNumeric.Size = new System.Drawing.Size(98, 23);
            this.BuyPriceNumeric.TabIndex = 37;
            // 
            // SellPriceNumeric
            // 
            this.SellPriceNumeric.Location = new System.Drawing.Point(667, 326);
            this.SellPriceNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SellPriceNumeric.Name = "SellPriceNumeric";
            this.SellPriceNumeric.Size = new System.Drawing.Size(98, 23);
            this.SellPriceNumeric.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(477, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Cena Sprzedaży:";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(284, 409);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(123, 57);
            this.EditButton.TabIndex = 42;
            this.EditButton.Text = "Edytuj";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SortingButton
            // 
            this.SortingButton.Location = new System.Drawing.Point(1186, 409);
            this.SortingButton.Name = "SortingButton";
            this.SortingButton.Size = new System.Drawing.Size(123, 57);
            this.SortingButton.TabIndex = 41;
            this.SortingButton.Text = "Sortuj";
            this.SortingButton.UseVisualStyleBackColor = true;
            this.SortingButton.Click += new System.EventHandler(this.SortingButton_Click);
            // 
            // DeletButton
            // 
            this.DeletButton.Location = new System.Drawing.Point(155, 409);
            this.DeletButton.Name = "DeletButton";
            this.DeletButton.Size = new System.Drawing.Size(123, 57);
            this.DeletButton.TabIndex = 40;
            this.DeletButton.Text = "Usuń";
            this.DeletButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(326, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 32);
            this.label8.TabIndex = 43;
            this.label8.Text = "Opcje Edycji:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(993, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 32);
            this.label9.TabIndex = 44;
            this.label9.Text = "Opcje Sortowania:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.CausesValidation = false;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(864, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 25);
            this.label10.TabIndex = 51;
            this.label10.Text = "Kod Kreskowy:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyMethodIdNumberBox
            // 
            this.BuyMethodIdNumberBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuyMethodIdNumberBox.FormattingEnabled = true;
            this.BuyMethodIdNumberBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.BuyMethodIdNumberBox.Location = new System.Drawing.Point(1078, 266);
            this.BuyMethodIdNumberBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuyMethodIdNumberBox.Name = "BuyMethodIdNumberBox";
            this.BuyMethodIdNumberBox.Size = new System.Drawing.Size(45, 23);
            this.BuyMethodIdNumberBox.TabIndex = 50;
            // 
            // BuyMethodWordBox
            // 
            this.BuyMethodWordBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuyMethodWordBox.FormattingEnabled = true;
            this.BuyMethodWordBox.Items.AddRange(new object[] {
            "Faktura",
            "Paragon"});
            this.BuyMethodWordBox.Location = new System.Drawing.Point(1153, 270);
            this.BuyMethodWordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuyMethodWordBox.Name = "BuyMethodWordBox";
            this.BuyMethodWordBox.Size = new System.Drawing.Size(156, 23);
            this.BuyMethodWordBox.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.CausesValidation = false;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(864, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 25);
            this.label11.TabIndex = 48;
            this.label11.Text = "Metoda Zakupu:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductTypeSortWordBox
            // 
            this.ProductTypeSortWordBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductTypeSortWordBox.FormattingEnabled = true;
            this.ProductTypeSortWordBox.Items.AddRange(new object[] {
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
            this.ProductTypeSortWordBox.Location = new System.Drawing.Point(1153, 198);
            this.ProductTypeSortWordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductTypeSortWordBox.Name = "ProductTypeSortWordBox";
            this.ProductTypeSortWordBox.Size = new System.Drawing.Size(156, 23);
            this.ProductTypeSortWordBox.TabIndex = 47;
            this.ProductTypeSortWordBox.SelectionChangeCommitted += new System.EventHandler(this.ProductTypeSortWordBox_SelectionChangeCommitted);
            // 
            // ProductTypeIdNumberCBox
            // 
            this.ProductTypeIdNumberCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductTypeIdNumberCBox.FormattingEnabled = true;
            this.ProductTypeIdNumberCBox.Items.AddRange(new object[] {
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
            this.ProductTypeIdNumberCBox.Location = new System.Drawing.Point(1078, 198);
            this.ProductTypeIdNumberCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductTypeIdNumberCBox.Name = "ProductTypeIdNumberCBox";
            this.ProductTypeIdNumberCBox.Size = new System.Drawing.Size(45, 23);
            this.ProductTypeIdNumberCBox.TabIndex = 46;
            this.ProductTypeIdNumberCBox.SelectionChangeCommitted += new System.EventHandler(this.RodzajProdSortowanieCyfraCBox_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.CausesValidation = false;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(864, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 25);
            this.label12.TabIndex = 45;
            this.label12.Text = "Rodzaj Produktu:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(816, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 339);
            this.panel2.TabIndex = 53;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(1057, 409);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(123, 57);
            this.ResetButton.TabIndex = 54;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(412, 409);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(123, 57);
            this.SaveChangesButton.TabIndex = 55;
            this.SaveChangesButton.Text = "Zatwierdź Zmiany";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            // 
            // BarNumberNumeric
            // 
            this.BarNumberNumeric.Location = new System.Drawing.Point(1078, 330);
            this.BarNumberNumeric.Name = "BarNumberNumeric";
            this.BarNumberNumeric.Size = new System.Drawing.Size(231, 23);
            this.BarNumberNumeric.TabIndex = 56;
            // 
            // EditWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1349, 842);
            this.Controls.Add(this.BarNumberNumeric);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BuyMethodIdNumberBox);
            this.Controls.Add(this.BuyMethodWordBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ProductTypeSortWordBox);
            this.Controls.Add(this.ProductTypeIdNumberCBox);
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
            this.Controls.Add(this.ProductDescriptionTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuyMethodWordCBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductTypeWordCBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.BarNumberNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox BuyMethodWordCBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProductTypeWordCBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductDescriptionTBox;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox BuyMethodIdNumberBox;
        private System.Windows.Forms.ComboBox BuyMethodWordBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ProductTypeSortWordBox;
        private System.Windows.Forms.ComboBox ProductTypeIdNumberCBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.NumericUpDown BarNumberNumeric;
    }
}