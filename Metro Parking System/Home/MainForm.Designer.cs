namespace Metro_Parking_System
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbJobDesc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbEmpName = new System.Windows.Forms.Label();
            this.btMinimized = new Guna.UI2.WinForms.Guna2Button();
            this.btExit = new Guna.UI2.WinForms.Guna2Button();
            this.sidebar = new System.Windows.Forms.Panel();
            this.gunaBTLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBTlog = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBTmap = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBTrates = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBTvehicle = new Guna.UI2.WinForms.Guna2Button();
            this.logoContainer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.mainContainer = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
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
            this.panel1.Controls.Add(this.lbJobDesc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbEmpName);
            this.panel1.Controls.Add(this.btMinimized);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 21);
            this.panel1.TabIndex = 0;
            // 
            // lbJobDesc
            // 
            this.lbJobDesc.AutoSize = true;
            this.lbJobDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbJobDesc.Location = new System.Drawing.Point(533, 0);
            this.lbJobDesc.Name = "lbJobDesc";
            this.lbJobDesc.Size = new System.Drawing.Size(49, 21);
            this.lbJobDesc.TabIndex = 8;
            this.lbJobDesc.Text = "ROLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "EMPLOYEE NAME:";
            // 
            // lbEmpName
            // 
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbEmpName.Location = new System.Drawing.Point(147, 0);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(58, 21);
            this.lbEmpName.TabIndex = 6;
            this.lbEmpName.Text = "NAME";
            this.lbEmpName.Click += new System.EventHandler(this.lbEmpName_Click);
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
            this.sidebar.Controls.Add(this.gunaBTLogOut);
            this.sidebar.Controls.Add(this.gunaBTlog);
            this.sidebar.Controls.Add(this.gunaBTmap);
            this.sidebar.Controls.Add(this.gunaBTrates);
            this.sidebar.Controls.Add(this.gunaBTvehicle);
            this.sidebar.Controls.Add(this.logoContainer);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 21);
            this.sidebar.MaximumSize = new System.Drawing.Size(240, 627);
            this.sidebar.MinimumSize = new System.Drawing.Size(70, 627);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 5);
            this.sidebar.Size = new System.Drawing.Size(240, 627);
            this.sidebar.TabIndex = 2;
            // 
            // gunaBTLogOut
            // 
            this.gunaBTLogOut.BorderRadius = 10;
            this.gunaBTLogOut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.gunaBTLogOut.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
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
            // gunaBTlog
            // 
            this.gunaBTlog.BorderRadius = 5;
            this.gunaBTlog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTlog.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTlog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTlog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.gunaBTlog.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.gunaBTlog.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaBTlog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.gunaBTlog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaBTlog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.gunaBTlog.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTlog.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTlog.Image")));
            this.gunaBTlog.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTlog.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTlog.Location = new System.Drawing.Point(4, 212);
            this.gunaBTlog.Name = "gunaBTlog";
            this.gunaBTlog.Padding = new System.Windows.Forms.Padding(5, 15, 5, 10);
            this.gunaBTlog.Size = new System.Drawing.Size(232, 50);
            this.gunaBTlog.TabIndex = 15;
            this.gunaBTlog.Text = "  LOG";
            this.gunaBTlog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTlog.Click += new System.EventHandler(this.gunaBTlog_Click);
            // 
            // gunaBTmap
            // 
            this.gunaBTmap.BorderRadius = 5;
            this.gunaBTmap.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.gunaBTmap.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gunaBTmap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTmap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.gunaBTmap.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.gunaBTmap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaBTmap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.gunaBTmap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaBTmap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.gunaBTmap.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTmap.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTmap.Image")));
            this.gunaBTmap.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTmap.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTmap.Location = new System.Drawing.Point(4, 162);
            this.gunaBTmap.Name = "gunaBTmap";
            this.gunaBTmap.Padding = new System.Windows.Forms.Padding(5, 15, 5, 10);
            this.gunaBTmap.Size = new System.Drawing.Size(232, 50);
            this.gunaBTmap.TabIndex = 14;
            this.gunaBTmap.Text = "  LOT MAP";
            this.gunaBTmap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTmap.Click += new System.EventHandler(this.gunaBTmap_Click);
            // 
            // gunaBTrates
            // 
            this.gunaBTrates.BorderRadius = 5;
            this.gunaBTrates.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTrates.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTrates.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTrates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.gunaBTrates.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.gunaBTrates.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaBTrates.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.gunaBTrates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaBTrates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.gunaBTrates.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTrates.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTrates.Image")));
            this.gunaBTrates.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTrates.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTrates.Location = new System.Drawing.Point(4, 112);
            this.gunaBTrates.Name = "gunaBTrates";
            this.gunaBTrates.Padding = new System.Windows.Forms.Padding(5, 15, 5, 10);
            this.gunaBTrates.Size = new System.Drawing.Size(232, 50);
            this.gunaBTrates.TabIndex = 13;
            this.gunaBTrates.Text = "  PARKING RATES";
            this.gunaBTrates.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTrates.Click += new System.EventHandler(this.gunaBTrates_Click);
            // 
            // gunaBTvehicle
            // 
            this.gunaBTvehicle.BorderRadius = 5;
            this.gunaBTvehicle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.gunaBTvehicle.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTvehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTvehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.gunaBTvehicle.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.gunaBTvehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaBTvehicle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.gunaBTvehicle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTvehicle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaBTvehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(229)))));
            this.gunaBTvehicle.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTvehicle.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTvehicle.Image")));
            this.gunaBTvehicle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTvehicle.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTvehicle.Location = new System.Drawing.Point(4, 62);
            this.gunaBTvehicle.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.gunaBTvehicle.Name = "gunaBTvehicle";
            this.gunaBTvehicle.Padding = new System.Windows.Forms.Padding(5, 15, 5, 10);
            this.gunaBTvehicle.Size = new System.Drawing.Size(232, 50);
            this.gunaBTvehicle.TabIndex = 12;
            this.gunaBTvehicle.Text = "  VEHICLE IN/OUT";
            this.gunaBTvehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTvehicle.Click += new System.EventHandler(this.gunaBTvehicle_Click);
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
            this.logoContainer.TabIndex = 3;
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
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 1;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
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
            this.mainContainer.TabIndex = 6;
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
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1094, 648);
            this.ControlBox = false;
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
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
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel logoContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button gunaBTLogOut;
        private System.Windows.Forms.Timer sidebarTimer;
        private Guna.UI2.WinForms.Guna2Button btExit;
        private Guna.UI2.WinForms.Guna2Button btMinimized;
        public Guna.UI2.WinForms.Guna2Button gunaBTvehicle;
        public Guna.UI2.WinForms.Guna2Button gunaBTlog;
        public Guna.UI2.WinForms.Guna2Button gunaBTmap;
        public Guna.UI2.WinForms.Guna2Button gunaBTrates;
        private Guna.UI2.WinForms.Guna2ImageButton menuButton1;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbEmpName;
        private System.Windows.Forms.Label lbJobDesc;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

