
namespace WareHouseApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dsfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazynToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprzedażToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsfToolStripMenuItem,
            this.magazynToolStripMenuItem,
            this.sprzedażToolStripMenuItem,
            this.wyjścieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1250, 56);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dsfToolStripMenuItem
            // 
            this.dsfToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dsfToolStripMenuItem.Image")));
            this.dsfToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dsfToolStripMenuItem.Name = "dsfToolStripMenuItem";
            this.dsfToolStripMenuItem.Size = new System.Drawing.Size(128, 52);
            this.dsfToolStripMenuItem.Text = "Program";
            // 
            // magazynToolStripMenuItem
            // 
            this.magazynToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("magazynToolStripMenuItem.Image")));
            this.magazynToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.magazynToolStripMenuItem.Name = "magazynToolStripMenuItem";
            this.magazynToolStripMenuItem.Size = new System.Drawing.Size(131, 52);
            this.magazynToolStripMenuItem.Text = "Magazyn";
            // 
            // sprzedażToolStripMenuItem
            // 
            this.sprzedażToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sprzedażToolStripMenuItem.Image")));
            this.sprzedażToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sprzedażToolStripMenuItem.Name = "sprzedażToolStripMenuItem";
            this.sprzedażToolStripMenuItem.Size = new System.Drawing.Size(132, 52);
            this.sprzedażToolStripMenuItem.Text = "Sprzedaż";
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("wyjścieToolStripMenuItem.Image")));
            this.wyjścieToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(121, 52);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 837);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dsfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazynToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprzedażToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
    }
}

