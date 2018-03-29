namespace VangdeVolger
{
    partial class OptionForm
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
            this.ApplyButton = new System.Windows.Forms.Button();
            this.LevelSizeTextboxX = new System.Windows.Forms.TextBox();
            this.LevelSizeLabelX = new System.Windows.Forms.Label();
            this.DifficultylevelLabel = new System.Windows.Forms.Label();
            this.DifficultyListBox = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblWallPercent = new System.Windows.Forms.Label();
            this.tbWallPercent = new System.Windows.Forms.TextBox();
            this.tbBoxPercent = new System.Windows.Forms.TextBox();
            this.lblBoxPercent = new System.Windows.Forms.Label();
            this.tbPowerUpPercent = new System.Windows.Forms.TextBox();
            this.lblPowerUpPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(382, 171);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // LevelSizeTextboxX
            // 
            this.LevelSizeTextboxX.Location = new System.Drawing.Point(125, 14);
            this.LevelSizeTextboxX.Name = "LevelSizeTextboxX";
            this.LevelSizeTextboxX.Size = new System.Drawing.Size(100, 20);
            this.LevelSizeTextboxX.TabIndex = 1;
            // 
            // LevelSizeLabelX
            // 
            this.LevelSizeLabelX.AutoSize = true;
            this.LevelSizeLabelX.Font = new System.Drawing.Font("8BIT WONDER", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelSizeLabelX.ForeColor = System.Drawing.SystemColors.Control;
            this.LevelSizeLabelX.Location = new System.Drawing.Point(14, 17);
            this.LevelSizeLabelX.Name = "LevelSizeLabelX";
            this.LevelSizeLabelX.Size = new System.Drawing.Size(105, 11);
            this.LevelSizeLabelX.TabIndex = 3;
            this.LevelSizeLabelX.Text = "Level Size";
            // 
            // DifficultylevelLabel
            // 
            this.DifficultylevelLabel.AutoSize = true;
            this.DifficultylevelLabel.Font = new System.Drawing.Font("8BIT WONDER", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultylevelLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DifficultylevelLabel.Location = new System.Drawing.Point(185, 128);
            this.DifficultylevelLabel.Name = "DifficultylevelLabel";
            this.DifficultylevelLabel.Size = new System.Drawing.Size(166, 11);
            this.DifficultylevelLabel.TabIndex = 6;
            this.DifficultylevelLabel.Text = "Difficulty level";
            // 
            // DifficultyListBox
            // 
            this.DifficultyListBox.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyListBox.FormattingEnabled = true;
            this.DifficultyListBox.ItemHeight = 14;
            this.DifficultyListBox.Items.AddRange(new object[] {
            "Rogue",
            "Hard",
            "Medium",
            "Easy"});
            this.DifficultyListBox.Location = new System.Drawing.Point(357, 106);
            this.DifficultyListBox.Name = "DifficultyListBox";
            this.DifficultyListBox.Size = new System.Drawing.Size(100, 60);
            this.DifficultyListBox.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton1.Location = new System.Drawing.Point(141, 172);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(235, 22);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Random Starting Position";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblWallPercent
            // 
            this.lblWallPercent.AutoSize = true;
            this.lblWallPercent.Font = new System.Drawing.Font("8BIT WONDER", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallPercent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWallPercent.Location = new System.Drawing.Point(49, 53);
            this.lblWallPercent.Name = "lblWallPercent";
            this.lblWallPercent.Size = new System.Drawing.Size(68, 11);
            this.lblWallPercent.TabIndex = 9;
            this.lblWallPercent.Text = "% Wall";
            // 
            // tbWallPercent
            // 
            this.tbWallPercent.Location = new System.Drawing.Point(125, 50);
            this.tbWallPercent.Name = "tbWallPercent";
            this.tbWallPercent.Size = new System.Drawing.Size(38, 20);
            this.tbWallPercent.TabIndex = 10;
            // 
            // tbBoxPercent
            // 
            this.tbBoxPercent.Location = new System.Drawing.Point(125, 79);
            this.tbBoxPercent.Name = "tbBoxPercent";
            this.tbBoxPercent.Size = new System.Drawing.Size(38, 20);
            this.tbBoxPercent.TabIndex = 12;
            // 
            // lblBoxPercent
            // 
            this.lblBoxPercent.AutoSize = true;
            this.lblBoxPercent.Font = new System.Drawing.Font("8BIT WONDER", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxPercent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBoxPercent.Location = new System.Drawing.Point(66, 84);
            this.lblBoxPercent.Name = "lblBoxPercent";
            this.lblBoxPercent.Size = new System.Drawing.Size(51, 11);
            this.lblBoxPercent.TabIndex = 11;
            this.lblBoxPercent.Text = "% Box";
            // 
            // tbPowerUpPercent
            // 
            this.tbPowerUpPercent.Location = new System.Drawing.Point(125, 107);
            this.tbPowerUpPercent.Name = "tbPowerUpPercent";
            this.tbPowerUpPercent.Size = new System.Drawing.Size(38, 20);
            this.tbPowerUpPercent.TabIndex = 14;
            // 
            // lblPowerUpPercent
            // 
            this.lblPowerUpPercent.AutoSize = true;
            this.lblPowerUpPercent.Font = new System.Drawing.Font("8BIT WONDER", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerUpPercent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPowerUpPercent.Location = new System.Drawing.Point(12, 111);
            this.lblPowerUpPercent.Name = "lblPowerUpPercent";
            this.lblPowerUpPercent.Size = new System.Drawing.Size(107, 11);
            this.lblPowerUpPercent.TabIndex = 13;
            this.lblPowerUpPercent.Text = "% Power Up";
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 212);
            this.Controls.Add(this.tbPowerUpPercent);
            this.Controls.Add(this.lblPowerUpPercent);
            this.Controls.Add(this.tbBoxPercent);
            this.Controls.Add(this.lblBoxPercent);
            this.Controls.Add(this.tbWallPercent);
            this.Controls.Add(this.lblWallPercent);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.DifficultyListBox);
            this.Controls.Add(this.DifficultylevelLabel);
            this.Controls.Add(this.LevelSizeLabelX);
            this.Controls.Add(this.LevelSizeTextboxX);
            this.Controls.Add(this.ApplyButton);
            this.Name = "OptionForm";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TextBox LevelSizeTextboxX;
        private System.Windows.Forms.Label LevelSizeLabelX;
        private System.Windows.Forms.Label DifficultylevelLabel;
        private System.Windows.Forms.ListBox DifficultyListBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblWallPercent;
        private System.Windows.Forms.TextBox tbWallPercent;
        private System.Windows.Forms.TextBox tbBoxPercent;
        private System.Windows.Forms.Label lblBoxPercent;
        private System.Windows.Forms.TextBox tbPowerUpPercent;
        private System.Windows.Forms.Label lblPowerUpPercent;
    }
}