namespace Metro_Parking_System
{
    partial class frmParkingRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParkingRate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btCloseRates = new Guna.UI2.WinForms.Guna2Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.realTime = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbRateCasSucHours = new System.Windows.Forms.Label();
            this.lbRateCasTwoHours = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbRateFlatEntry = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbOthersPenOverStay = new System.Windows.Forms.Label();
            this.lbOthersDisPwdSen = new System.Windows.Forms.Label();
            this.lbOthersPenLossTix = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btCloseRates);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 31);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "PARKING RATES";
            // 
            // btCloseRates
            // 
            this.btCloseRates.BorderRadius = 5;
            this.btCloseRates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCloseRates.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCloseRates.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCloseRates.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCloseRates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCloseRates.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btCloseRates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCloseRates.ForeColor = System.Drawing.Color.White;
            this.btCloseRates.Location = new System.Drawing.Point(951, 3);
            this.btCloseRates.Name = "btCloseRates";
            this.btCloseRates.Size = new System.Drawing.Size(62, 25);
            this.btCloseRates.TabIndex = 0;
            this.btCloseRates.Text = "CLOSE";
            this.btCloseRates.Click += new System.EventHandler(this.btCloseRates_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(443, 3);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(137, 25);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "HH:MM:SS:TT";
            // 
            // realTime
            // 
            this.realTime.Tick += new System.EventHandler(this.realTime_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label6.Location = new System.Drawing.Point(10, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "First 2 hrs of part thereof";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label7.Location = new System.Drawing.Point(10, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "Succeeding hours";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label10.Location = new System.Drawing.Point(10, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "Per entry/day";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRateCasSucHours
            // 
            this.lbRateCasSucHours.AutoSize = true;
            this.lbRateCasSucHours.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRateCasSucHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbRateCasSucHours.Location = new System.Drawing.Point(332, 179);
            this.lbRateCasSucHours.Name = "lbRateCasSucHours";
            this.lbRateCasSucHours.Size = new System.Drawing.Size(28, 32);
            this.lbRateCasSucHours.TabIndex = 12;
            this.lbRateCasSucHours.Text = "0";
            this.lbRateCasSucHours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbRateCasSucHours.Click += new System.EventHandler(this.label12_Click);
            // 
            // lbRateCasTwoHours
            // 
            this.lbRateCasTwoHours.AutoSize = true;
            this.lbRateCasTwoHours.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRateCasTwoHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbRateCasTwoHours.Location = new System.Drawing.Point(332, 137);
            this.lbRateCasTwoHours.Name = "lbRateCasTwoHours";
            this.lbRateCasTwoHours.Size = new System.Drawing.Size(28, 32);
            this.lbRateCasTwoHours.TabIndex = 12;
            this.lbRateCasTwoHours.Text = "0";
            this.lbRateCasTwoHours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbRateCasTwoHours.Click += new System.EventHandler(this.label12_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label14.Location = new System.Drawing.Point(332, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 32);
            this.label14.TabIndex = 12;
            this.label14.Text = "Free";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Click += new System.EventHandler(this.label12_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.label18);
            this.guna2GroupBox3.Controls.Add(this.label17);
            this.guna2GroupBox3.Controls.Add(this.label19);
            this.guna2GroupBox3.Controls.Add(this.label16);
            this.guna2GroupBox3.Controls.Add(this.label4);
            this.guna2GroupBox3.Controls.Add(this.label3);
            this.guna2GroupBox3.Controls.Add(this.label5);
            this.guna2GroupBox3.Controls.Add(this.label10);
            this.guna2GroupBox3.Controls.Add(this.label14);
            this.guna2GroupBox3.Controls.Add(this.label6);
            this.guna2GroupBox3.Controls.Add(this.lbRateFlatEntry);
            this.guna2GroupBox3.Controls.Add(this.lbRateCasTwoHours);
            this.guna2GroupBox3.Controls.Add(this.label7);
            this.guna2GroupBox3.Controls.Add(this.lbRateCasSucHours);
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(7, 42, 7, 7);
            this.guna2GroupBox3.CustomizableEdges.BottomLeft = false;
            this.guna2GroupBox3.CustomizableEdges.BottomRight = false;
            this.guna2GroupBox3.CustomizableEdges.TopLeft = false;
            this.guna2GroupBox3.CustomizableEdges.TopRight = false;
            this.guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2GroupBox3.Location = new System.Drawing.Point(23, 77);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(450, 321);
            this.guna2GroupBox3.TabIndex = 119;
            this.guna2GroupBox3.Text = "RATES";
            this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label18.Location = new System.Drawing.Point(316, 95);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 32);
            this.label18.TabIndex = 122;
            this.label18.Text = ":";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label17.Location = new System.Drawing.Point(316, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 32);
            this.label17.TabIndex = 122;
            this.label17.Text = ":";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label19.Location = new System.Drawing.Point(316, 271);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 32);
            this.label19.TabIndex = 122;
            this.label19.Text = ":";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label16.Location = new System.Drawing.Point(316, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 32);
            this.label16.TabIndex = 122;
            this.label16.Text = ":";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(10, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 32);
            this.label4.TabIndex = 121;
            this.label4.Text = "Motors and E-Bikes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 32);
            this.label3.TabIndex = 120;
            this.label3.Text = "Cars and Tricycles";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label5.Location = new System.Drawing.Point(10, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "10 minutes (grace period)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRateFlatEntry
            // 
            this.lbRateFlatEntry.AutoSize = true;
            this.lbRateFlatEntry.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRateFlatEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbRateFlatEntry.Location = new System.Drawing.Point(332, 271);
            this.lbRateFlatEntry.Name = "lbRateFlatEntry";
            this.lbRateFlatEntry.Size = new System.Drawing.Size(28, 32);
            this.lbRateFlatEntry.TabIndex = 12;
            this.lbRateFlatEntry.Text = "0";
            this.lbRateFlatEntry.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbRateFlatEntry.Click += new System.EventHandler(this.label12_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label28);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.label31);
            this.guna2GroupBox1.Controls.Add(this.label27);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label30);
            this.guna2GroupBox1.Controls.Add(this.label20);
            this.guna2GroupBox1.Controls.Add(this.label21);
            this.guna2GroupBox1.Controls.Add(this.lbOthersPenOverStay);
            this.guna2GroupBox1.Controls.Add(this.lbOthersDisPwdSen);
            this.guna2GroupBox1.Controls.Add(this.lbOthersPenLossTix);
            this.guna2GroupBox1.Controls.Add(this.label11);
            this.guna2GroupBox1.Controls.Add(this.label24);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(7, 42, 7, 7);
            this.guna2GroupBox1.CustomizableEdges.BottomLeft = false;
            this.guna2GroupBox1.CustomizableEdges.BottomRight = false;
            this.guna2GroupBox1.CustomizableEdges.TopLeft = false;
            this.guna2GroupBox1.CustomizableEdges.TopRight = false;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2GroupBox1.Location = new System.Drawing.Point(479, 77);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(514, 321);
            this.guna2GroupBox1.TabIndex = 123;
            this.guna2GroupBox1.Text = "OTHERS";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label28.Location = new System.Drawing.Point(158, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(19, 32);
            this.label28.TabIndex = 122;
            this.label28.Text = ":";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(10, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 32);
            this.label9.TabIndex = 124;
            this.label9.Text = "Discount";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label31.Location = new System.Drawing.Point(158, 271);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(21, 32);
            this.label31.TabIndex = 122;
            this.label31.Text = ":";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label27.Location = new System.Drawing.Point(158, 134);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(19, 32);
            this.label27.TabIndex = 122;
            this.label27.Text = ":";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(10, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 32);
            this.label8.TabIndex = 123;
            this.label8.Text = "Penalties";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label30.Location = new System.Drawing.Point(10, 271);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(143, 32);
            this.label30.TabIndex = 13;
            this.label30.Text = "Senior/PWD";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label20.Location = new System.Drawing.Point(10, 134);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 32);
            this.label20.TabIndex = 13;
            this.label20.Text = "Overstaying ";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label21.Location = new System.Drawing.Point(10, 92);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 32);
            this.label21.TabIndex = 12;
            this.label21.Text = "Lost ticket";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbOthersPenOverStay
            // 
            this.lbOthersPenOverStay.AutoSize = true;
            this.lbOthersPenOverStay.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOthersPenOverStay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbOthersPenOverStay.Location = new System.Drawing.Point(381, 134);
            this.lbOthersPenOverStay.Name = "lbOthersPenOverStay";
            this.lbOthersPenOverStay.Size = new System.Drawing.Size(28, 32);
            this.lbOthersPenOverStay.TabIndex = 12;
            this.lbOthersPenOverStay.Text = "0";
            this.lbOthersPenOverStay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbOthersPenOverStay.Click += new System.EventHandler(this.label12_Click);
            // 
            // lbOthersDisPwdSen
            // 
            this.lbOthersDisPwdSen.AutoSize = true;
            this.lbOthersDisPwdSen.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOthersDisPwdSen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbOthersDisPwdSen.Location = new System.Drawing.Point(174, 271);
            this.lbOthersDisPwdSen.Name = "lbOthersDisPwdSen";
            this.lbOthersDisPwdSen.Size = new System.Drawing.Size(28, 32);
            this.lbOthersDisPwdSen.TabIndex = 12;
            this.lbOthersDisPwdSen.Text = "2";
            this.lbOthersDisPwdSen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbOthersDisPwdSen.Click += new System.EventHandler(this.label12_Click);
            // 
            // lbOthersPenLossTix
            // 
            this.lbOthersPenLossTix.AutoSize = true;
            this.lbOthersPenLossTix.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOthersPenLossTix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbOthersPenLossTix.Location = new System.Drawing.Point(381, 92);
            this.lbOthersPenLossTix.Name = "lbOthersPenLossTix";
            this.lbOthersPenLossTix.Size = new System.Drawing.Size(28, 32);
            this.lbOthersPenLossTix.TabIndex = 12;
            this.lbOthersPenLossTix.Text = "0";
            this.lbOthersPenLossTix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbOthersPenLossTix.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label11.Location = new System.Drawing.Point(174, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 32);
            this.label11.TabIndex = 12;
            this.label11.Text = "Parking Charge + ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Click += new System.EventHandler(this.label12_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label24.Location = new System.Drawing.Point(174, 92);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(205, 32);
            this.label24.TabIndex = 12;
            this.label24.Text = "Parking Charge + ";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label24.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(360, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "PARKING ADVISORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label26.Location = new System.Drawing.Point(228, 401);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(560, 40);
            this.label26.TabIndex = 3;
            this.label26.Text = "OPERATION HOURS : 8:00 AM - 9:00PM";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label33.Location = new System.Drawing.Point(448, 453);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(120, 40);
            this.label33.TabIndex = 3;
            this.label33.Text = "NOTICE";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label29.Location = new System.Drawing.Point(310, 493);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(396, 32);
            this.label29.TabIndex = 124;
            this.label29.Text = "STRICTLY NO PASSING THROUGH";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label32.Location = new System.Drawing.Point(408, 525);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(201, 32);
            this.label32.TabIndex = 124;
            this.label32.Text = "LOCK YOUR CAR";
            this.label32.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(352, 557);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(313, 32);
            this.label12.TabIndex = 125;
            this.label12.Text = "PARK AT YOUR OWN RISK";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmParkingRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1016, 618);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmParkingRate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmParkingRate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer realTime;
        private Guna.UI2.WinForms.Guna2Button btCloseRates;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbRateCasSucHours;
        private System.Windows.Forms.Label lbRateCasTwoHours;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRateFlatEntry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbOthersPenLossTix;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbOthersPenOverStay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lbOthersDisPwdSen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label12;
    }
}