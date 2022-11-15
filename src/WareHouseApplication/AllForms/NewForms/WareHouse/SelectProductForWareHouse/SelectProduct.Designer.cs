namespace WareHouseApplication.AllForms.NewForms.WareHouse
{
    partial class SelectProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxSearchByCategory = new System.Windows.Forms.ComboBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.btnClearFilters = new RJCodeAdvance.RJControls.RJButton();
            this.btnSearch = new RJCodeAdvance.RJControls.RJButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegistrationNumberDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraDescriptionDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new RJCodeAdvance.RJControls.RJButton();
            this.btnPick = new RJCodeAdvance.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CBoxSearchByCategory);
            this.panel1.Controls.Add(this.TxtSearch);
            this.panel1.Controls.Add(this.btnClearFilters);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 77);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 462);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Wyszukaj";
            // 
            // CBoxSearchByCategory
            // 
            this.CBoxSearchByCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxSearchByCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBoxSearchByCategory.FormattingEnabled = true;
            this.CBoxSearchByCategory.ItemHeight = 17;
            this.CBoxSearchByCategory.Items.AddRange(new object[] {
            "Wszystko",
            "Numer Ewidencyjny",
            "Nazwa",
            "Rodzaj",
            "Opis",
            "Data Dodania"});
            this.CBoxSearchByCategory.Location = new System.Drawing.Point(181, 29);
            this.CBoxSearchByCategory.Name = "CBoxSearchByCategory";
            this.CBoxSearchByCategory.Size = new System.Drawing.Size(195, 25);
            this.CBoxSearchByCategory.TabIndex = 11;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearch.ForeColor = System.Drawing.Color.Black;
            this.TxtSearch.Location = new System.Drawing.Point(429, 23);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSearch.Multiline = true;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(195, 37);
            this.TxtSearch.TabIndex = 10;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClearFilters.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.btnClearFilters.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClearFilters.BorderRadius = 0;
            this.btnClearFilters.BorderSize = 0;
            this.btnClearFilters.FlatAppearance.BorderSize = 0;
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearFilters.ForeColor = System.Drawing.Color.White;
            this.btnClearFilters.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilters.Image")));
            this.btnClearFilters.Location = new System.Drawing.Point(671, 4);
            this.btnClearFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(46, 69);
            this.btnClearFilters.TabIndex = 12;
            this.btnClearFilters.TextColor = System.Drawing.Color.White;
            this.btnClearFilters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClearFilters.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(723, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 69);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 54;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistrationNumberDG,
            this.NameDG,
            this.TypeDG,
            this.ExtraDescriptionDG});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.DividerHeight = 3;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(782, 454);
            this.dataGridView1.TabIndex = 1;
            // 
            // RegistrationNumberDG
            // 
            this.RegistrationNumberDG.HeaderText = "Numer Ewidencyjny";
            this.RegistrationNumberDG.MinimumWidth = 6;
            this.RegistrationNumberDG.Name = "RegistrationNumberDG";
            this.RegistrationNumberDG.ReadOnly = true;
            this.RegistrationNumberDG.Width = 110;
            // 
            // NameDG
            // 
            this.NameDG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameDG.FillWeight = 110F;
            this.NameDG.HeaderText = "Nazwa";
            this.NameDG.MinimumWidth = 110;
            this.NameDG.Name = "NameDG";
            this.NameDG.ReadOnly = true;
            // 
            // TypeDG
            // 
            this.TypeDG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeDG.FillWeight = 110F;
            this.TypeDG.HeaderText = "Rodzaj";
            this.TypeDG.MinimumWidth = 110;
            this.TypeDG.Name = "TypeDG";
            this.TypeDG.ReadOnly = true;
            // 
            // ExtraDescriptionDG
            // 
            this.ExtraDescriptionDG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExtraDescriptionDG.FillWeight = 110F;
            this.ExtraDescriptionDG.HeaderText = "Opis";
            this.ExtraDescriptionDG.MinimumWidth = 110;
            this.ExtraDescriptionDG.Name = "ExtraDescriptionDG";
            this.ExtraDescriptionDG.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(429, 548);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(195, 50);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPick
            // 
            this.btnPick.BackColor = System.Drawing.SystemColors.Control;
            this.btnPick.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnPick.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPick.BorderRadius = 0;
            this.btnPick.BorderSize = 0;
            this.btnPick.FlatAppearance.BorderSize = 0;
            this.btnPick.ForeColor = System.Drawing.Color.Black;
            this.btnPick.Location = new System.Drawing.Point(181, 548);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(195, 50);
            this.btnPick.TabIndex = 3;
            this.btnPick.Text = "Wybierz";
            this.btnPick.TextColor = System.Drawing.Color.Black;
            this.btnPick.UseVisualStyleBackColor = false;
            // 
            // SelectProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(781, 610);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBoxSearchByCategory;
        private System.Windows.Forms.TextBox TxtSearch;
        private RJCodeAdvance.RJControls.RJButton btnClearFilters;
        private RJCodeAdvance.RJControls.RJButton btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumberDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraDescriptionDG;
        private RJCodeAdvance.RJControls.RJButton btnCancel;
        private RJCodeAdvance.RJControls.RJButton btnPick;
    }
}