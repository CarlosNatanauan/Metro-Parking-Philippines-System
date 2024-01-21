namespace Metro_Parking_System.AdmPrompts
{
    partial class FixSchedAndJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixSchedAndJob));
            this.labelPrompt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbShift1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbJobDescription1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbShift2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbJobDescription2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbShift3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbJobDescription3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbShift4 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbJobDescription4 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbEmp1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbEmp2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbEmp3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbEmp4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            this.labelPrompt.BackColor = System.Drawing.Color.Transparent;
            this.labelPrompt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.labelPrompt.Location = new System.Drawing.Point(73, 26);
            this.labelPrompt.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(436, 34);
            this.labelPrompt.TabIndex = 8;
            this.labelPrompt.Text = "SHIFT SCHEDULE & JOB DESCRIPTION";
            // 
            // cbShift1
            // 
            this.cbShift1.BackColor = System.Drawing.Color.Transparent;
            this.cbShift1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbShift1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShift1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShift1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShift1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbShift1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbShift1.ItemHeight = 30;
            this.cbShift1.Items.AddRange(new object[] {
            "Morning",
            "Afternoon"});
            this.cbShift1.Location = new System.Drawing.Point(321, 111);
            this.cbShift1.Name = "cbShift1";
            this.cbShift1.Size = new System.Drawing.Size(110, 36);
            this.cbShift1.StartIndex = 0;
            this.cbShift1.TabIndex = 9;
            this.cbShift1.SelectedIndexChanged += new System.EventHandler(this.cbShift1_SelectedIndexChanged);
            // 
            // cbJobDescription1
            // 
            this.cbJobDescription1.BackColor = System.Drawing.Color.Transparent;
            this.cbJobDescription1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbJobDescription1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobDescription1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbJobDescription1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbJobDescription1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbJobDescription1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbJobDescription1.ItemHeight = 30;
            this.cbJobDescription1.Items.AddRange(new object[] {
            "Entry Lead",
            "Exit Lead"});
            this.cbJobDescription1.Location = new System.Drawing.Point(451, 111);
            this.cbJobDescription1.Name = "cbJobDescription1";
            this.cbJobDescription1.Size = new System.Drawing.Size(110, 36);
            this.cbJobDescription1.StartIndex = 0;
            this.cbJobDescription1.TabIndex = 10;
            this.cbJobDescription1.SelectedIndexChanged += new System.EventHandler(this.cbJobDescription1_SelectedIndexChanged);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(321, 78);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(113, 23);
            this.guna2HtmlLabel7.TabIndex = 25;
            this.guna2HtmlLabel7.Text = "Shift Schedule";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(451, 78);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(122, 23);
            this.guna2HtmlLabel1.TabIndex = 25;
            this.guna2HtmlLabel1.Text = "Job Description";
            // 
            // cbShift2
            // 
            this.cbShift2.BackColor = System.Drawing.Color.Transparent;
            this.cbShift2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbShift2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShift2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShift2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShift2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbShift2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbShift2.ItemHeight = 30;
            this.cbShift2.Items.AddRange(new object[] {
            "Morning",
            "Afternoon"});
            this.cbShift2.Location = new System.Drawing.Point(321, 153);
            this.cbShift2.Name = "cbShift2";
            this.cbShift2.Size = new System.Drawing.Size(110, 36);
            this.cbShift2.StartIndex = 0;
            this.cbShift2.TabIndex = 9;
            this.cbShift2.SelectedIndexChanged += new System.EventHandler(this.cbShift2_SelectedIndexChanged);
            // 
            // cbJobDescription2
            // 
            this.cbJobDescription2.BackColor = System.Drawing.Color.Transparent;
            this.cbJobDescription2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbJobDescription2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobDescription2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbJobDescription2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbJobDescription2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbJobDescription2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbJobDescription2.ItemHeight = 30;
            this.cbJobDescription2.Items.AddRange(new object[] {
            "Entry Lead",
            "Exit Lead"});
            this.cbJobDescription2.Location = new System.Drawing.Point(451, 153);
            this.cbJobDescription2.Name = "cbJobDescription2";
            this.cbJobDescription2.Size = new System.Drawing.Size(110, 36);
            this.cbJobDescription2.StartIndex = 0;
            this.cbJobDescription2.TabIndex = 10;
            this.cbJobDescription2.SelectedIndexChanged += new System.EventHandler(this.cbJobDescription2_SelectedIndexChanged);
            // 
            // cbShift3
            // 
            this.cbShift3.BackColor = System.Drawing.Color.Transparent;
            this.cbShift3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbShift3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShift3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShift3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShift3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbShift3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbShift3.ItemHeight = 30;
            this.cbShift3.Items.AddRange(new object[] {
            "Morning",
            "Afternoon"});
            this.cbShift3.Location = new System.Drawing.Point(321, 195);
            this.cbShift3.Name = "cbShift3";
            this.cbShift3.Size = new System.Drawing.Size(110, 36);
            this.cbShift3.StartIndex = 0;
            this.cbShift3.TabIndex = 9;
            this.cbShift3.SelectedIndexChanged += new System.EventHandler(this.cbShift3_SelectedIndexChanged);
            // 
            // cbJobDescription3
            // 
            this.cbJobDescription3.BackColor = System.Drawing.Color.Transparent;
            this.cbJobDescription3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbJobDescription3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobDescription3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbJobDescription3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbJobDescription3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbJobDescription3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbJobDescription3.ItemHeight = 30;
            this.cbJobDescription3.Items.AddRange(new object[] {
            "Entry Lead",
            "Exit Lead"});
            this.cbJobDescription3.Location = new System.Drawing.Point(451, 195);
            this.cbJobDescription3.Name = "cbJobDescription3";
            this.cbJobDescription3.Size = new System.Drawing.Size(110, 36);
            this.cbJobDescription3.StartIndex = 0;
            this.cbJobDescription3.TabIndex = 10;
            this.cbJobDescription3.SelectedIndexChanged += new System.EventHandler(this.cbJobDescription3_SelectedIndexChanged);
            // 
            // cbShift4
            // 
            this.cbShift4.BackColor = System.Drawing.Color.Transparent;
            this.cbShift4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbShift4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShift4.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShift4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShift4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbShift4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbShift4.ItemHeight = 30;
            this.cbShift4.Items.AddRange(new object[] {
            "Morning",
            "Afternoon"});
            this.cbShift4.Location = new System.Drawing.Point(321, 237);
            this.cbShift4.Name = "cbShift4";
            this.cbShift4.Size = new System.Drawing.Size(110, 36);
            this.cbShift4.StartIndex = 0;
            this.cbShift4.TabIndex = 9;
            this.cbShift4.SelectedIndexChanged += new System.EventHandler(this.cbShift4_SelectedIndexChanged);
            // 
            // cbJobDescription4
            // 
            this.cbJobDescription4.BackColor = System.Drawing.Color.Transparent;
            this.cbJobDescription4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbJobDescription4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobDescription4.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbJobDescription4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbJobDescription4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbJobDescription4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbJobDescription4.ItemHeight = 30;
            this.cbJobDescription4.Items.AddRange(new object[] {
            "Entry Lead",
            "Exit Lead"});
            this.cbJobDescription4.Location = new System.Drawing.Point(451, 237);
            this.cbJobDescription4.Name = "cbJobDescription4";
            this.cbJobDescription4.Size = new System.Drawing.Size(110, 36);
            this.cbJobDescription4.StartIndex = 0;
            this.cbJobDescription4.TabIndex = 10;
            this.cbJobDescription4.SelectedIndexChanged += new System.EventHandler(this.cbJobDescription4_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(23, 78);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(129, 23);
            this.guna2HtmlLabel2.TabIndex = 26;
            this.guna2HtmlLabel2.Text = "Employee Name";
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
            this.buttonCancel.Location = new System.Drawing.Point(411, 296);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(71, 39);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "EXIT";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BorderRadius = 5;
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.buttonSave.Location = new System.Drawing.Point(492, 296);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(69, 39);
            this.buttonSave.TabIndex = 27;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(23, 301);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(91, 34);
            this.guna2HtmlLabel3.TabIndex = 29;
            this.guna2HtmlLabel3.Text = "STATUS";
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbStatus.Location = new System.Drawing.Point(124, 301);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(91, 34);
            this.lbStatus.TabIndex = 29;
            this.lbStatus.Text = "STATUS";
            this.lbStatus.Click += new System.EventHandler(this.lbStatus_Click);
            // 
            // lbEmp1
            // 
            this.lbEmp1.BackColor = System.Drawing.Color.Transparent;
            this.lbEmp1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmp1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.lbEmp1.Location = new System.Drawing.Point(23, 117);
            this.lbEmp1.Name = "lbEmp1";
            this.lbEmp1.Size = new System.Drawing.Size(236, 27);
            this.lbEmp1.TabIndex = 26;
            this.lbEmp1.Text = "Natanauan, Carlos Benedict";
            this.lbEmp1.Click += new System.EventHandler(this.lbEmp1_Click);
            // 
            // lbEmp2
            // 
            this.lbEmp2.BackColor = System.Drawing.Color.Transparent;
            this.lbEmp2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.lbEmp2.Location = new System.Drawing.Point(23, 159);
            this.lbEmp2.Name = "lbEmp2";
            this.lbEmp2.Size = new System.Drawing.Size(236, 27);
            this.lbEmp2.TabIndex = 26;
            this.lbEmp2.Text = "Natanauan, Carlos Benedict";
            this.lbEmp2.Click += new System.EventHandler(this.lbEmp2_Click);
            // 
            // lbEmp3
            // 
            this.lbEmp3.BackColor = System.Drawing.Color.Transparent;
            this.lbEmp3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmp3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.lbEmp3.Location = new System.Drawing.Point(23, 201);
            this.lbEmp3.Name = "lbEmp3";
            this.lbEmp3.Size = new System.Drawing.Size(236, 27);
            this.lbEmp3.TabIndex = 26;
            this.lbEmp3.Text = "Natanauan, Carlos Benedict";
            this.lbEmp3.Click += new System.EventHandler(this.lbEmp3_Click);
            // 
            // lbEmp4
            // 
            this.lbEmp4.BackColor = System.Drawing.Color.Transparent;
            this.lbEmp4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmp4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.lbEmp4.Location = new System.Drawing.Point(23, 243);
            this.lbEmp4.Name = "lbEmp4";
            this.lbEmp4.Size = new System.Drawing.Size(236, 27);
            this.lbEmp4.TabIndex = 26;
            this.lbEmp4.Text = "Natanauan, Carlos Benedict";
            this.lbEmp4.Click += new System.EventHandler(this.lbEmp4_Click);
            // 
            // FixSchedAndJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 355);
            this.ControlBox = false;
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.lbEmp4);
            this.Controls.Add(this.lbEmp3);
            this.Controls.Add(this.lbEmp2);
            this.Controls.Add(this.lbEmp1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.cbJobDescription4);
            this.Controls.Add(this.cbJobDescription3);
            this.Controls.Add(this.cbJobDescription2);
            this.Controls.Add(this.cbJobDescription1);
            this.Controls.Add(this.cbShift4);
            this.Controls.Add(this.cbShift3);
            this.Controls.Add(this.cbShift2);
            this.Controls.Add(this.cbShift1);
            this.Controls.Add(this.labelPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FixSchedAndJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FixSchedAndJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel labelPrompt;
        private Guna.UI2.WinForms.Guna2ComboBox cbShift1;
        private Guna.UI2.WinForms.Guna2ComboBox cbJobDescription1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2ComboBox cbJobDescription4;
        private Guna.UI2.WinForms.Guna2ComboBox cbJobDescription3;
        private Guna.UI2.WinForms.Guna2ComboBox cbJobDescription2;
        private Guna.UI2.WinForms.Guna2ComboBox cbShift4;
        private Guna.UI2.WinForms.Guna2ComboBox cbShift3;
        private Guna.UI2.WinForms.Guna2ComboBox cbShift2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbEmp1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbEmp4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbEmp3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbEmp2;
    }
}