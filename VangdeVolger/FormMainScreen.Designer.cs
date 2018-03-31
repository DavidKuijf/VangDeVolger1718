namespace VangdeVolger
{
    partial class FormMainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainScreen));
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.OptionPictureBox = new System.Windows.Forms.PictureBox();
            this.PausePictureBox = new System.Windows.Forms.PictureBox();
            this.ResetPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.QuitPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OptionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PausePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(479, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(35, 19);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Timer";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // OptionPictureBox
            // 
            this.OptionPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OptionPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OptionPictureBox.BackgroundImage")));
            this.OptionPictureBox.Location = new System.Drawing.Point(0, 180);
            this.OptionPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.OptionPictureBox.Name = "OptionPictureBox";
            this.OptionPictureBox.Size = new System.Drawing.Size(150, 90);
            this.OptionPictureBox.TabIndex = 4;
            this.OptionPictureBox.TabStop = false;
            this.OptionPictureBox.Visible = false;
            this.OptionPictureBox.Click += new System.EventHandler(this.OptionpictureBox_Click);
            // 
            // PausePictureBox
            // 
            this.PausePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PausePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PausePictureBox.BackgroundImage")));
            this.PausePictureBox.Location = new System.Drawing.Point(0, 90);
            this.PausePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.PausePictureBox.Name = "PausePictureBox";
            this.PausePictureBox.Size = new System.Drawing.Size(150, 90);
            this.PausePictureBox.TabIndex = 3;
            this.PausePictureBox.TabStop = false;
            this.PausePictureBox.Visible = false;
            this.PausePictureBox.Click += new System.EventHandler(this.PausePictureBox_Click);
            // 
            // ResetPictureBox
            // 
            this.ResetPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResetPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetPictureBox.BackgroundImage")));
            this.ResetPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ResetPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.ResetPictureBox.Name = "ResetPictureBox";
            this.ResetPictureBox.Size = new System.Drawing.Size(150, 90);
            this.ResetPictureBox.TabIndex = 2;
            this.ResetPictureBox.TabStop = false;
            this.ResetPictureBox.Visible = false;
            this.ResetPictureBox.Click += new System.EventHandler(this.ResetPictureBox_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.Black;
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(984, 961);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            // 
            // QuitPictureBox
            // 
            this.QuitPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QuitPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuitPictureBox.BackgroundImage")));
            this.QuitPictureBox.Location = new System.Drawing.Point(0, 270);
            this.QuitPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.QuitPictureBox.Name = "QuitPictureBox";
            this.QuitPictureBox.Size = new System.Drawing.Size(150, 90);
            this.QuitPictureBox.TabIndex = 5;
            this.QuitPictureBox.TabStop = false;
            this.QuitPictureBox.Visible = false;
            this.QuitPictureBox.Click += new System.EventHandler(this.PictureBoxQuit_Click);
            // 
            // FormMainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.ControlBox = false;
            this.Controls.Add(this.QuitPictureBox);
            this.Controls.Add(this.OptionPictureBox);
            this.Controls.Add(this.PausePictureBox);
            this.Controls.Add(this.ResetPictureBox);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.TimeLabel);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormMainScreen";
            this.Text = "Vang De Volger";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormMainScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.OptionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PausePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.PictureBox ResetPictureBox;
        private System.Windows.Forms.PictureBox PausePictureBox;
        private System.Windows.Forms.PictureBox OptionPictureBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox QuitPictureBox;
    }
}

