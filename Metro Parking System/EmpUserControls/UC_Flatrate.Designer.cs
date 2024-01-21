namespace Metro_Parking_System.UserControls
{
    partial class UC_Flatrate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Flatrate));
            this.tbNameFlat = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbVehicleTypeFlat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.placeholderLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.tbplateNoFlatrate = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPlateFlatrate = new Guna.UI2.WinForms.Guna2TextBox();
            this.btSearchFlatrate = new Guna.UI2.WinForms.Guna2Button();
            this.btOutFlatrate = new Guna.UI2.WinForms.Guna2Button();
            this.btInFlatrate = new Guna.UI2.WinForms.Guna2Button();
            this.btbClearFlatrate = new Guna.UI2.WinForms.Guna2Button();
            this.occupied = new System.Windows.Forms.Label();
            this.available = new System.Windows.Forms.Label();
            this.dgvFlatrate = new Guna.UI2.WinForms.Guna2DataGridView();
            this.plateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatraterawBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metro_ParkingDataSet1 = new Metro_Parking_System.Metro_ParkingDataSet1();
            this.flatraterawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metro_Parking = new Metro_Parking_System.Metro_Parking();
            this.flatrate_rawTableAdapter = new Metro_Parking_System.Metro_ParkingTableAdapters.flatrate_rawTableAdapter();
            this.Refresher = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.flatrate_rawTableAdapter1 = new Metro_Parking_System.Metro_ParkingDataSet1TableAdapters.flatrate_rawTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tbIdFlatrate = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatraterawBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_ParkingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatraterawBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_Parking)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNameFlat
            // 
            this.tbNameFlat.BorderColor = System.Drawing.Color.Gray;
            this.tbNameFlat.BorderRadius = 5;
            this.tbNameFlat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameFlat.DefaultText = "";
            this.tbNameFlat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNameFlat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNameFlat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNameFlat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNameFlat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameFlat.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tbNameFlat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNameFlat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameFlat.Location = new System.Drawing.Point(567, 13);
            this.tbNameFlat.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbNameFlat.Name = "tbNameFlat";
            this.tbNameFlat.PasswordChar = '\0';
            this.tbNameFlat.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbNameFlat.PlaceholderText = "DRIVER\'S NAME";
            this.tbNameFlat.SelectedText = "";
            this.tbNameFlat.Size = new System.Drawing.Size(228, 50);
            this.tbNameFlat.TabIndex = 70;
            // 
            // cbVehicleTypeFlat
            // 
            this.cbVehicleTypeFlat.BackColor = System.Drawing.Color.Transparent;
            this.cbVehicleTypeFlat.BorderColor = System.Drawing.Color.Gray;
            this.cbVehicleTypeFlat.BorderRadius = 5;
            this.cbVehicleTypeFlat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVehicleTypeFlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehicleTypeFlat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVehicleTypeFlat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVehicleTypeFlat.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.cbVehicleTypeFlat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbVehicleTypeFlat.ItemHeight = 44;
            this.cbVehicleTypeFlat.Items.AddRange(new object[] {
            "MOTORCYLE",
            "E-BIKE"});
            this.cbVehicleTypeFlat.Location = new System.Drawing.Point(289, 13);
            this.cbVehicleTypeFlat.Margin = new System.Windows.Forms.Padding(4);
            this.cbVehicleTypeFlat.Name = "cbVehicleTypeFlat";
            this.cbVehicleTypeFlat.Size = new System.Drawing.Size(267, 50);
            this.cbVehicleTypeFlat.TabIndex = 69;
            this.cbVehicleTypeFlat.SelectedIndexChanged += new System.EventHandler(this.cbVehicleTypeFlat_SelectedIndexChanged);
            this.cbVehicleTypeFlat.Enter += new System.EventHandler(this.cbVehicleTypeFlat_Enter);
            this.cbVehicleTypeFlat.Leave += new System.EventHandler(this.cbVehicleTypeFlat_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(287, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 47);
            this.label2.TabIndex = 72;
            this.label2.Text = "Available:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(5, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 47);
            this.label1.TabIndex = 71;
            this.label1.Text = "Occupied: ";
            // 
            // placeholderLabel
            // 
            this.placeholderLabel.BackColor = System.Drawing.Color.White;
            this.placeholderLabel.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderLabel.ForeColor = System.Drawing.Color.Silver;
            this.placeholderLabel.Location = new System.Drawing.Point(307, 21);
            this.placeholderLabel.Margin = new System.Windows.Forms.Padding(4);
            this.placeholderLabel.Name = "placeholderLabel";
            this.placeholderLabel.Size = new System.Drawing.Size(223, 33);
            this.placeholderLabel.TabIndex = 75;
            this.placeholderLabel.Text = "SELECT VEHICLE TYPE";
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
            this.btUpdate.Location = new System.Drawing.Point(769, 483);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(94, 50);
            this.btUpdate.TabIndex = 65;
            this.btUpdate.Text = "UPDATE";
            this.btUpdate.Visible = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // tbplateNoFlatrate
            // 
            this.tbplateNoFlatrate.BorderColor = System.Drawing.Color.Gray;
            this.tbplateNoFlatrate.BorderRadius = 5;
            this.tbplateNoFlatrate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbplateNoFlatrate.DefaultText = "";
            this.tbplateNoFlatrate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbplateNoFlatrate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbplateNoFlatrate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbplateNoFlatrate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbplateNoFlatrate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbplateNoFlatrate.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tbplateNoFlatrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbplateNoFlatrate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbplateNoFlatrate.Location = new System.Drawing.Point(12, 13);
            this.tbplateNoFlatrate.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbplateNoFlatrate.Name = "tbplateNoFlatrate";
            this.tbplateNoFlatrate.PasswordChar = '\0';
            this.tbplateNoFlatrate.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbplateNoFlatrate.PlaceholderText = "ENTER PLATE NUMBER";
            this.tbplateNoFlatrate.SelectedText = "";
            this.tbplateNoFlatrate.Size = new System.Drawing.Size(267, 50);
            this.tbplateNoFlatrate.TabIndex = 64;
            this.tbplateNoFlatrate.TextChanged += new System.EventHandler(this.tbplateNoFlatrate_TextChanged);
            // 
            // tbPlateFlatrate
            // 
            this.tbPlateFlatrate.BorderColor = System.Drawing.Color.Gray;
            this.tbPlateFlatrate.BorderRadius = 5;
            this.tbPlateFlatrate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPlateFlatrate.DefaultText = "";
            this.tbPlateFlatrate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPlateFlatrate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPlateFlatrate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPlateFlatrate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPlateFlatrate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPlateFlatrate.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tbPlateFlatrate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPlateFlatrate.Location = new System.Drawing.Point(567, 75);
            this.tbPlateFlatrate.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.tbPlateFlatrate.Name = "tbPlateFlatrate";
            this.tbPlateFlatrate.PasswordChar = '\0';
            this.tbPlateFlatrate.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbPlateFlatrate.PlaceholderText = "SEARCH PLATE";
            this.tbPlateFlatrate.SelectedText = "";
            this.tbPlateFlatrate.Size = new System.Drawing.Size(190, 50);
            this.tbPlateFlatrate.TabIndex = 63;
            this.tbPlateFlatrate.TextChanged += new System.EventHandler(this.tbSearchFlatrate_TextChanged);
            // 
            // btSearchFlatrate
            // 
            this.btSearchFlatrate.BorderRadius = 5;
            this.btSearchFlatrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearchFlatrate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSearchFlatrate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSearchFlatrate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSearchFlatrate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSearchFlatrate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSearchFlatrate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchFlatrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btSearchFlatrate.Location = new System.Drawing.Point(926, 75);
            this.btSearchFlatrate.Margin = new System.Windows.Forms.Padding(4);
            this.btSearchFlatrate.Name = "btSearchFlatrate";
            this.btSearchFlatrate.Size = new System.Drawing.Size(77, 50);
            this.btSearchFlatrate.TabIndex = 62;
            this.btSearchFlatrate.Text = "FIND";
            this.btSearchFlatrate.Click += new System.EventHandler(this.btSearchFlatrate_Click);
            // 
            // btOutFlatrate
            // 
            this.btOutFlatrate.BorderRadius = 5;
            this.btOutFlatrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOutFlatrate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btOutFlatrate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btOutFlatrate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btOutFlatrate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btOutFlatrate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btOutFlatrate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btOutFlatrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btOutFlatrate.Location = new System.Drawing.Point(871, 483);
            this.btOutFlatrate.Margin = new System.Windows.Forms.Padding(4);
            this.btOutFlatrate.Name = "btOutFlatrate";
            this.btOutFlatrate.Size = new System.Drawing.Size(132, 50);
            this.btOutFlatrate.TabIndex = 61;
            this.btOutFlatrate.Text = "VEHICLE OUT";
            this.btOutFlatrate.Click += new System.EventHandler(this.btOutFlatrate_Click);
            // 
            // btInFlatrate
            // 
            this.btInFlatrate.BorderRadius = 5;
            this.btInFlatrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInFlatrate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btInFlatrate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btInFlatrate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btInFlatrate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btInFlatrate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btInFlatrate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInFlatrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btInFlatrate.Location = new System.Drawing.Point(890, 13);
            this.btInFlatrate.Margin = new System.Windows.Forms.Padding(4);
            this.btInFlatrate.Name = "btInFlatrate";
            this.btInFlatrate.Size = new System.Drawing.Size(116, 50);
            this.btInFlatrate.TabIndex = 60;
            this.btInFlatrate.Text = "VEHICLE IN";
            this.btInFlatrate.Click += new System.EventHandler(this.btInFlatrate_Click);
            // 
            // btbClearFlatrate
            // 
            this.btbClearFlatrate.BorderRadius = 5;
            this.btbClearFlatrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbClearFlatrate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btbClearFlatrate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btbClearFlatrate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btbClearFlatrate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btbClearFlatrate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btbClearFlatrate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbClearFlatrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btbClearFlatrate.ImageSize = new System.Drawing.Size(25, 25);
            this.btbClearFlatrate.Location = new System.Drawing.Point(804, 13);
            this.btbClearFlatrate.Margin = new System.Windows.Forms.Padding(4);
            this.btbClearFlatrate.Name = "btbClearFlatrate";
            this.btbClearFlatrate.Size = new System.Drawing.Size(78, 50);
            this.btbClearFlatrate.TabIndex = 67;
            this.btbClearFlatrate.Text = "CLEAR";
            this.btbClearFlatrate.Click += new System.EventHandler(this.btbClearFlatrate_Click);
            // 
            // occupied
            // 
            this.occupied.AutoSize = true;
            this.occupied.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.occupied.Location = new System.Drawing.Point(166, 79);
            this.occupied.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.occupied.Name = "occupied";
            this.occupied.Size = new System.Drawing.Size(80, 47);
            this.occupied.TabIndex = 76;
            this.occupied.Text = "000";
            // 
            // available
            // 
            this.available.AutoSize = true;
            this.available.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.available.Location = new System.Drawing.Point(443, 79);
            this.available.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(80, 47);
            this.available.TabIndex = 77;
            this.available.Text = "000";
            // 
            // dgvFlatrate
            // 
            this.dgvFlatrate.AllowUserToAddRows = false;
            this.dgvFlatrate.AllowUserToDeleteRows = false;
            this.dgvFlatrate.AllowUserToResizeColumns = false;
            this.dgvFlatrate.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFlatrate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFlatrate.AutoGenerateColumns = false;
            this.dgvFlatrate.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvFlatrate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(217)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatrate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFlatrate.ColumnHeadersHeight = 30;
            this.dgvFlatrate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plateNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn});
            this.dgvFlatrate.DataSource = this.flatraterawBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlatrate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFlatrate.GridColor = System.Drawing.Color.White;
            this.dgvFlatrate.Location = new System.Drawing.Point(12, 138);
            this.dgvFlatrate.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFlatrate.Name = "dgvFlatrate";
            this.dgvFlatrate.ReadOnly = true;
            this.dgvFlatrate.RowHeadersVisible = false;
            this.dgvFlatrate.RowHeadersWidth = 62;
            this.dgvFlatrate.Size = new System.Drawing.Size(991, 337);
            this.dgvFlatrate.TabIndex = 78;
            this.dgvFlatrate.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFlatrate.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFlatrate.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFlatrate.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFlatrate.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFlatrate.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvFlatrate.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvFlatrate.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvFlatrate.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFlatrate.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatrate.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFlatrate.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFlatrate.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvFlatrate.ThemeStyle.ReadOnly = true;
            this.dgvFlatrate.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFlatrate.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFlatrate.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatrate.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFlatrate.ThemeStyle.RowsStyle.Height = 22;
            this.dgvFlatrate.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFlatrate.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFlatrate.DataSourceChanged += new System.EventHandler(this.dgvFlatrate_DataSourceChanged);
            this.dgvFlatrate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlatrate_CellContentClick);
            // 
            // plateNumberDataGridViewTextBoxColumn
            // 
            this.plateNumberDataGridViewTextBoxColumn.DataPropertyName = "plateNumber";
            this.plateNumberDataGridViewTextBoxColumn.HeaderText = "PLATE NUMBER";
            this.plateNumberDataGridViewTextBoxColumn.Name = "plateNumberDataGridViewTextBoxColumn";
            this.plateNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "vehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "VEHICLE TYPE";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            this.timeInDataGridViewTextBoxColumn.DataPropertyName = "timeIn";
            this.timeInDataGridViewTextBoxColumn.HeaderText = "TIME IN";
            this.timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            this.timeInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "timeOut";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "timeOut";
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            this.timeOutDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeOutDataGridViewTextBoxColumn.Visible = false;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            this.rateDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "PARKING PLACE";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flatraterawBindingSource1
            // 
            this.flatraterawBindingSource1.DataMember = "flatrate_raw";
            this.flatraterawBindingSource1.DataSource = this.metro_ParkingDataSet1;
            // 
            // metro_ParkingDataSet1
            // 
            this.metro_ParkingDataSet1.DataSetName = "Metro_ParkingDataSet1";
            this.metro_ParkingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flatraterawBindingSource
            // 
            this.flatraterawBindingSource.DataMember = "flatrate_raw";
            this.flatraterawBindingSource.DataSource = this.metro_Parking;
            // 
            // metro_Parking
            // 
            this.metro_Parking.DataSetName = "Metro_Parking";
            this.metro_Parking.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flatrate_rawTableAdapter
            // 
            this.flatrate_rawTableAdapter.ClearBeforeFill = true;
            // 
            // Refresher
            // 
            this.Refresher.Enabled = true;
            this.Refresher.Interval = 1000;
            this.Refresher.Tick += new System.EventHandler(this.Refresher_Tick);
            // 
            // flatrate_rawTableAdapter1
            // 
            this.flatrate_rawTableAdapter1.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tbIdFlatrate
            // 
            this.tbIdFlatrate.BorderColor = System.Drawing.Color.Gray;
            this.tbIdFlatrate.BorderRadius = 5;
            this.tbIdFlatrate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdFlatrate.DefaultText = "";
            this.tbIdFlatrate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIdFlatrate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIdFlatrate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIdFlatrate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIdFlatrate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIdFlatrate.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tbIdFlatrate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIdFlatrate.Location = new System.Drawing.Point(795, 75);
            this.tbIdFlatrate.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.tbIdFlatrate.Name = "tbIdFlatrate";
            this.tbIdFlatrate.PasswordChar = '\0';
            this.tbIdFlatrate.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbIdFlatrate.PlaceholderText = "TICKET #";
            this.tbIdFlatrate.SelectedText = "";
            this.tbIdFlatrate.Size = new System.Drawing.Size(123, 50);
            this.tbIdFlatrate.TabIndex = 79;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(759, 84);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(34, 33);
            this.guna2HtmlLabel1.TabIndex = 80;
            this.guna2HtmlLabel1.Text = "OR";
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.printDocument2;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            this.printPreviewDialog2.Load += new System.EventHandler(this.printPreviewDialog2_Load);
            // 
            // UC_Flatrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.tbIdFlatrate);
            this.Controls.Add(this.placeholderLabel);
            this.Controls.Add(this.dgvFlatrate);
            this.Controls.Add(this.available);
            this.Controls.Add(this.occupied);
            this.Controls.Add(this.tbNameFlat);
            this.Controls.Add(this.cbVehicleTypeFlat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.tbplateNoFlatrate);
            this.Controls.Add(this.tbPlateFlatrate);
            this.Controls.Add(this.btSearchFlatrate);
            this.Controls.Add(this.btOutFlatrate);
            this.Controls.Add(this.btInFlatrate);
            this.Controls.Add(this.btbClearFlatrate);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UC_Flatrate";
            this.Size = new System.Drawing.Size(1014, 540);
            this.Load += new System.EventHandler(this.UC_Flatrate_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatraterawBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_ParkingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatraterawBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_Parking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tbNameFlat;
        private Guna.UI2.WinForms.Guna2ComboBox cbVehicleTypeFlat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel placeholderLabel;
        private Guna.UI2.WinForms.Guna2Button btUpdate;
        private Guna.UI2.WinForms.Guna2TextBox tbplateNoFlatrate;
        private Guna.UI2.WinForms.Guna2TextBox tbPlateFlatrate;
        private Guna.UI2.WinForms.Guna2Button btSearchFlatrate;
        private Guna.UI2.WinForms.Guna2Button btOutFlatrate;
        private Guna.UI2.WinForms.Guna2Button btInFlatrate;
        private Guna.UI2.WinForms.Guna2Button btbClearFlatrate;
        private System.Windows.Forms.Label occupied;
        private System.Windows.Forms.Label available;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFlatrate;
        private System.Windows.Forms.BindingSource flatraterawBindingSource;
        private Metro_Parking metro_Parking;
        private Metro_ParkingTableAdapters.flatrate_rawTableAdapter flatrate_rawTableAdapter;
        private System.Windows.Forms.Timer Refresher;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.BindingSource flatraterawBindingSource1;
        private Metro_ParkingDataSet1 metro_ParkingDataSet1;
        private Metro_ParkingDataSet1TableAdapters.flatrate_rawTableAdapter flatrate_rawTableAdapter1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2TextBox tbIdFlatrate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
    }
}
