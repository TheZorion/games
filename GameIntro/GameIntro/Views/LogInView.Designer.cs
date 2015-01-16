namespace GameIntro.Views
{
    partial class LogInView
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.ClassList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(87, 95);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(155, 44);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(87, 33);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(192, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(27, 36);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(27, 66);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(32, 13);
            this.ClassLabel.TabIndex = 5;
            this.ClassLabel.Text = "Class";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(3, 96);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(154, 44);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(163, 96);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(154, 44);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(87, 39);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(155, 44);
            this.NewGameButton.TabIndex = 8;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // ClassList
            // 
            this.ClassList.FormattingEnabled = true;
            this.ClassList.Location = new System.Drawing.Point(87, 63);
            this.ClassList.Name = "ClassList";
            this.ClassList.Size = new System.Drawing.Size(189, 21);
            this.ClassList.TabIndex = 9;
            // 
            // LogInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 202);
            this.Controls.Add(this.ClassList);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.LoadButton);
            this.Name = "LogInView";
            this.Text = "LogInView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.ComboBox ClassList;
    }
}