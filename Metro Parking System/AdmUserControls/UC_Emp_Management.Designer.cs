namespace Metro_Parking_System.AdmUserControls
{
    partial class UC_Emp_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Emp_Management));
            this.cbEmployeeSelector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btShowPass = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btShowUser = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTimeEnd = new System.Windows.Forms.Label();
            this.lbShift = new System.Windows.Forms.Label();
            this.lbTimeStart = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.EmpShowPic = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lbJobdesc = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbLname = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbMname = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbFname = new System.Windows.Forms.Label();
            this.btReset = new Guna.UI2.WinForms.Guna2Button();
            this.btUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btClearAll = new Guna.UI2.WinForms.Guna2Button();
            this.btDeployStats = new Guna.UI2.WinForms.Guna2Button();
            this.btDeployeSub = new Guna.UI2.WinForms.Guna2Button();
            this.btFixShiftJob = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.RefreshForm = new System.Windows.Forms.Timer(this.components);
            this.CheckDatabase = new System.Windows.Forms.Timer(this.components);
            this.CheckSubstitue = new System.Windows.Forms.Timer(this.components);
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpShowPic)).BeginInit();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEmployeeSelector
            // 
            this.cbEmployeeSelector.BackColor = System.Drawing.SystemColors.Control;
            this.cbEmployeeSelector.BorderColor = System.Drawing.Color.Gray;
            this.cbEmployeeSelector.BorderRadius = 5;
            this.cbEmployeeSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEmployeeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployeeSelector.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEmployeeSelector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEmployeeSelector.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.cbEmployeeSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbEmployeeSelector.ItemHeight = 44;
            this.cbEmployeeSelector.Items.AddRange(new object[] {
            "EMPLOYEE 1",
            "EMPLOYEE 2",
            "EMPLOYEE 3",
            "EMPLOYEE 4",
            "SUBSTITUTE 1",
            "SUBSTITUTE 2"});
            this.cbEmployeeSelector.Location = new System.Drawing.Point(535, 12);
            this.cbEmployeeSelector.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmployeeSelector.Name = "cbEmployeeSelector";
            this.cbEmployeeSelector.Size = new System.Drawing.Size(217, 50);
            this.cbEmployeeSelector.StartIndex = 0;
            this.cbEmployeeSelector.TabIndex = 88;
            this.cbEmployeeSelector.SelectedIndexChanged += new System.EventHandler(this.cbEmployeeSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 45);
            this.label1.TabIndex = 122;
            this.label1.Text = "Select Employee to View/Update:";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lbPassword);
            this.guna2GroupBox1.Controls.Add(this.lbUserName);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.btShowPass);
            this.guna2GroupBox1.Controls.Add(this.btShowUser);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.guna2GroupBox1.CustomizableEdges.BottomLeft = false;
            this.guna2GroupBox1.CustomizableEdges.BottomRight = false;
            this.guna2GroupBox1.CustomizableEdges.TopLeft = false;
            this.guna2GroupBox1.CustomizableEdges.TopRight = false;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(601, 249);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(382, 149);
            this.guna2GroupBox1.TabIndex = 111;
            this.guna2GroupBox1.Text = "LOGIN CREDENTIALS";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbPassword.Location = new System.Drawing.Point(151, 98);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(54, 37);
            this.lbPassword.TabIndex = 117;
            this.lbPassword.Text = "NA";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbUserName.Location = new System.Drawing.Point(151, 47);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(54, 37);
            this.lbUserName.TabIndex = 116;
            this.lbUserName.Text = "NA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label4.Location = new System.Drawing.Point(136, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 37);
            this.label4.TabIndex = 115;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label3.Location = new System.Drawing.Point(136, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 37);
            this.label3.TabIndex = 114;
            this.label3.Text = ":";
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
            this.btShowPass.Location = new System.Drawing.Point(321, 95);
            this.btShowPass.Name = "btShowPass";
            this.btShowPass.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btShowPass.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.btShowPass.Size = new System.Drawing.Size(44, 40);
            this.btShowPass.TabIndex = 112;
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
            this.btShowUser.Location = new System.Drawing.Point(321, 44);
            this.btShowUser.Name = "btShowUser";
            this.btShowUser.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btShowUser.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.btShowUser.Size = new System.Drawing.Size(44, 40);
            this.btShowUser.TabIndex = 112;
            this.btShowUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btShowUser_MouseDown);
            this.btShowUser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btShowUser_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label7.Location = new System.Drawing.Point(11, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 37);
            this.label7.TabIndex = 102;
            this.label7.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 94;
            this.label2.Text = "Username";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.Controls.Add(this.label10);
            this.guna2GroupBox2.Controls.Add(this.lbTimeEnd);
            this.guna2GroupBox2.Controls.Add(this.lbShift);
            this.guna2GroupBox2.Controls.Add(this.lbTimeStart);
            this.guna2GroupBox2.Controls.Add(this.label12);
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.guna2GroupBox2.CustomizableEdges.BottomLeft = false;
            this.guna2GroupBox2.CustomizableEdges.BottomRight = false;
            this.guna2GroupBox2.CustomizableEdges.TopLeft = false;
            this.guna2GroupBox2.CustomizableEdges.TopRight = false;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(601, 11);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(382, 232);
            this.guna2GroupBox2.TabIndex = 118;
            this.guna2GroupBox2.Text = "JOB SHIFT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label10.Location = new System.Drawing.Point(166, 129);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 37);
            this.label10.TabIndex = 118;
            this.label10.Text = "TO";
            // 
            // lbTimeEnd
            // 
            this.lbTimeEnd.AutoSize = true;
            this.lbTimeEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbTimeEnd.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbTimeEnd.Location = new System.Drawing.Point(128, 171);
            this.lbTimeEnd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTimeEnd.Name = "lbTimeEnd";
            this.lbTimeEnd.Size = new System.Drawing.Size(127, 37);
            this.lbTimeEnd.TabIndex = 117;
            this.lbTimeEnd.Text = "00:00 NA";
            // 
            // lbShift
            // 
            this.lbShift.AutoSize = true;
            this.lbShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbShift.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.lbShift.Location = new System.Drawing.Point(11, 47);
            this.lbShift.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(78, 37);
            this.lbShift.TabIndex = 116;
            this.lbShift.Text = "Shift";
            // 
            // lbTimeStart
            // 
            this.lbTimeStart.AutoSize = true;
            this.lbTimeStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbTimeStart.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.lbTimeStart.Location = new System.Drawing.Point(128, 85);
            this.lbTimeStart.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTimeStart.Name = "lbTimeStart";
            this.lbTimeStart.Size = new System.Drawing.Size(127, 37);
            this.lbTimeStart.TabIndex = 94;
            this.lbTimeStart.Text = "00:00 NA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.label12.Location = new System.Drawing.Point(123, 180);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 37);
            this.label12.TabIndex = 102;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.Controls.Add(this.label21);
            this.guna2GroupBox3.Controls.Add(this.EmpShowPic);
            this.guna2GroupBox3.Controls.Add(this.label19);
            this.guna2GroupBox3.Controls.Add(this.lbJobdesc);
            this.guna2GroupBox3.Controls.Add(this.label16);
            this.guna2GroupBox3.Controls.Add(this.lbLname);
            this.guna2GroupBox3.Controls.Add(this.label11);
            this.guna2GroupBox3.Controls.Add(this.lbMname);
            this.guna2GroupBox3.Controls.Add(this.label18);
            this.guna2GroupBox3.Controls.Add(this.lbFname);
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.guna2GroupBox3.CustomizableEdges.BottomLeft = false;
            this.guna2GroupBox3.CustomizableEdges.BottomRight = false;
            this.guna2GroupBox3.CustomizableEdges.TopLeft = false;
            this.guna2GroupBox3.CustomizableEdges.TopRight = false;
            this.guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(8, 11);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(587, 387);
            this.guna2GroupBox3.TabIndex = 119;
            this.guna2GroupBox3.Text = "PERSONAL INFORMATION";
            this.guna2GroupBox3.Click += new System.EventHandler(this.guna2GroupBox3_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label21.Location = new System.Drawing.Point(361, 342);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(118, 20);
            this.label21.TabIndex = 129;
            this.label21.Text = "Employee Photo";
            // 
            // EmpShowPic
            // 
            this.EmpShowPic.Image = ((System.Drawing.Image)(resources.GetObject("EmpShowPic.Image")));
            this.EmpShowPic.Location = new System.Drawing.Point(270, 49);
            this.EmpShowPic.Name = "EmpShowPic";
            this.EmpShowPic.Size = new System.Drawing.Size(300, 290);
            this.EmpShowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmpShowPic.TabIndex = 128;
            this.EmpShowPic.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label19.Location = new System.Drawing.Point(15, 342);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 20);
            this.label19.TabIndex = 127;
            this.label19.Text = "Job description";
            // 
            // lbJobdesc
            // 
            this.lbJobdesc.AutoSize = true;
            this.lbJobdesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbJobdesc.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobdesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.lbJobdesc.Location = new System.Drawing.Point(12, 302);
            this.lbJobdesc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbJobdesc.Name = "lbJobdesc";
            this.lbJobdesc.Size = new System.Drawing.Size(215, 37);
            this.lbJobdesc.TabIndex = 126;
            this.lbJobdesc.Text = "Job description";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label16.Location = new System.Drawing.Point(15, 232);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 20);
            this.label16.TabIndex = 125;
            this.label16.Text = "Last name";
            // 
            // lbLname
            // 
            this.lbLname.AutoSize = true;
            this.lbLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbLname.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.lbLname.Location = new System.Drawing.Point(11, 195);
            this.lbLname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbLname.Name = "lbLname";
            this.lbLname.Size = new System.Drawing.Size(191, 37);
            this.lbLname.TabIndex = 124;
            this.lbLname.Text = "Middle Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label11.Location = new System.Drawing.Point(15, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 123;
            this.label11.Text = "Middle name";
            // 
            // lbMname
            // 
            this.lbMname.AutoSize = true;
            this.lbMname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbMname.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.lbMname.Location = new System.Drawing.Point(11, 121);
            this.lbMname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMname.Name = "lbMname";
            this.lbMname.Size = new System.Drawing.Size(191, 37);
            this.lbMname.TabIndex = 122;
            this.lbMname.Text = "Middle Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.label18.Location = new System.Drawing.Point(15, 84);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 20);
            this.label18.TabIndex = 121;
            this.label18.Text = "Frirst name";
            // 
            // lbFname
            // 
            this.lbFname.AutoSize = true;
            this.lbFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbFname.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.lbFname.Location = new System.Drawing.Point(11, 47);
            this.lbFname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFname.Name = "lbFname";
            this.lbFname.Size = new System.Drawing.Size(156, 37);
            this.lbFname.TabIndex = 117;
            this.lbFname.Text = "First Name";
            // 
            // btReset
            // 
            this.btReset.BorderRadius = 5;
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btReset.Location = new System.Drawing.Point(819, 486);
            this.btReset.Margin = new System.Windows.Forms.Padding(4);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(81, 50);
            this.btReset.TabIndex = 113;
            this.btReset.Text = "RESET";
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BorderRadius = 5;
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btUpdate.Location = new System.Drawing.Point(908, 486);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(94, 50);
            this.btUpdate.TabIndex = 114;
            this.btUpdate.Text = "UPDATE";
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btClearAll);
            this.panel2.Controls.Add(this.btDeployStats);
            this.panel2.Controls.Add(this.btDeployeSub);
            this.panel2.Controls.Add(this.btFixShiftJob);
            this.panel2.Controls.Add(this.cbEmployeeSelector);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btUpdate);
            this.panel2.Controls.Add(this.btReset);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 540);
            this.panel2.TabIndex = 124;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btClearAll
            // 
            this.btClearAll.BorderRadius = 5;
            this.btClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClearAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btClearAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btClearAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btClearAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btClearAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btClearAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btClearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btClearAll.Location = new System.Drawing.Point(12, 486);
            this.btClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.btClearAll.Name = "btClearAll";
            this.btClearAll.Size = new System.Drawing.Size(112, 50);
            this.btClearAll.TabIndex = 134;
            this.btClearAll.Text = "CLEAR ALL";
            this.btClearAll.Click += new System.EventHandler(this.btClearAll_Click);
            // 
            // btDeployStats
            // 
            this.btDeployStats.BorderRadius = 5;
            this.btDeployStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeployStats.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDeployStats.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDeployStats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDeployStats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDeployStats.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btDeployStats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btDeployStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btDeployStats.Location = new System.Drawing.Point(292, 486);
            this.btDeployStats.Margin = new System.Windows.Forms.Padding(4);
            this.btDeployStats.Name = "btDeployStats";
            this.btDeployStats.Size = new System.Drawing.Size(202, 50);
            this.btDeployStats.TabIndex = 133;
            this.btDeployStats.Text = "DEPLOYMENT STATUS";
            this.btDeployStats.Click += new System.EventHandler(this.btDeployStats_Click);
            // 
            // btDeployeSub
            // 
            this.btDeployeSub.BorderRadius = 5;
            this.btDeployeSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeployeSub.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDeployeSub.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDeployeSub.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDeployeSub.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDeployeSub.Enabled = false;
            this.btDeployeSub.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDeployeSub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btDeployeSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btDeployeSub.Location = new System.Drawing.Point(613, 486);
            this.btDeployeSub.Margin = new System.Windows.Forms.Padding(4);
            this.btDeployeSub.Name = "btDeployeSub";
            this.btDeployeSub.Size = new System.Drawing.Size(198, 50);
            this.btDeployeSub.TabIndex = 132;
            this.btDeployeSub.Text = "DEPLOY SUBSTITUTE";
            this.btDeployeSub.Click += new System.EventHandler(this.btDeployeSub_Click);
            // 
            // btFixShiftJob
            // 
            this.btFixShiftJob.BorderRadius = 5;
            this.btFixShiftJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFixShiftJob.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btFixShiftJob.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btFixShiftJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btFixShiftJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btFixShiftJob.Enabled = false;
            this.btFixShiftJob.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btFixShiftJob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btFixShiftJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btFixShiftJob.Location = new System.Drawing.Point(132, 486);
            this.btFixShiftJob.Margin = new System.Windows.Forms.Padding(4);
            this.btFixShiftJob.Name = "btFixShiftJob";
            this.btFixShiftJob.Size = new System.Drawing.Size(152, 50);
            this.btFixShiftJob.TabIndex = 131;
            this.btFixShiftJob.Text = "FIX SHIFT && JOB";
            this.btFixShiftJob.Click += new System.EventHandler(this.btFixShiftJob_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2GroupBox3);
            this.guna2Panel1.Controls.Add(this.guna2GroupBox2);
            this.guna2Panel1.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 69);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(990, 408);
            this.guna2Panel1.TabIndex = 130;
            // 
            // RefreshForm
            // 
            this.RefreshForm.Enabled = true;
            this.RefreshForm.Interval = 3000;
            this.RefreshForm.Tick += new System.EventHandler(this.RefreshForm_Tick);
            // 
            // CheckDatabase
            // 
            this.CheckDatabase.Enabled = true;
            this.CheckDatabase.Tick += new System.EventHandler(this.CheckDatabase_Tick);
            // 
            // UC_Emp_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Emp_Management";
            this.Size = new System.Drawing.Size(1014, 540);
            this.Load += new System.EventHandler(this.UC_Emp_Management_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpShowPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbEmployeeSelector;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTimeEnd;
        private System.Windows.Forms.Label lbShift;
        private System.Windows.Forms.Label lbTimeStart;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton btShowPass;
        private Guna.UI2.WinForms.Guna2ImageButton btShowUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox EmpShowPic;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbJobdesc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbLname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbMname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbFname;
        private Guna.UI2.WinForms.Guna2Button btReset;
        private Guna.UI2.WinForms.Guna2Button btUpdate;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btFixShiftJob;
        private System.Windows.Forms.Timer RefreshForm;
        private System.Windows.Forms.Timer CheckDatabase;
        private Guna.UI2.WinForms.Guna2Button btDeployeSub;
        private Guna.UI2.WinForms.Guna2Button btDeployStats;
        private System.Windows.Forms.Timer CheckSubstitue;
        private Guna.UI2.WinForms.Guna2Button btClearAll;
    }
}
