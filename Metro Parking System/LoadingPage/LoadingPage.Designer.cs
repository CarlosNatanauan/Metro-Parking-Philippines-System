namespace Metro_Parking_System.LoadingPage
{
    partial class loadingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadingPage));
            this.pbIpAddress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIpAddress
            // 
            this.pbIpAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.pbIpAddress.Location = new System.Drawing.Point(110, 296);
            this.pbIpAddress.Name = "pbIpAddress";
            this.pbIpAddress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(98)))), ((int)(((byte)(70)))));
            this.pbIpAddress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(40)))), ((int)(((byte)(16)))));
            this.pbIpAddress.Size = new System.Drawing.Size(443, 43);
            this.pbIpAddress.TabIndex = 0;
            this.pbIpAddress.Text = "guna2ProgressBar1";
            this.pbIpAddress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(206)))), ((int)(((byte)(193)))));
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(21)))));
            this.lblStatus.Location = new System.Drawing.Point(110, 345);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(111, 27);
            this.lblStatus.TabIndex = 142;
            this.lblStatus.Text = "Initializing...";
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(663, 406);
            this.guna2PictureBox2.TabIndex = 143;
            this.guna2PictureBox2.TabStop = false;
            // 
            // loadingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(663, 406);
            this.ControlBox = false;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbIpAddress);
            this.Controls.Add(this.guna2PictureBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "loadingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoadingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar pbIpAddress;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}