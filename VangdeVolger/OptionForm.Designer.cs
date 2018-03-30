﻿namespace VangdeVolger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.LevelSizeTextbox = new System.Windows.Forms.TextBox();
            this.LevelSizeLabel = new System.Windows.Forms.Label();
            this.DifficultylevelLabel = new System.Windows.Forms.Label();
            this.DifficultyListBox = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblWallPercent = new System.Windows.Forms.Label();
            this.tbWallPercent = new System.Windows.Forms.TextBox();
            this.tbBoxPercent = new System.Windows.Forms.TextBox();
            this.lblBoxPercent = new System.Windows.Forms.Label();
            this.tbPowerUpPercent = new System.Windows.Forms.TextBox();
            this.lblPowerUpPercent = new System.Windows.Forms.Label();
            this.ApplyPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LevelSizeTextbox
            // 
            this.LevelSizeTextbox.Location = new System.Drawing.Point(125, 15);
            this.LevelSizeTextbox.Name = "LevelSizeTextbox";
            this.LevelSizeTextbox.Size = new System.Drawing.Size(100, 20);
            this.LevelSizeTextbox.TabIndex = 1;
            this.LevelSizeTextbox.Text = "10";
            // 
            // LevelSizeLabel
            // 
            this.LevelSizeLabel.AutoSize = true;
            this.LevelSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LevelSizeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LevelSizeLabel.Location = new System.Drawing.Point(12, 18);
            this.LevelSizeLabel.Name = "LevelSizeLabel";
            this.LevelSizeLabel.Size = new System.Drawing.Size(56, 13);
            this.LevelSizeLabel.TabIndex = 3;
            this.LevelSizeLabel.Text = "Level Size";
            // 
            // DifficultylevelLabel
            // 
            this.DifficultylevelLabel.AutoSize = true;
            this.DifficultylevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultylevelLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DifficultylevelLabel.Location = new System.Drawing.Point(247, 15);
            this.DifficultylevelLabel.Name = "DifficultylevelLabel";
            this.DifficultylevelLabel.Size = new System.Drawing.Size(72, 13);
            this.DifficultylevelLabel.TabIndex = 6;
            this.DifficultylevelLabel.Text = "Difficulty level";
            // 
            // DifficultyListBox
            // 
            this.DifficultyListBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DifficultyListBox.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyListBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DifficultyListBox.FormattingEnabled = true;
            this.DifficultyListBox.ItemHeight = 15;
            this.DifficultyListBox.Items.AddRange(new object[] {
            "Rogue",
            "Hard",
            "Medium",
            "Easy"});
            this.DifficultyListBox.Location = new System.Drawing.Point(285, 35);
            this.DifficultyListBox.Name = "DifficultyListBox";
            this.DifficultyListBox.Size = new System.Drawing.Size(100, 64);
            this.DifficultyListBox.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton1.Location = new System.Drawing.Point(12, 146);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 19);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Random Starting Position";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblWallPercent
            // 
            this.lblWallPercent.AutoSize = true;
            this.lblWallPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallPercent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWallPercent.Location = new System.Drawing.Point(12, 44);
            this.lblWallPercent.Name = "lblWallPercent";
            this.lblWallPercent.Size = new System.Drawing.Size(39, 13);
            this.lblWallPercent.TabIndex = 9;
            this.lblWallPercent.Text = "% Wall";
            // 
            // tbWallPercent
            // 
            this.tbWallPercent.Location = new System.Drawing.Point(125, 41);
            this.tbWallPercent.Name = "tbWallPercent";
            this.tbWallPercent.Size = new System.Drawing.Size(38, 20);
            this.tbWallPercent.TabIndex = 10;
            this.tbWallPercent.Text = "5";
            // 
            // tbBoxPercent
            // 
            this.tbBoxPercent.Location = new System.Drawing.Point(125, 67);
            this.tbBoxPercent.Name = "tbBoxPercent";
            this.tbBoxPercent.Size = new System.Drawing.Size(38, 20);
            this.tbBoxPercent.TabIndex = 12;
            this.tbBoxPercent.Text = "20";
            // 
            // lblBoxPercent
            // 
            this.lblBoxPercent.AutoSize = true;
            this.lblBoxPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxPercent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBoxPercent.Location = new System.Drawing.Point(12, 70);
            this.lblBoxPercent.Name = "lblBoxPercent";
            this.lblBoxPercent.Size = new System.Drawing.Size(36, 13);
            this.lblBoxPercent.TabIndex = 11;
            this.lblBoxPercent.Text = "% Box";
            // 
            // tbPowerUpPercent
            // 
            this.tbPowerUpPercent.Location = new System.Drawing.Point(125, 93);
            this.tbPowerUpPercent.Name = "tbPowerUpPercent";
            this.tbPowerUpPercent.Size = new System.Drawing.Size(38, 20);
            this.tbPowerUpPercent.TabIndex = 14;
            this.tbPowerUpPercent.Text = "2";
            // 
            // lblPowerUpPercent
            // 
            this.lblPowerUpPercent.AutoSize = true;
            this.lblPowerUpPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerUpPercent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPowerUpPercent.Location = new System.Drawing.Point(12, 96);
            this.lblPowerUpPercent.Name = "lblPowerUpPercent";
            this.lblPowerUpPercent.Size = new System.Drawing.Size(65, 13);
            this.lblPowerUpPercent.TabIndex = 13;
            this.lblPowerUpPercent.Text = "% Power Up";
            // 
            // ApplyPictureBox
            // 
            this.ApplyPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApplyPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ApplyPictureBox.BackgroundImage")));
            this.ApplyPictureBox.Location = new System.Drawing.Point(285, 102);
            this.ApplyPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.ApplyPictureBox.Name = "ApplyPictureBox";
            this.ApplyPictureBox.Size = new System.Drawing.Size(150, 90);
            this.ApplyPictureBox.TabIndex = 15;
            this.ApplyPictureBox.TabStop = false;
            this.ApplyPictureBox.Click += new System.EventHandler(this.ApplyPictureBox_Click);
            // 
            // OptionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 191);
            this.Controls.Add(this.ApplyPictureBox);
            this.Controls.Add(this.tbPowerUpPercent);
            this.Controls.Add(this.lblPowerUpPercent);
            this.Controls.Add(this.tbBoxPercent);
            this.Controls.Add(this.lblBoxPercent);
            this.Controls.Add(this.tbWallPercent);
            this.Controls.Add(this.lblWallPercent);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.DifficultyListBox);
            this.Controls.Add(this.DifficultylevelLabel);
            this.Controls.Add(this.LevelSizeLabel);
            this.Controls.Add(this.LevelSizeTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApplyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LevelSizeTextbox;
        private System.Windows.Forms.Label LevelSizeLabel;
        private System.Windows.Forms.Label DifficultylevelLabel;
        private System.Windows.Forms.ListBox DifficultyListBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblWallPercent;
        private System.Windows.Forms.TextBox tbWallPercent;
        private System.Windows.Forms.TextBox tbBoxPercent;
        private System.Windows.Forms.Label lblBoxPercent;
        private System.Windows.Forms.TextBox tbPowerUpPercent;
        private System.Windows.Forms.Label lblPowerUpPercent;
        private System.Windows.Forms.PictureBox ApplyPictureBox;
    }
}