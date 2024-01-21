namespace Metro_Parking_System.Login
{
    partial class SecurityKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityKey));
            this.lbUsernameorpass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.buttonOK = new Guna.UI2.WinForms.Guna2Button();
            this.tbSecurityKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbUsernameorpass
            // 
            this.lbUsernameorpass.BackColor = System.Drawing.Color.Transparent;
            this.lbUsernameorpass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameorpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.lbUsernameorpass.Location = new System.Drawing.Point(43, 24);
            this.lbUsernameorpass.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.lbUsernameorpass.Name = "lbUsernameorpass";
            this.lbUsernameorpass.Size = new System.Drawing.Size(215, 32);
            this.lbUsernameorpass.TabIndex = 19;
            this.lbUsernameorpass.Text = "ENTER SECURITY KEY";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BorderRadius = 5;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancel.Location = new System.Drawing.Point(73, 123);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(67, 39);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "EXIT";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BorderRadius = 5;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonOK.Location = new System.Drawing.Point(150, 123);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(74, 39);
            this.buttonOK.TabIndex = 18;
            this.buttonOK.Text = "OKAY";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // tbSecurityKey
            // 
            this.tbSecurityKey.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSecurityKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbSecurityKey.Location = new System.Drawing.Point(28, 70);
            this.tbSecurityKey.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tbSecurityKey.Name = "tbSecurityKey";
            this.tbSecurityKey.Size = new System.Drawing.Size(245, 39);
            this.tbSecurityKey.TabIndex = 16;
            this.tbSecurityKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSecurityKey.TextChanged += new System.EventHandler(this.tbSecurityKey_TextChanged);
            // 
            // SecurityKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 187);
            this.ControlBox = false;
            this.Controls.Add(this.lbUsernameorpass);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tbSecurityKey);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SecurityKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbUsernameorpass;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private Guna.UI2.WinForms.Guna2Button buttonOK;
        private System.Windows.Forms.TextBox tbSecurityKey;
    }
}