namespace Metro_Parking_System.Login
{
    partial class UC_InfoEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btLoginEmp = new Guna.UI2.WinForms.Guna2Button();
            this.tbEmpPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbEmpUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPassIncorrect = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbCooldown = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cooldownTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btLoginEmp
            // 
            this.btLoginEmp.BorderRadius = 8;
            this.btLoginEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btLoginEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btLoginEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btLoginEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btLoginEmp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.btLoginEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btLoginEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.btLoginEmp.Location = new System.Drawing.Point(100, 173);
            this.btLoginEmp.Name = "btLoginEmp";
            this.btLoginEmp.Size = new System.Drawing.Size(111, 45);
            this.btLoginEmp.TabIndex = 4;
            this.btLoginEmp.Text = "LOG IN";
            this.btLoginEmp.Click += new System.EventHandler(this.btLoginEmp_Click);
            // 
            // tbEmpPass
            // 
            this.tbEmpPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(47)))));
            this.tbEmpPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmpPass.DefaultText = "";
            this.tbEmpPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmpPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmpPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmpPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmpPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(47)))));
            this.tbEmpPass.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.tbEmpPass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbEmpPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.tbEmpPass.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.tbEmpPass.Location = new System.Drawing.Point(17, 92);
            this.tbEmpPass.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.tbEmpPass.Name = "tbEmpPass";
            this.tbEmpPass.PasswordChar = '•';
            this.tbEmpPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.tbEmpPass.PlaceholderText = "Enter Password";
            this.tbEmpPass.SelectedText = "";
            this.tbEmpPass.Size = new System.Drawing.Size(279, 43);
            this.tbEmpPass.TabIndex = 2;
            // 
            // tbEmpUser
            // 
            this.tbEmpUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(47)))));
            this.tbEmpUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmpUser.DefaultText = "";
            this.tbEmpUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmpUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmpUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmpUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmpUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(47)))));
            this.tbEmpUser.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.tbEmpUser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbEmpUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.tbEmpUser.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.tbEmpUser.Location = new System.Drawing.Point(17, 39);
            this.tbEmpUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmpUser.Name = "tbEmpUser";
            this.tbEmpUser.PasswordChar = '\0';
            this.tbEmpUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.tbEmpUser.PlaceholderText = "Enter Username";
            this.tbEmpUser.SelectedText = "";
            this.tbEmpUser.Size = new System.Drawing.Size(279, 43);
            this.tbEmpUser.TabIndex = 1;
            this.tbEmpUser.TextChanged += new System.EventHandler(this.tbEmpUser_TextChanged);
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShowPass.CheckedState.BorderRadius = 0;
            this.cbShowPass.CheckedState.BorderThickness = 0;
            this.cbShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShowPass.ForeColor = System.Drawing.Color.Gray;
            this.cbShowPass.Location = new System.Drawing.Point(14, 146);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(139, 25);
            this.cbShowPass.TabIndex = 3;
            this.cbShowPass.Text = "Show password";
            this.cbShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbShowPass.UncheckedState.BorderRadius = 0;
            this.cbShowPass.UncheckedState.BorderThickness = 0;
            this.cbShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.lblLogin.Location = new System.Drawing.Point(95, 6);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(120, 30);
            this.lblLogin.TabIndex = 20;
            this.lblLogin.Text = "EMPLOYEE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.panel2.Location = new System.Drawing.Point(17, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 2);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.panel1.Location = new System.Drawing.Point(17, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 2);
            this.panel1.TabIndex = 18;
            // 
            // lbPassIncorrect
            // 
            this.lbPassIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.lbPassIncorrect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassIncorrect.ForeColor = System.Drawing.Color.IndianRed;
            this.lbPassIncorrect.Location = new System.Drawing.Point(10, 214);
            this.lbPassIncorrect.Name = "lbPassIncorrect";
            this.lbPassIncorrect.Size = new System.Drawing.Size(251, 19);
            this.lbPassIncorrect.TabIndex = 31;
            this.lbPassIncorrect.Text = "Locked: 1-min cooldown after 3 attempts -";
            this.lbPassIncorrect.Visible = false;
            // 
            // lbCooldown
            // 
            this.lbCooldown.BackColor = System.Drawing.Color.Transparent;
            this.lbCooldown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCooldown.ForeColor = System.Drawing.Color.IndianRed;
            this.lbCooldown.Location = new System.Drawing.Point(265, 214);
            this.lbCooldown.Name = "lbCooldown";
            this.lbCooldown.Size = new System.Drawing.Size(35, 19);
            this.lbCooldown.TabIndex = 32;
            this.lbCooldown.Text = "01:00";
            this.lbCooldown.Visible = false;
            // 
            // cooldownTimer
            // 
            this.cooldownTimer.Enabled = true;
            this.cooldownTimer.Interval = 1000;
            // 
            // UC_InfoEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.btLoginEmp);
            this.Controls.Add(this.tbEmpPass);
            this.Controls.Add(this.tbEmpUser);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPassIncorrect);
            this.Controls.Add(this.lbCooldown);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_InfoEmployee";
            this.Size = new System.Drawing.Size(311, 254);
            this.Load += new System.EventHandler(this.UC_InfoEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btLoginEmp;
        private Guna.UI2.WinForms.Guna2TextBox tbEmpPass;
        private Guna.UI2.WinForms.Guna2TextBox tbEmpUser;
        private Guna.UI2.WinForms.Guna2CheckBox cbShowPass;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPassIncorrect;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbCooldown;
        private System.Windows.Forms.Timer cooldownTimer;
    }
}
