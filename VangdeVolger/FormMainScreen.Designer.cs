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
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
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
            // FormMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 542);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.lblTime);
            this.KeyPreview = true;
            this.Name = "FormMainScreen";
            this.Text = "Vang De Volger";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormMainScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBoxMain;
    }
}

