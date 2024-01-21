namespace Metro_Parking_System
{
    partial class mainFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btMinimized = new Guna.UI2.WinForms.Guna2Button();
            this.btExit = new Guna.UI2.WinForms.Guna2Button();
            this.sidebar = new System.Windows.Forms.Panel();
            this.gunaBTadminSettings = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBTmanageEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBTrevenueReport = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBTupdateRates = new Guna.UI2.WinForms.Guna2Button();
            this.logoContainer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaBTLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.logoContainer.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btMinimized);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 21);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(399, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "PARKING LOT MANAGEMENT SYSTEM";
            // 
            // btMinimized
            // 
            this.btMinimized.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.btMinimized.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btMinimized.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMinimized.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMinimized.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMinimized.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMinimized.FillColor = System.Drawing.Color.Transparent;
            this.btMinimized.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btMinimized.ForeColor = System.Drawing.Color.White;
            this.btMinimized.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(158)))));
            this.btMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btMinimized.Image")));
            this.btMinimized.Location = new System.Drawing.Point(1054, 0);
            this.btMinimized.Margin = new System.Windows.Forms.Padding(0);
            this.btMinimized.Name = "btMinimized";
            this.btMinimized.Size = new System.Drawing.Size(20, 21);
            this.btMinimized.TabIndex = 4;
            this.btMinimized.Click += new System.EventHandler(this.btMinimized_Click);
            // 
            // btExit
            // 
            this.btExit.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btExit.FillColor = System.Drawing.Color.Transparent;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(54)))));
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.Location = new System.Drawing.Point(1074, 0);
            this.btExit.Margin = new System.Windows.Forms.Padding(0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(20, 21);
            this.btExit.TabIndex = 3;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.sidebar.Controls.Add(this.gunaBTadminSettings);
            this.sidebar.Controls.Add(this.gunaBTmanageEmployee);
            this.sidebar.Controls.Add(this.gunaBTrevenueReport);
            this.sidebar.Controls.Add(this.gunaBTupdateRates);
            this.sidebar.Controls.Add(this.logoContainer);
            this.sidebar.Controls.Add(this.gunaBTLogOut);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 21);
            this.sidebar.MaximumSize = new System.Drawing.Size(240, 627);
            this.sidebar.MinimumSize = new System.Drawing.Size(70, 627);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 5);
            this.sidebar.Size = new System.Drawing.Size(240, 627);
            this.sidebar.TabIndex = 3;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // gunaBTadminSettings
            // 
            this.gunaBTadminSettings.BorderRadius = 5;
            this.gunaBTadminSettings.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.gunaBTadminSettings.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gunaBTadminSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTadminSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.gunaBTadminSettings.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.gunaBTadminSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaBTadminSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.gunaBTadminSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaBTadminSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.gunaBTadminSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaBTadminSettings.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTadminSettings.Image")));
            this.gunaBTadminSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTadminSettings.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTadminSettings.Location = new System.Drawing.Point(4, 522);
            this.gunaBTadminSettings.Name = "gunaBTadminSettings";
            this.gunaBTadminSettings.Padding = new System.Windows.Forms.Padding(5, 15, 5, 10);
            this.gunaBTadminSettings.Size = new System.Drawing.Size(232, 50);
            this.gunaBTadminSettings.TabIndex = 22;
            this.gunaBTadminSettings.Text = "  SETTINGS";
            this.gunaBTadminSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTadminSettings.Click += new System.EventHandler(this.gunaBTadminSettings_Click);
            // 
            // gunaBTmanageEmployee
            // 
            this.gunaBTmanageEmployee.BorderRadius = 5;
            this.gunaBTmanageEmployee.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.gunaBTmanageEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gunaBTmanageEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTmanageEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.gunaBTmanageEmployee.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.gunaBTmanageEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaBTmanageEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.gunaBTmanageEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaBTmanageEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.gunaBTmanageEmployee.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTmanageEmployee.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTmanageEmployee.Image")));
            this.gunaBTmanageEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTmanageEmployee.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTmanageEmployee.Location = new System.Drawing.Point(4, 162);
            this.gunaBTmanageEmployee.Name = "gunaBTmanageEmployee";
            this.gunaBTmanageEmployee.Padding = new System.Windows.Forms.Padding(5, 15, 5, 10);
            this.gunaBTmanageEmployee.Size = new System.Drawing.Size(232, 50);
            this.gunaBTmanageEmployee.TabIndex = 21;
            this.gunaBTmanageEmployee.Text = " MANAGE EMPLOYEE";
            this.gunaBTmanageEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTmanageEmployee.Click += new System.EventHandler(this.gunaBTmanageEmployee_Click);
            // 
            // gunaBTrevenueReport
            // 
            this.gunaBTrevenueReport.BorderRadius = 5;
            this.gunaBTrevenueReport.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.gunaBTrevenueReport.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTrevenueReport.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTrevenueReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTrevenueReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.gunaBTrevenueReport.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.gunaBTrevenueReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaBTrevenueReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.gunaBTrevenueReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaBTrevenueReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.gunaBTrevenueReport.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTrevenueReport.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTrevenueReport.Image")));
            this.gunaBTrevenueReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTrevenueReport.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTrevenueReport.Location = new System.Drawing.Point(4, 112);
            this.gunaBTrevenueReport.Name = "gunaBTrevenueReport";
            this.gunaBTrevenueReport.Padding = new System.Windows.Forms.Padding(5, 15, 5, 10);
            this.gunaBTrevenueReport.Size = new System.Drawing.Size(232, 50);
            this.gunaBTrevenueReport.TabIndex = 20;
            this.gunaBTrevenueReport.Text = " REPORTS";
            this.gunaBTrevenueReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTrevenueReport.Click += new System.EventHandler(this.gunaBTrevenueReport_Click);
            // 
            // gunaBTupdateRates
            // 
            this.gunaBTupdateRates.BorderRadius = 5;
            this.gunaBTupdateRates.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTupdateRates.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTupdateRates.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTupdateRates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.gunaBTupdateRates.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.gunaBTupdateRates.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaBTupdateRates.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.gunaBTupdateRates.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTupdateRates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaBTupdateRates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.gunaBTupdateRates.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTupdateRates.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTupdateRates.Image")));
            this.gunaBTupdateRates.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTupdateRates.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTupdateRates.Location = new System.Drawing.Point(4, 62);
            this.gunaBTupdateRates.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.gunaBTupdateRates.Name = "gunaBTupdateRates";
            this.gunaBTupdateRates.Padding = new System.Windows.Forms.Padding(5, 15, 5, 10);
            this.gunaBTupdateRates.Size = new System.Drawing.Size(232, 50);
            this.gunaBTupdateRates.TabIndex = 19;
            this.gunaBTupdateRates.Text = "MANAGE RATES";
            this.gunaBTupdateRates.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTupdateRates.Click += new System.EventHandler(this.gunaBTupdateRates_Click);
            // 
            // logoContainer
            // 
            this.logoContainer.Controls.Add(this.label2);
            this.logoContainer.Controls.Add(this.menuButton1);
            this.logoContainer.Controls.Add(this.label1);
            this.logoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoContainer.Location = new System.Drawing.Point(4, 0);
            this.logoContainer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.logoContainer.Name = "logoContainer";
            this.logoContainer.Size = new System.Drawing.Size(232, 62);
            this.logoContainer.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.label2.Location = new System.Drawing.Point(63, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Management PH Inc.";
            // 
            // menuButton1
            // 
            this.menuButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.menuButton1.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.menuButton1.Image = ((System.Drawing.Image)(resources.GetObject("menuButton1.Image")));
            this.menuButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.menuButton1.ImageRotate = 0F;
            this.menuButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.menuButton1.Location = new System.Drawing.Point(9, 11);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.menuButton1.Size = new System.Drawing.Size(45, 45);
            this.menuButton1.TabIndex = 2;
            this.menuButton1.Click += new System.EventHandler(this.menuButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(63, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Metro Parking";
            // 
            // gunaBTLogOut
            // 
            this.gunaBTLogOut.BorderRadius = 10;
            this.gunaBTLogOut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.gunaBTLogOut.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.gunaBTLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaBTLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.gunaBTLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaBTLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.gunaBTLogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaBTLogOut.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTLogOut.Image")));
            this.gunaBTLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTLogOut.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTLogOut.Location = new System.Drawing.Point(4, 572);
            this.gunaBTLogOut.Name = "gunaBTLogOut";
            this.gunaBTLogOut.Padding = new System.Windows.Forms.Padding(5, 15, 5, 10);
            this.gunaBTLogOut.Size = new System.Drawing.Size(232, 50);
            this.gunaBTLogOut.TabIndex = 16;
            this.gunaBTLogOut.Text = "  LOG OUT";
            this.gunaBTLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTLogOut.Click += new System.EventHandler(this.gunaBTLogOut_Click);
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.LightGray;
            this.mainContainer.Controls.Add(this.guna2PictureBox1);
            this.mainContainer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainContainer.ForeColor = System.Drawing.Color.Black;
            this.mainContainer.Location = new System.Drawing.Point(73, 24);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1018, 620);
            this.mainContainer.TabIndex = 7;
            this.mainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContainer_Paint);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1018, 620);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 1;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick_1);
            // 
            // mainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1094, 648);
            this.ControlBox = false;
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mainFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mainFormAdmin_Load);
            this.Shown += new System.EventHandler(this.mainFormAdmin_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.logoContainer.ResumeLayout(false);
            this.logoContainer.PerformLayout();
            this.mainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btMinimized;
        private Guna.UI2.WinForms.Guna2Button btExit;
        private System.Windows.Forms.Panel sidebar;
        private Guna.UI2.WinForms.Guna2Button gunaBTLogOut;
        private System.Windows.Forms.Panel mainContainer;
        public Guna.UI2.WinForms.Guna2Button gunaBTmanageEmployee;
        public Guna.UI2.WinForms.Guna2Button gunaBTrevenueReport;
        public Guna.UI2.WinForms.Guna2Button gunaBTupdateRates;
        private System.Windows.Forms.Panel logoContainer;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton menuButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        public Guna.UI2.WinForms.Guna2Button gunaBTadminSettings;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}