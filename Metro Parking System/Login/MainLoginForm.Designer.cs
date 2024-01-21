namespace Metro_Parking_System.Login
{
    partial class MainLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLoginForm));
            this.btSwitch = new Guna.UI2.WinForms.Guna2Button();
            this.panelUser = new Guna.UI2.WinForms.Guna2Panel();
            this.RefreshForm = new System.Windows.Forms.Timer(this.components);
            this.CheckDatabase = new System.Windows.Forms.Timer(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btRateCasTwoHours = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSwitch
            // 
            this.btSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(47)))));
            this.btSwitch.BorderRadius = 10;
            this.btSwitch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSwitch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSwitch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSwitch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSwitch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btSwitch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.btSwitch.Location = new System.Drawing.Point(530, 171);
            this.btSwitch.Name = "btSwitch";
            this.btSwitch.Size = new System.Drawing.Size(109, 21);
            this.btSwitch.TabIndex = 10;
            this.btSwitch.Click += new System.EventHandler(this.btSwitch_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(47)))));
            this.panelUser.Location = new System.Drawing.Point(432, 206);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(306, 235);
            this.panelUser.TabIndex = 9;
            // 
            // RefreshForm
            // 
            this.RefreshForm.Interval = 1000;
            this.RefreshForm.Tick += new System.EventHandler(this.RefreshForm_Tick);
            // 
            // CheckDatabase
            // 
            this.CheckDatabase.Enabled = true;
            this.CheckDatabase.Interval = 1000;
            this.CheckDatabase.Tick += new System.EventHandler(this.CheckDatabase_Tick);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(760, 537);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // btRateCasTwoHours
            // 
            this.btRateCasTwoHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(72)))));
            this.btRateCasTwoHours.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btRateCasTwoHours.HoverState.ImageSize = new System.Drawing.Size(50, 36);
            this.btRateCasTwoHours.Image = ((System.Drawing.Image)(resources.GetObject("btRateCasTwoHours.Image")));
            this.btRateCasTwoHours.ImageOffset = new System.Drawing.Point(0, 0);
            this.btRateCasTwoHours.ImageRotate = 0F;
            this.btRateCasTwoHours.ImageSize = new System.Drawing.Size(40, 40);
            this.btRateCasTwoHours.Location = new System.Drawing.Point(694, 12);
            this.btRateCasTwoHours.Name = "btRateCasTwoHours";
            this.btRateCasTwoHours.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.btRateCasTwoHours.Size = new System.Drawing.Size(54, 40);
            this.btRateCasTwoHours.TabIndex = 113;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(47)))));
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(38, 38);
            this.btnExit.Location = new System.Drawing.Point(690, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(36, 36);
            this.btnExit.Size = new System.Drawing.Size(64, 54);
            this.btnExit.TabIndex = 114;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(760, 537);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btRateCasTwoHours);
            this.Controls.Add(this.btSwitch);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.guna2PictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainLoginForm_Load);
            this.Shown += new System.EventHandler(this.MainLoginForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btSwitch;
        private Guna.UI2.WinForms.Guna2Panel panelUser;
        private System.Windows.Forms.Timer RefreshForm;
        private System.Windows.Forms.Timer CheckDatabase;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btRateCasTwoHours;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
    }
}