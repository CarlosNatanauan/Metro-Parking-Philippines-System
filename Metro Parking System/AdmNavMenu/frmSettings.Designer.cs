namespace Metro_Parking_System.AdmNavMenu
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.realTime = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btCloseSettings = new Guna.UI2.WinForms.Guna2Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnRestore = new Guna.UI2.WinForms.Guna2Button();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.txtRestorePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btShowPass = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btShowUser = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAdminLname = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbAdminMname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBackup = new Guna.UI2.WinForms.Guna2Button();
            this.txtBackupPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.lbAdminFname = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dtpMonthly = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvAdminLog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.adminNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminTimeINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminTimeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminlogBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.adminlogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.admin_log = new Metro_Parking_System.admin_log();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.adminlogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admin_logTableAdapter = new Metro_Parking_System.admin_logTableAdapters.admin_logTableAdapter();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminlogBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminlogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_log)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminlogBindingSource)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "SETTINGS";
            // 
            // btCloseSettings
            // 
            this.btCloseSettings.BorderRadius = 5;
            this.btCloseSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCloseSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCloseSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCloseSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCloseSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCloseSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btCloseSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCloseSettings.ForeColor = System.Drawing.Color.White;
            this.btCloseSettings.Location = new System.Drawing.Point(951, 3);
            this.btCloseSettings.Name = "btCloseSettings";
            this.btCloseSettings.Size = new System.Drawing.Size(62, 25);
            this.btCloseSettings.TabIndex = 0;
            this.btCloseSettings.Text = "CLOSE";
            this.btCloseSettings.Click += new System.EventHandler(this.btCloseSettings_Click_1);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(453, 3);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(110, 25);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "HH:MM:SS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btCloseSettings);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 31);
            this.panel1.TabIndex = 8;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lblStatus.Location = new System.Drawing.Point(72, 252);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(332, 22);
            this.lblStatus.TabIndex = 143;
            this.lblStatus.Text = "Please wait, restoring database may take a while...";
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Visible = false;
            // 
            // btnRestore
            // 
            this.btnRestore.BorderRadius = 5;
            this.btnRestore.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btnRestore.Location = new System.Drawing.Point(447, 170);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(101, 36);
            this.btnRestore.TabIndex = 102;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(72, 221);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(420, 30);
            this.progressBar.TabIndex = 101;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BorderRadius = 5;
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btnBrowse.Location = new System.Drawing.Point(336, 170);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(101, 36);
            this.btnBrowse.TabIndex = 100;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestorePath.DefaultText = "";
            this.txtRestorePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRestorePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRestorePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRestorePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRestorePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRestorePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRestorePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRestorePath.Location = new System.Drawing.Point(24, 170);
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.PasswordChar = '\0';
            this.txtRestorePath.PlaceholderText = "";
            this.txtRestorePath.SelectedText = "";
            this.txtRestorePath.Size = new System.Drawing.Size(304, 36);
            this.txtRestorePath.TabIndex = 99;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbPassword.Location = new System.Drawing.Point(708, 108);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(54, 37);
            this.lbPassword.TabIndex = 158;
            this.lbPassword.Text = "NA";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbUserName.Location = new System.Drawing.Point(708, 57);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(54, 37);
            this.lbUserName.TabIndex = 157;
            this.lbUserName.Text = "NA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label4.Location = new System.Drawing.Point(693, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 37);
            this.label4.TabIndex = 156;
            this.label4.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(693, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 37);
            this.label1.TabIndex = 155;
            this.label1.Text = ":";
            // 
            // btShowPass
            // 
            this.btShowPass.BackColor = System.Drawing.Color.Transparent;
            this.btShowPass.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btShowPass.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.btShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btShowPass.Image")));
            this.btShowPass.ImageOffset = new System.Drawing.Point(0, 0);
            this.btShowPass.ImageRotate = 0F;
            this.btShowPass.ImageSize = new System.Drawing.Size(40, 40);
            this.btShowPass.Location = new System.Drawing.Point(878, 105);
            this.btShowPass.Name = "btShowPass";
            this.btShowPass.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btShowPass.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.btShowPass.Size = new System.Drawing.Size(44, 40);
            this.btShowPass.TabIndex = 153;
            this.btShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btShowPass_MouseDown);
            this.btShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btShowPass_MouseUp);
            // 
            // btShowUser
            // 
            this.btShowUser.BackColor = System.Drawing.Color.Transparent;
            this.btShowUser.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btShowUser.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.btShowUser.Image = ((System.Drawing.Image)(resources.GetObject("btShowUser.Image")));
            this.btShowUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.btShowUser.ImageRotate = 0F;
            this.btShowUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btShowUser.Location = new System.Drawing.Point(878, 54);
            this.btShowUser.Name = "btShowUser";
            this.btShowUser.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btShowUser.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.btShowUser.Size = new System.Drawing.Size(44, 40);
            this.btShowUser.TabIndex = 154;
            this.btShowUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btShowUser_MouseDown);
            this.btShowUser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btShowUser_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label7.Location = new System.Drawing.Point(568, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 37);
            this.label7.TabIndex = 152;
            this.label7.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(568, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 151;
            this.label2.Text = "Username";
            // 
            // lbAdminLname
            // 
            this.lbAdminLname.AutoSize = true;
            this.lbAdminLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbAdminLname.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdminLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbAdminLname.Location = new System.Drawing.Point(221, 159);
            this.lbAdminLname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAdminLname.Name = "lbAdminLname";
            this.lbAdminLname.Size = new System.Drawing.Size(54, 37);
            this.lbAdminLname.TabIndex = 150;
            this.lbAdminLname.Text = "NA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label16.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label16.Location = new System.Drawing.Point(206, 159);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 37);
            this.label16.TabIndex = 149;
            this.label16.Text = ":";
            // 
            // lbAdminMname
            // 
            this.lbAdminMname.AutoSize = true;
            this.lbAdminMname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbAdminMname.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdminMname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbAdminMname.Location = new System.Drawing.Point(221, 108);
            this.lbAdminMname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAdminMname.Name = "lbAdminMname";
            this.lbAdminMname.Size = new System.Drawing.Size(54, 37);
            this.lbAdminMname.TabIndex = 148;
            this.lbAdminMname.Text = "NA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label6.Location = new System.Drawing.Point(17, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 37);
            this.label6.TabIndex = 98;
            this.label6.Text = "Restore Path";
            // 
            // btnBackup
            // 
            this.btnBackup.BorderRadius = 5;
            this.btnBackup.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btnBackup.Location = new System.Drawing.Point(336, 90);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(101, 36);
            this.btnBackup.TabIndex = 97;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBackupPath.DefaultText = "";
            this.txtBackupPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBackupPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBackupPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBackupPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBackupPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBackupPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBackupPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBackupPath.Location = new System.Drawing.Point(24, 90);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.PasswordChar = '\0';
            this.txtBackupPath.PlaceholderText = "";
            this.txtBackupPath.SelectedText = "";
            this.txtBackupPath.Size = new System.Drawing.Size(304, 36);
            this.txtBackupPath.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label5.Location = new System.Drawing.Point(17, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 37);
            this.label5.TabIndex = 95;
            this.label5.Text = "Backup Path";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label11.Location = new System.Drawing.Point(206, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 37);
            this.label11.TabIndex = 147;
            this.label11.Text = ":";
            // 
            // lbAdminFname
            // 
            this.lbAdminFname.AutoSize = true;
            this.lbAdminFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbAdminFname.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdminFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbAdminFname.Location = new System.Drawing.Point(221, 57);
            this.lbAdminFname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAdminFname.Name = "lbAdminFname";
            this.lbAdminFname.Size = new System.Drawing.Size(54, 37);
            this.lbAdminFname.TabIndex = 146;
            this.lbAdminFname.Text = "NA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label9.Location = new System.Drawing.Point(206, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 37);
            this.label9.TabIndex = 145;
            this.label9.Text = ":";
            // 
            // btUpdate
            // 
            this.btUpdate.BorderRadius = 5;
            this.btUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btUpdate.Location = new System.Drawing.Point(841, 172);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(94, 36);
            this.btUpdate.TabIndex = 144;
            this.btUpdate.Text = "UPDATE";
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label14.Location = new System.Drawing.Point(31, 159);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 37);
            this.label14.TabIndex = 118;
            this.label14.Text = "Last Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label13.Location = new System.Drawing.Point(31, 57);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 37);
            this.label13.TabIndex = 94;
            this.label13.Text = "First Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dtpMonthly
            // 
            this.dtpMonthly.Checked = true;
            this.dtpMonthly.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.dtpMonthly.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMonthly.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpMonthly.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMonthly.Location = new System.Drawing.Point(150, 58);
            this.dtpMonthly.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpMonthly.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpMonthly.Name = "dtpMonthly";
            this.dtpMonthly.Size = new System.Drawing.Size(211, 36);
            this.dtpMonthly.TabIndex = 128;
            this.dtpMonthly.Value = new System.DateTime(2023, 10, 28, 22, 58, 12, 901);
            this.dtpMonthly.ValueChanged += new System.EventHandler(this.dtpMonthly_ValueChanged);
            // 
            // dgvAdminLog
            // 
            this.dgvAdminLog.AllowUserToAddRows = false;
            this.dgvAdminLog.AllowUserToDeleteRows = false;
            this.dgvAdminLog.AllowUserToResizeColumns = false;
            this.dgvAdminLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAdminLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdminLog.AutoGenerateColumns = false;
            this.dgvAdminLog.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvAdminLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(217)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdminLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdminLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminNameDataGridViewTextBoxColumn,
            this.adminTimeINDataGridViewTextBoxColumn,
            this.adminTimeOutDataGridViewTextBoxColumn});
            this.dgvAdminLog.DataSource = this.adminlogBindingSource2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminLog.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdminLog.GridColor = System.Drawing.Color.White;
            this.dgvAdminLog.Location = new System.Drawing.Point(637, 160);
            this.dgvAdminLog.Name = "dgvAdminLog";
            this.dgvAdminLog.ReadOnly = true;
            this.dgvAdminLog.RowHeadersVisible = false;
            this.dgvAdminLog.Size = new System.Drawing.Size(319, 168);
            this.dgvAdminLog.TabIndex = 127;
            this.dgvAdminLog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAdminLog.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAdminLog.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAdminLog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAdminLog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAdminLog.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvAdminLog.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvAdminLog.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvAdminLog.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAdminLog.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAdminLog.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAdminLog.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdminLog.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvAdminLog.ThemeStyle.ReadOnly = true;
            this.dgvAdminLog.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAdminLog.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAdminLog.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAdminLog.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAdminLog.ThemeStyle.RowsStyle.Height = 22;
            this.dgvAdminLog.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAdminLog.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAdminLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminLog_CellContentClick);
            // 
            // adminNameDataGridViewTextBoxColumn
            // 
            this.adminNameDataGridViewTextBoxColumn.DataPropertyName = "adminName";
            this.adminNameDataGridViewTextBoxColumn.HeaderText = "adminName";
            this.adminNameDataGridViewTextBoxColumn.Name = "adminNameDataGridViewTextBoxColumn";
            this.adminNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.adminNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // adminTimeINDataGridViewTextBoxColumn
            // 
            this.adminTimeINDataGridViewTextBoxColumn.DataPropertyName = "adminTimeIN";
            this.adminTimeINDataGridViewTextBoxColumn.HeaderText = "LOG IN";
            this.adminTimeINDataGridViewTextBoxColumn.Name = "adminTimeINDataGridViewTextBoxColumn";
            this.adminTimeINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminTimeOutDataGridViewTextBoxColumn
            // 
            this.adminTimeOutDataGridViewTextBoxColumn.DataPropertyName = "adminTimeOut";
            this.adminTimeOutDataGridViewTextBoxColumn.HeaderText = "LOG OUT";
            this.adminTimeOutDataGridViewTextBoxColumn.Name = "adminTimeOutDataGridViewTextBoxColumn";
            this.adminTimeOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminlogBindingSource2
            // 
            this.adminlogBindingSource2.DataMember = "admin_log";
            this.adminlogBindingSource2.DataSource = this.adminlogBindingSource1;
            // 
            // adminlogBindingSource1
            // 
            this.adminlogBindingSource1.DataSource = this.admin_log;
            this.adminlogBindingSource1.Position = 0;
            // 
            // admin_log
            // 
            this.admin_log.DataSetName = "admin_log";
            this.admin_log.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.lbPassword);
            this.guna2GroupBox3.Controls.Add(this.lbUserName);
            this.guna2GroupBox3.Controls.Add(this.label4);
            this.guna2GroupBox3.Controls.Add(this.label1);
            this.guna2GroupBox3.Controls.Add(this.btShowPass);
            this.guna2GroupBox3.Controls.Add(this.btShowUser);
            this.guna2GroupBox3.Controls.Add(this.label7);
            this.guna2GroupBox3.Controls.Add(this.label2);
            this.guna2GroupBox3.Controls.Add(this.lbAdminLname);
            this.guna2GroupBox3.Controls.Add(this.label16);
            this.guna2GroupBox3.Controls.Add(this.lbAdminMname);
            this.guna2GroupBox3.Controls.Add(this.label11);
            this.guna2GroupBox3.Controls.Add(this.lbAdminFname);
            this.guna2GroupBox3.Controls.Add(this.label9);
            this.guna2GroupBox3.Controls.Add(this.btUpdate);
            this.guna2GroupBox3.Controls.Add(this.label14);
            this.guna2GroupBox3.Controls.Add(this.label12);
            this.guna2GroupBox3.Controls.Add(this.label13);
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.guna2GroupBox3.CustomizableEdges.BottomLeft = false;
            this.guna2GroupBox3.CustomizableEdges.BottomRight = false;
            this.guna2GroupBox3.CustomizableEdges.TopLeft = false;
            this.guna2GroupBox3.CustomizableEdges.TopRight = false;
            this.guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(25, 362);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(966, 230);
            this.guna2GroupBox3.TabIndex = 126;
            this.guna2GroupBox3.Text = "ADMIN INFORMATION";
            this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label12.Location = new System.Drawing.Point(31, 108);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 37);
            this.label12.TabIndex = 102;
            this.label12.Text = "Middle Name";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.btnBackup);
            this.guna2GroupBox2.Controls.Add(this.lblStatus);
            this.guna2GroupBox2.Controls.Add(this.btnRestore);
            this.guna2GroupBox2.Controls.Add(this.progressBar);
            this.guna2GroupBox2.Controls.Add(this.btnBrowse);
            this.guna2GroupBox2.Controls.Add(this.txtRestorePath);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Controls.Add(this.txtBackupPath);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.guna2GroupBox2.CustomizableEdges.BottomLeft = false;
            this.guna2GroupBox2.CustomizableEdges.BottomRight = false;
            this.guna2GroupBox2.CustomizableEdges.TopLeft = false;
            this.guna2GroupBox2.CustomizableEdges.TopRight = false;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(25, 60);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(564, 292);
            this.guna2GroupBox2.TabIndex = 125;
            this.guna2GroupBox2.Text = "BACKUP & RESTORE";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adminlogBindingSource
            // 
            this.adminlogBindingSource.DataMember = "admin_log";
            this.adminlogBindingSource.DataSource = this.admin_log;
            // 
            // admin_logTableAdapter
            // 
            this.admin_logTableAdapter.ClearBeforeFill = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.dtpMonthly);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.guna2GroupBox1.CustomizableEdges.BottomLeft = false;
            this.guna2GroupBox1.CustomizableEdges.BottomRight = false;
            this.guna2GroupBox1.CustomizableEdges.TopLeft = false;
            this.guna2GroupBox1.CustomizableEdges.TopRight = false;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(595, 60);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(396, 292);
            this.guna2GroupBox1.TabIndex = 144;
            this.guna2GroupBox1.Text = "ADMIN LOG";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(42, 59);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(91, 34);
            this.guna2HtmlLabel2.TabIndex = 144;
            this.guna2HtmlLabel2.Text = "MONTH";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1016, 618);
            this.ControlBox = false;
            this.Controls.Add(this.dgvAdminLog);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSettings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminlogBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminlogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_log)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminlogBindingSource)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer realTime;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btCloseSettings;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2Button btnRestore;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private Guna.UI2.WinForms.Guna2TextBox txtRestorePath;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btShowPass;
        private Guna.UI2.WinForms.Guna2ImageButton btShowUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAdminLname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbAdminMname;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnBackup;
        private Guna.UI2.WinForms.Guna2TextBox txtBackupPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbAdminFname;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMonthly;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAdminLog;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private admin_log admin_log;
        private System.Windows.Forms.BindingSource adminlogBindingSource;
        private admin_logTableAdapters.admin_logTableAdapter admin_logTableAdapter;
        private System.Windows.Forms.BindingSource adminlogBindingSource2;
        private System.Windows.Forms.BindingSource adminlogBindingSource1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminTimeINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminTimeOutDataGridViewTextBoxColumn;
    }
}