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
            this.LevelSizeTextboxY = new System.Windows.Forms.TextBox();
            this.LevelSizeLabelX = new System.Windows.Forms.Label();
            this.LevelSizeLabelY = new System.Windows.Forms.Label();
            this.DifficultylevelLabel = new System.Windows.Forms.Label();
            this.DifficultyListBox = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(192, 358);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // LevelSizeTextboxX
            // 
            this.LevelSizeTextboxX.Location = new System.Drawing.Point(101, 15);
            this.LevelSizeTextboxX.Name = "LevelSizeTextboxX";
            this.LevelSizeTextboxX.Size = new System.Drawing.Size(100, 20);
            this.LevelSizeTextboxX.TabIndex = 1;
            // 
            // LevelSizeTextboxY
            // 
            this.LevelSizeTextboxY.Location = new System.Drawing.Point(287, 15);
            this.LevelSizeTextboxY.Name = "LevelSizeTextboxY";
            this.LevelSizeTextboxY.Size = new System.Drawing.Size(100, 20);
            this.LevelSizeTextboxY.TabIndex = 2;
            // 
            // LevelSizeLabelX
            // 
            this.LevelSizeLabelX.AutoSize = true;
            this.LevelSizeLabelX.Location = new System.Drawing.Point(29, 18);
            this.LevelSizeLabelX.Name = "LevelSizeLabelX";
            this.LevelSizeLabelX.Size = new System.Drawing.Size(66, 13);
            this.LevelSizeLabelX.TabIndex = 3;
            this.LevelSizeLabelX.Text = "Level Size X";
            // 
            // LevelSizeLabelY
            // 
            this.LevelSizeLabelY.AutoSize = true;
            this.LevelSizeLabelY.Location = new System.Drawing.Point(215, 18);
            this.LevelSizeLabelY.Name = "LevelSizeLabelY";
            this.LevelSizeLabelY.Size = new System.Drawing.Size(66, 13);
            this.LevelSizeLabelY.TabIndex = 4;
            this.LevelSizeLabelY.Text = "Level Size Y";
            // 
            // DifficultylevelLabel
            // 
            this.DifficultylevelLabel.AutoSize = true;
            this.DifficultylevelLabel.Location = new System.Drawing.Point(23, 51);
            this.DifficultylevelLabel.Name = "DifficultylevelLabel";
            this.DifficultylevelLabel.Size = new System.Drawing.Size(72, 13);
            this.DifficultylevelLabel.TabIndex = 6;
            this.DifficultylevelLabel.Text = "Difficulty level";
            // 
            // DifficultyListBox
            // 
            this.DifficultyListBox.FormattingEnabled = true;
            this.DifficultyListBox.Items.AddRange(new object[] {
            "Rogue",
            "Easy",
            "Medium",
            "Hard"});
            this.DifficultyListBox.Location = new System.Drawing.Point(101, 51);
            this.DifficultyListBox.Name = "DifficultyListBox";
            this.DifficultyListBox.Size = new System.Drawing.Size(100, 56);
            this.DifficultyListBox.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(243, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(144, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Random Starting Position";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 406);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.DifficultyListBox);
            this.Controls.Add(this.DifficultylevelLabel);
            this.Controls.Add(this.LevelSizeLabelY);
            this.Controls.Add(this.LevelSizeLabelX);
            this.Controls.Add(this.LevelSizeTextboxY);
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
        private System.Windows.Forms.TextBox LevelSizeTextboxY;
        private System.Windows.Forms.Label LevelSizeLabelX;
        private System.Windows.Forms.Label LevelSizeLabelY;
        private System.Windows.Forms.Label DifficultylevelLabel;
        private System.Windows.Forms.ListBox DifficultyListBox;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}