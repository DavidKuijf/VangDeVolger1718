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
            this.OptionpictureBox = new System.Windows.Forms.PictureBox();
            this.PausePictureBox = new System.Windows.Forms.PictureBox();
            this.ResetPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OptionpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PausePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
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
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // OptionpictureBox
            // 
            this.OptionpictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OptionpictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OptionpictureBox.BackgroundImage")));
            this.OptionpictureBox.Image = global::VangdeVolger.Properties.Resources.Options;
            this.OptionpictureBox.Location = new System.Drawing.Point(0, 169);
            this.OptionpictureBox.Name = "OptionpictureBox";
            this.OptionpictureBox.Size = new System.Drawing.Size(150, 90);
            this.OptionpictureBox.TabIndex = 4;
            this.OptionpictureBox.TabStop = false;
            this.OptionpictureBox.Visible = false;
            this.OptionpictureBox.Click += new System.EventHandler(this.OptionpictureBox_Click);
            // 
            // PausePictureBox
            // 
            this.PausePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PausePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PausePictureBox.BackgroundImage")));
            this.PausePictureBox.Image = global::VangdeVolger.Properties.Resources.Pause;
            this.PausePictureBox.Location = new System.Drawing.Point(0, 83);
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
            this.ResetPictureBox.Image = global::VangdeVolger.Properties.Resources.Restart;
            this.ResetPictureBox.Location = new System.Drawing.Point(0, 0);
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
            this.pictureBoxMain.Size = new System.Drawing.Size(484, 461);
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            // 
            // FormMainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.ControlBox = false;
            this.Controls.Add(this.OptionpictureBox);
            this.Controls.Add(this.PausePictureBox);
            this.Controls.Add(this.ResetPictureBox);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.TimeLabel);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormMainScreen";
            this.Text = "Vang De Volger";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormMainScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.OptionpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PausePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.PictureBox ResetPictureBox;
        private System.Windows.Forms.PictureBox PausePictureBox;
        private System.Windows.Forms.PictureBox OptionpictureBox;
        private System.Windows.Forms.Timer Timer;
    }
}

