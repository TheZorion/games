namespace GameIntro.Views
{
    partial class Arena
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
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panelMonsters = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.panelPlayer.Location = new System.Drawing.Point(463, 425);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(198, 217);
            this.panelPlayer.TabIndex = 0;
            // 
            // panelMonsters
            // 
            this.panelMonsters.BackColor = System.Drawing.Color.Transparent;
            this.panelMonsters.Location = new System.Drawing.Point(158, 104);
            this.panelMonsters.Name = "panelMonsters";
            this.panelMonsters.Size = new System.Drawing.Size(835, 223);
            this.panelMonsters.TabIndex = 1;
            // 
            // Arena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameIntro.Properties.Resources.arena;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 680);
            this.Controls.Add(this.panelMonsters);
            this.Controls.Add(this.panelPlayer);
            this.Name = "Arena";
            this.Text = "Arena";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelMonsters;
    }
}