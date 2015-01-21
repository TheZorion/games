namespace GameIntro.Views
{
    partial class GameView
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
            this.panelArena = new System.Windows.Forms.Panel();
            this.labelArena = new System.Windows.Forms.Label();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.panelShop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelArena
            // 
            this.panelArena.BackColor = System.Drawing.Color.Transparent;
            this.panelArena.Location = new System.Drawing.Point(478, 205);
            this.panelArena.Name = "panelArena";
            this.panelArena.Size = new System.Drawing.Size(236, 215);
            this.panelArena.TabIndex = 0;
            // 
            // labelArena
            // 
            this.labelArena.AutoSize = true;
            this.labelArena.BackColor = System.Drawing.Color.Transparent;
            this.labelArena.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArena.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelArena.Location = new System.Drawing.Point(565, 182);
            this.labelArena.Name = "labelArena";
            this.labelArena.Size = new System.Drawing.Size(60, 20);
            this.labelArena.TabIndex = 0;
            this.labelArena.Text = "Arena";
            this.labelArena.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.panelPlayer.Location = new System.Drawing.Point(120, 425);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(38, 59);
            this.panelPlayer.TabIndex = 1;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.labelPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPlayer.Location = new System.Drawing.Point(102, 398);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(70, 20);
            this.labelPlayer.TabIndex = 2;
            this.labelPlayer.Text = "Player";
            // 
            // panelShop
            // 
            this.panelShop.BackColor = System.Drawing.Color.Transparent;
            this.panelShop.Location = new System.Drawing.Point(352, 298);
            this.panelShop.Name = "panelShop";
            this.panelShop.Size = new System.Drawing.Size(58, 87);
            this.panelShop.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(354, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shop";
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameIntro.Properties.Resources.landscape;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 579);
            this.Controls.Add(this.labelArena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelShop);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelArena);
            this.Name = "GameView";
            this.Text = "GameView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelArena;
        private System.Windows.Forms.Label labelArena;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Panel panelShop;
        private System.Windows.Forms.Label label1;

    }
}