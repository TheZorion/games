namespace GameIntro.Views
{
    partial class InventoryItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Description = new System.Windows.Forms.Label();
            this.DamageArmor = new System.Windows.Forms.Label();
            this.Special = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(16, 11);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(0, 13);
            this.Description.TabIndex = 0;
            // 
            // DamageArmor
            // 
            this.DamageArmor.AutoSize = true;
            this.DamageArmor.Location = new System.Drawing.Point(16, 39);
            this.DamageArmor.Name = "DamageArmor";
            this.DamageArmor.Size = new System.Drawing.Size(0, 13);
            this.DamageArmor.TabIndex = 1;
            // 
            // Special
            // 
            this.Special.AutoSize = true;
            this.Special.Location = new System.Drawing.Point(134, 39);
            this.Special.Name = "Special";
            this.Special.Size = new System.Drawing.Size(0, 13);
            this.Special.TabIndex = 2;
            // 
            // InventoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Special);
            this.Controls.Add(this.DamageArmor);
            this.Controls.Add(this.Description);
            this.Name = "InventoryItem";
            this.Size = new System.Drawing.Size(279, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label DamageArmor;
        private System.Windows.Forms.Label Special;
    }
}
