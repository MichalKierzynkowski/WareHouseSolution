
namespace WareHouseApplication.Alert
{
    partial class Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
            this.label1 = new System.Windows.Forms.Label();
            this.TekstowyButton = new System.Windows.Forms.Button();
            this.ExcelButton = new System.Windows.Forms.Button();
            this.AnulujButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(61, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz Format Zapisu!";
            // 
            // TekstowyButton
            // 
            this.TekstowyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.TekstowyButton.Location = new System.Drawing.Point(346, 150);
            this.TekstowyButton.Name = "TekstowyButton";
            this.TekstowyButton.Size = new System.Drawing.Size(116, 47);
            this.TekstowyButton.TabIndex = 3;
            this.TekstowyButton.Text = "Plik Tekstowy";
            this.TekstowyButton.UseVisualStyleBackColor = true;
            this.TekstowyButton.Click += new System.EventHandler(this.TekstowyButton_Click);
            // 
            // ExcelButton
            // 
            this.ExcelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.ExcelButton.Location = new System.Drawing.Point(202, 150);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(116, 47);
            this.ExcelButton.TabIndex = 4;
            this.ExcelButton.Text = "Excel";
            this.ExcelButton.UseVisualStyleBackColor = true;
            this.ExcelButton.Click += new System.EventHandler(this.ExcelButton_Click);
            // 
            // AnulujButton
            // 
            this.AnulujButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.AnulujButton.Location = new System.Drawing.Point(68, 150);
            this.AnulujButton.Name = "AnulujButton";
            this.AnulujButton.Size = new System.Drawing.Size(116, 47);
            this.AnulujButton.TabIndex = 5;
            this.AnulujButton.Text = "Anuluj";
            this.AnulujButton.UseVisualStyleBackColor = true;
            this.AnulujButton.Click += new System.EventHandler(this.AnulujButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 231);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AnulujButton);
            this.Controls.Add(this.ExcelButton);
            this.Controls.Add(this.TekstowyButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TekstowyButton;
        private System.Windows.Forms.Button ExcelButton;
        private System.Windows.Forms.Button AnulujButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}