namespace GameIntro.Views
{
    partial class Shop
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
            this.Inventory = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yourInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMoney = new System.Windows.Forms.ToolStripTextBox();
            this.ShopInventory = new System.Windows.Forms.Panel();
            this.Inventory.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inventory
            // 
            this.Inventory.AutoScroll = true;
            this.Inventory.BackColor = System.Drawing.Color.Transparent;
            this.Inventory.Controls.Add(this.menuStrip1);
            this.Inventory.Location = new System.Drawing.Point(685, 23);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(273, 507);
            this.Inventory.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yourInventoryToolStripMenuItem,
            this.toolStripMoney});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(273, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yourInventoryToolStripMenuItem
            // 
            this.yourInventoryToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourInventoryToolStripMenuItem.Name = "yourInventoryToolStripMenuItem";
            this.yourInventoryToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.yourInventoryToolStripMenuItem.Text = "Your inventory:";
            // 
            // toolStripMoney
            // 
            this.toolStripMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStripMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripMoney.Enabled = false;
            this.toolStripMoney.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMoney.Name = "toolStripMoney";
            this.toolStripMoney.Size = new System.Drawing.Size(100, 20);
            this.toolStripMoney.Text = "0";
            this.toolStripMoney.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShopInventory
            // 
            this.ShopInventory.AutoScroll = true;
            this.ShopInventory.BackColor = System.Drawing.Color.Transparent;
            this.ShopInventory.Location = new System.Drawing.Point(58, 23);
            this.ShopInventory.Name = "ShopInventory";
            this.ShopInventory.Size = new System.Drawing.Size(297, 507);
            this.ShopInventory.TabIndex = 16;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameIntro.Properties.Resources.Shop;
            this.ClientSize = new System.Drawing.Size(1119, 553);
            this.Controls.Add(this.ShopInventory);
            this.Controls.Add(this.Inventory);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Shop";
            this.Text = "Shop";
            this.Inventory.ResumeLayout(false);
            this.Inventory.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Inventory;
        private System.Windows.Forms.Panel ShopInventory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yourInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripMoney;
    }
}