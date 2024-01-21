namespace Metro_Parking_System.AdmPrompts
{
    partial class AdminLoginCredential
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginCredential));
            this.buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.buttonOK = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.lbUsernameorpass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
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
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.buttonCancel.Location = new System.Drawing.Point(89, 121);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(67, 39);
            this.buttonCancel.TabIndex = 13;
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
            this.buttonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.buttonOK.Location = new System.Drawing.Point(166, 121);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(71, 39);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "SAVE";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBoxInput.Location = new System.Drawing.Point(57, 68);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(213, 39);
            this.textBoxInput.TabIndex = 12;
            this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbUsernameorpass
            // 
            this.lbUsernameorpass.BackColor = System.Drawing.Color.Transparent;
            this.lbUsernameorpass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameorpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.lbUsernameorpass.Location = new System.Drawing.Point(9, 27);
            this.lbUsernameorpass.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.lbUsernameorpass.Name = "lbUsernameorpass";
            this.lbUsernameorpass.Size = new System.Drawing.Size(308, 32);
            this.lbUsernameorpass.TabIndex = 15;
            this.lbUsernameorpass.Text = "ENTER YOUR NEW USERNAME";
            // 
            // AdminLoginCredential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 186);
            this.ControlBox = false;
            this.Controls.Add(this.lbUsernameorpass);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxInput);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdminLoginCredential";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdminLoginCredential_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private Guna.UI2.WinForms.Guna2Button buttonOK;
        private System.Windows.Forms.TextBox textBoxInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbUsernameorpass;
    }
}