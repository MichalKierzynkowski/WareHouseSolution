
namespace WareHouseApplication.Forms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnWareHouse = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PicturePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UpPanel.SuspendLayout();
            this.PicturePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanelTitleBar.Controls.Add(this.btnHelp);
            this.PanelTitleBar.Controls.Add(this.btnSettings);
            this.PanelTitleBar.Controls.Add(this.btnSales);
            this.PanelTitleBar.Controls.Add(this.btnWareHouse);
            this.PanelTitleBar.Controls.Add(this.btnProducts);
            this.PanelTitleBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PanelTitleBar.Location = new System.Drawing.Point(0, 249);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(250, 578);
            this.PanelTitleBar.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 240);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(250, 60);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Pomoc";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 180);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(250, 60);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Ustawienia";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSales
            // 
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSales.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 120);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(250, 60);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "Sprzedaż";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnWareHouse
            // 
            this.btnWareHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWareHouse.FlatAppearance.BorderSize = 0;
            this.btnWareHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWareHouse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWareHouse.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWareHouse.Image = ((System.Drawing.Image)(resources.GetObject("btnWareHouse.Image")));
            this.btnWareHouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWareHouse.Location = new System.Drawing.Point(0, 60);
            this.btnWareHouse.Name = "btnWareHouse";
            this.btnWareHouse.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnWareHouse.Size = new System.Drawing.Size(250, 60);
            this.btnWareHouse.TabIndex = 2;
            this.btnWareHouse.Text = "Magazyn";
            this.btnWareHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWareHouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWareHouse.UseVisualStyleBackColor = true;
            this.btnWareHouse.Click += new System.EventHandler(this.btnWareHouse_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 0);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(250, 60);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Produkty";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.UpPanel.Controls.Add(this.label1);
            this.UpPanel.Location = new System.Drawing.Point(248, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(1171, 112);
            this.UpPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(285, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cudeńka - Aplikacja Magazynowa";
            // 
            // PicturePanel
            // 
            this.PicturePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(76)))), ((int)(((byte)(138)))));
            this.PicturePanel.Controls.Add(this.pictureBox1);
            this.PicturePanel.Location = new System.Drawing.Point(0, 0);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(250, 250);
            this.PicturePanel.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1416, 825);
            this.Controls.Add(this.PicturePanel);
            this.Controls.Add(this.UpPanel);
            this.Controls.Add(this.PanelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UpPanel.ResumeLayout(false);
            this.UpPanel.PerformLayout();
            this.PicturePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.FlowLayoutPanel PicturePanel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnWareHouse;
    }
}

