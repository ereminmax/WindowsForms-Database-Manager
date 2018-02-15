namespace SNapp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.задание3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addresesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // задание3ToolStripMenuItem
            // 
            this.задание3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typesToolStripMenuItem,
            this.brandsToolStripMenuItem,
            this.addresesToolStripMenuItem,
            this.paymentsToolStripMenuItem});
            this.задание3ToolStripMenuItem.Name = "задание3ToolStripMenuItem";
            this.задание3ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.задание3ToolStripMenuItem.Text = "Задание 3";
            // 
            // typesToolStripMenuItem
            // 
            this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            this.typesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.typesToolStripMenuItem.Text = "Types";
            this.typesToolStripMenuItem.Click += new System.EventHandler(this.typesToolStripMenuItem_Click);
            // 
            // brandsToolStripMenuItem
            // 
            this.brandsToolStripMenuItem.Name = "brandsToolStripMenuItem";
            this.brandsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.brandsToolStripMenuItem.Text = "Brands";
            this.brandsToolStripMenuItem.Click += new System.EventHandler(this.brandsToolStripMenuItem_Click);
            // 
            // addresesToolStripMenuItem
            // 
            this.addresesToolStripMenuItem.Name = "addresesToolStripMenuItem";
            this.addresesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addresesToolStripMenuItem.Text = "Addreses";
            this.addresesToolStripMenuItem.Click += new System.EventHandler(this.addresesToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.paymentsToolStripMenuItem.Text = "Payments";
            this.paymentsToolStripMenuItem.Click += new System.EventHandler(this.paymentsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 388);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Приложение SNapp DB Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem задание3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addresesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
    }
}

