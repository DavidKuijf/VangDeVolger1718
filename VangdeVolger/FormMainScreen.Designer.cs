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
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.ResetPictureBox = new System.Windows.Forms.PictureBox();
            this.PausePictureBox = new System.Windows.Forms.PictureBox();
            this.OptionpictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PausePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(479, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 19);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Timer";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxMain.Location = new System.Drawing.Point(12, 30);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            // 
            // ResetPictureBox
            // 
            this.ResetPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResetPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetPictureBox.BackgroundImage")));
            this.ResetPictureBox.Location = new System.Drawing.Point(518, 30);
            this.ResetPictureBox.Name = "ResetPictureBox";
            this.ResetPictureBox.Size = new System.Drawing.Size(150, 90);
            this.ResetPictureBox.TabIndex = 2;
            this.ResetPictureBox.TabStop = false;
            this.ResetPictureBox.Click += new System.EventHandler(this.ResetPictureBox_Click);
            // 
            // PausePictureBox
            // 
            this.PausePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PausePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PausePictureBox.BackgroundImage")));
            this.PausePictureBox.Location = new System.Drawing.Point(518, 126);
            this.PausePictureBox.Name = "PausePictureBox";
            this.PausePictureBox.Size = new System.Drawing.Size(150, 90);
            this.PausePictureBox.TabIndex = 3;
            this.PausePictureBox.TabStop = false;
            this.PausePictureBox.Click += new System.EventHandler(this.PausePictureBox_Click);
            // 
            // OptionpictureBox
            // 
            this.OptionpictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OptionpictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OptionpictureBox.BackgroundImage")));
            this.OptionpictureBox.Location = new System.Drawing.Point(518, 222);
            this.OptionpictureBox.Name = "OptionpictureBox";
            this.OptionpictureBox.Size = new System.Drawing.Size(150, 90);
            this.OptionpictureBox.TabIndex = 4;
            this.OptionpictureBox.TabStop = false;
            this.OptionpictureBox.Click += new System.EventHandler(this.OptionpictureBox_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormMainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(673, 542);
            this.Controls.Add(this.OptionpictureBox);
            this.Controls.Add(this.PausePictureBox);
            this.Controls.Add(this.ResetPictureBox);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.lblTime);
            this.KeyPreview = true;
            this.Name = "FormMainScreen";
            this.Text = "Vang De Volger";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormMainScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PausePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.PictureBox ResetPictureBox;
        private System.Windows.Forms.PictureBox PausePictureBox;
        private System.Windows.Forms.PictureBox OptionpictureBox;
        private System.Windows.Forms.Timer timer;
    }
}

