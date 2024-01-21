namespace Metro_Parking_System.UserControls
{
    partial class UC_Casual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Casual));
            this.placeholderLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvCasual = new Guna.UI2.WinForms.Guna2DataGridView();
            this.plateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casualrawBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metro_ParkingDataSet3 = new Metro_Parking_System.Metro_ParkingDataSet3();
            this.casualrawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metro_Parking = new Metro_Parking_System.Metro_Parking();
            this.availableCasual = new System.Windows.Forms.Label();
            this.occupiedCasual = new System.Windows.Forms.Label();
            this.tbNameCas = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbVehicleTypeCas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.tbplateNoCasual = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPlateCasual = new Guna.UI2.WinForms.Guna2TextBox();
            this.btSearchCasual = new Guna.UI2.WinForms.Guna2Button();
            this.btOutCasual = new Guna.UI2.WinForms.Guna2Button();
            this.btbClearCasual = new Guna.UI2.WinForms.Guna2Button();
            this.btInCasual = new Guna.UI2.WinForms.Guna2Button();
            this.casual_rawTableAdapter = new Metro_Parking_System.Metro_ParkingTableAdapters.casual_rawTableAdapter();
            this.Refresher = new System.Windows.Forms.Timer(this.components);
            this.casual_rawTableAdapter1 = new Metro_Parking_System.Metro_ParkingDataSet3TableAdapters.casual_rawTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbIdCasual = new Guna.UI2.WinForms.Guna2TextBox();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casualrawBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_ParkingDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casualrawBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_Parking)).BeginInit();
            this.SuspendLayout();
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
            this.placeholderLabel.TabIndex = 91;
            this.placeholderLabel.Text = "SELECT VEHICLE TYPE";
            // 
            // dgvCasual
            // 
            this.dgvCasual.AllowUserToAddRows = false;
            this.dgvCasual.AllowUserToDeleteRows = false;
            this.dgvCasual.AllowUserToResizeColumns = false;
            this.dgvCasual.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCasual.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCasual.AutoGenerateColumns = false;
            this.dgvCasual.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCasual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(217)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCasual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCasual.ColumnHeadersHeight = 30;
            this.dgvCasual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCasual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plateNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn});
            this.dgvCasual.DataSource = this.casualrawBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCasual.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCasual.GridColor = System.Drawing.Color.White;
            this.dgvCasual.Location = new System.Drawing.Point(12, 138);
            this.dgvCasual.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCasual.Name = "dgvCasual";
            this.dgvCasual.ReadOnly = true;
            this.dgvCasual.RowHeadersVisible = false;
            this.dgvCasual.Size = new System.Drawing.Size(991, 337);
            this.dgvCasual.TabIndex = 94;
            this.dgvCasual.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCasual.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCasual.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCasual.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCasual.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCasual.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvCasual.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvCasual.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvCasual.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCasual.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCasual.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCasual.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCasual.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvCasual.ThemeStyle.ReadOnly = true;
            this.dgvCasual.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCasual.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCasual.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCasual.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCasual.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCasual.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCasual.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCasual.DataSourceChanged += new System.EventHandler(this.dgvCasual_DataSourceChanged);
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
            // casualrawBindingSource1
            // 
            this.casualrawBindingSource1.DataMember = "casual_raw";
            this.casualrawBindingSource1.DataSource = this.metro_ParkingDataSet3;
            // 
            // metro_ParkingDataSet3
            // 
            this.metro_ParkingDataSet3.DataSetName = "Metro_ParkingDataSet3";
            this.metro_ParkingDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // casualrawBindingSource
            // 
            this.casualrawBindingSource.DataMember = "casual_raw";
            this.casualrawBindingSource.DataSource = this.metro_Parking;
            // 
            // metro_Parking
            // 
            this.metro_Parking.DataSetName = "Metro_Parking";
            this.metro_Parking.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // availableCasual
            // 
            this.availableCasual.AutoSize = true;
            this.availableCasual.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableCasual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.availableCasual.Location = new System.Drawing.Point(443, 79);
            this.availableCasual.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.availableCasual.Name = "availableCasual";
            this.availableCasual.Size = new System.Drawing.Size(80, 47);
            this.availableCasual.TabIndex = 93;
            this.availableCasual.Text = "000";
            // 
            // occupiedCasual
            // 
            this.occupiedCasual.AutoSize = true;
            this.occupiedCasual.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupiedCasual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.occupiedCasual.Location = new System.Drawing.Point(166, 79);
            this.occupiedCasual.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.occupiedCasual.Name = "occupiedCasual";
            this.occupiedCasual.Size = new System.Drawing.Size(80, 47);
            this.occupiedCasual.TabIndex = 92;
            this.occupiedCasual.Text = "000";
            // 
            // tbNameCas
            // 
            this.tbNameCas.BorderColor = System.Drawing.Color.Gray;
            this.tbNameCas.BorderRadius = 5;
            this.tbNameCas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameCas.DefaultText = "";
            this.tbNameCas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNameCas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNameCas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNameCas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNameCas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameCas.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tbNameCas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNameCas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameCas.Location = new System.Drawing.Point(567, 13);
            this.tbNameCas.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbNameCas.Name = "tbNameCas";
            this.tbNameCas.PasswordChar = '\0';
            this.tbNameCas.PlaceholderText = "DRIVER\'S NAME";
            this.tbNameCas.SelectedText = "";
            this.tbNameCas.Size = new System.Drawing.Size(228, 50);
            this.tbNameCas.TabIndex = 88;
            // 
            // cbVehicleTypeCas
            // 
            this.cbVehicleTypeCas.BackColor = System.Drawing.Color.Transparent;
            this.cbVehicleTypeCas.BorderColor = System.Drawing.Color.Gray;
            this.cbVehicleTypeCas.BorderRadius = 5;
            this.cbVehicleTypeCas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVehicleTypeCas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehicleTypeCas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVehicleTypeCas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVehicleTypeCas.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.cbVehicleTypeCas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbVehicleTypeCas.ItemHeight = 44;
            this.cbVehicleTypeCas.Items.AddRange(new object[] {
            "CAR",
            "TRICYCLE"});
            this.cbVehicleTypeCas.Location = new System.Drawing.Point(289, 13);
            this.cbVehicleTypeCas.Margin = new System.Windows.Forms.Padding(4);
            this.cbVehicleTypeCas.Name = "cbVehicleTypeCas";
            this.cbVehicleTypeCas.Size = new System.Drawing.Size(267, 50);
            this.cbVehicleTypeCas.TabIndex = 87;
            this.cbVehicleTypeCas.SelectedIndexChanged += new System.EventHandler(this.cbVehicleTypeCas_SelectedIndexChanged);
            this.cbVehicleTypeCas.Enter += new System.EventHandler(this.cbVehicleTypeCas_Enter);
            this.cbVehicleTypeCas.Leave += new System.EventHandler(this.cbVehicleTypeCas_Leave);
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
            this.label2.TabIndex = 90;
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
            this.label1.TabIndex = 89;
            this.label1.Text = "Occupied: ";
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
            this.btUpdate.TabIndex = 84;
            this.btUpdate.Text = "UPDATE";
            this.btUpdate.Visible = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // tbplateNoCasual
            // 
            this.tbplateNoCasual.BorderColor = System.Drawing.Color.Gray;
            this.tbplateNoCasual.BorderRadius = 5;
            this.tbplateNoCasual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbplateNoCasual.DefaultText = "";
            this.tbplateNoCasual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbplateNoCasual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbplateNoCasual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbplateNoCasual.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbplateNoCasual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbplateNoCasual.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tbplateNoCasual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbplateNoCasual.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbplateNoCasual.Location = new System.Drawing.Point(12, 13);
            this.tbplateNoCasual.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbplateNoCasual.Name = "tbplateNoCasual";
            this.tbplateNoCasual.PasswordChar = '\0';
            this.tbplateNoCasual.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbplateNoCasual.PlaceholderText = "ENTER PLATE NUMBER";
            this.tbplateNoCasual.SelectedText = "";
            this.tbplateNoCasual.Size = new System.Drawing.Size(267, 50);
            this.tbplateNoCasual.TabIndex = 83;
            // 
            // tbPlateCasual
            // 
            this.tbPlateCasual.BorderColor = System.Drawing.Color.Gray;
            this.tbPlateCasual.BorderRadius = 5;
            this.tbPlateCasual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPlateCasual.DefaultText = "";
            this.tbPlateCasual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPlateCasual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPlateCasual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPlateCasual.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPlateCasual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPlateCasual.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tbPlateCasual.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPlateCasual.Location = new System.Drawing.Point(567, 75);
            this.tbPlateCasual.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.tbPlateCasual.Name = "tbPlateCasual";
            this.tbPlateCasual.PasswordChar = '\0';
            this.tbPlateCasual.PlaceholderText = "SEARCH PLATE";
            this.tbPlateCasual.SelectedText = "";
            this.tbPlateCasual.Size = new System.Drawing.Size(190, 50);
            this.tbPlateCasual.TabIndex = 82;
            // 
            // btSearchCasual
            // 
            this.btSearchCasual.BorderRadius = 5;
            this.btSearchCasual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearchCasual.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSearchCasual.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSearchCasual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSearchCasual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSearchCasual.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSearchCasual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchCasual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btSearchCasual.Location = new System.Drawing.Point(929, 75);
            this.btSearchCasual.Margin = new System.Windows.Forms.Padding(4);
            this.btSearchCasual.Name = "btSearchCasual";
            this.btSearchCasual.Size = new System.Drawing.Size(77, 50);
            this.btSearchCasual.TabIndex = 81;
            this.btSearchCasual.Text = "FIND";
            this.btSearchCasual.Click += new System.EventHandler(this.btSearchCasual_Click_1);
            // 
            // btOutCasual
            // 
            this.btOutCasual.BorderRadius = 5;
            this.btOutCasual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOutCasual.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btOutCasual.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btOutCasual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btOutCasual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btOutCasual.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btOutCasual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOutCasual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btOutCasual.Location = new System.Drawing.Point(871, 483);
            this.btOutCasual.Margin = new System.Windows.Forms.Padding(4);
            this.btOutCasual.Name = "btOutCasual";
            this.btOutCasual.Size = new System.Drawing.Size(132, 50);
            this.btOutCasual.TabIndex = 80;
            this.btOutCasual.Text = "VEHICLE OUT";
            this.btOutCasual.Click += new System.EventHandler(this.btOutCasual_Click);
            // 
            // btbClearCasual
            // 
            this.btbClearCasual.BorderRadius = 5;
            this.btbClearCasual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbClearCasual.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btbClearCasual.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btbClearCasual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btbClearCasual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btbClearCasual.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btbClearCasual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbClearCasual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btbClearCasual.ImageSize = new System.Drawing.Size(25, 25);
            this.btbClearCasual.Location = new System.Drawing.Point(804, 13);
            this.btbClearCasual.Margin = new System.Windows.Forms.Padding(4);
            this.btbClearCasual.Name = "btbClearCasual";
            this.btbClearCasual.Size = new System.Drawing.Size(78, 50);
            this.btbClearCasual.TabIndex = 86;
            this.btbClearCasual.Text = "CLEAR";
            this.btbClearCasual.Click += new System.EventHandler(this.btbClearCasual_Click);
            // 
            // btInCasual
            // 
            this.btInCasual.BorderRadius = 5;
            this.btInCasual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInCasual.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btInCasual.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btInCasual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btInCasual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btInCasual.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btInCasual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInCasual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btInCasual.Location = new System.Drawing.Point(890, 13);
            this.btInCasual.Margin = new System.Windows.Forms.Padding(4);
            this.btInCasual.Name = "btInCasual";
            this.btInCasual.Size = new System.Drawing.Size(116, 50);
            this.btInCasual.TabIndex = 79;
            this.btInCasual.Text = "VEHICLE IN";
            this.btInCasual.Click += new System.EventHandler(this.btInCasual_Click);
            // 
            // casual_rawTableAdapter
            // 
            this.casual_rawTableAdapter.ClearBeforeFill = true;
            // 
            // Refresher
            // 
            this.Refresher.Enabled = true;
            this.Refresher.Interval = 1000;
            this.Refresher.Tick += new System.EventHandler(this.Refresher_Tick);
            // 
            // casual_rawTableAdapter1
            // 
            this.casual_rawTableAdapter1.ClearBeforeFill = true;
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
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(759, 84);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(34, 33);
            this.guna2HtmlLabel1.TabIndex = 96;
            this.guna2HtmlLabel1.Text = "OR";
            // 
            // tbIdCasual
            // 
            this.tbIdCasual.BorderRadius = 5;
            this.tbIdCasual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdCasual.DefaultText = "";
            this.tbIdCasual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIdCasual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIdCasual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIdCasual.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIdCasual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIdCasual.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tbIdCasual.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIdCasual.Location = new System.Drawing.Point(795, 75);
            this.tbIdCasual.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.tbIdCasual.Name = "tbIdCasual";
            this.tbIdCasual.PasswordChar = '\0';
            this.tbIdCasual.PlaceholderText = "TICKET #";
            this.tbIdCasual.SelectedText = "";
            this.tbIdCasual.Size = new System.Drawing.Size(123, 50);
            this.tbIdCasual.TabIndex = 95;
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
            // UC_Casual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.tbIdCasual);
            this.Controls.Add(this.placeholderLabel);
            this.Controls.Add(this.dgvCasual);
            this.Controls.Add(this.availableCasual);
            this.Controls.Add(this.occupiedCasual);
            this.Controls.Add(this.tbNameCas);
            this.Controls.Add(this.cbVehicleTypeCas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.tbplateNoCasual);
            this.Controls.Add(this.tbPlateCasual);
            this.Controls.Add(this.btSearchCasual);
            this.Controls.Add(this.btOutCasual);
            this.Controls.Add(this.btbClearCasual);
            this.Controls.Add(this.btInCasual);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UC_Casual";
            this.Size = new System.Drawing.Size(1014, 540);
            this.Load += new System.EventHandler(this.UC_Casual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casualrawBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_ParkingDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casualrawBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_Parking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel placeholderLabel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCasual;
        private System.Windows.Forms.Label availableCasual;
        private System.Windows.Forms.Label occupiedCasual;
        private Guna.UI2.WinForms.Guna2TextBox tbNameCas;
        private Guna.UI2.WinForms.Guna2ComboBox cbVehicleTypeCas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btUpdate;
        private Guna.UI2.WinForms.Guna2TextBox tbplateNoCasual;
        private Guna.UI2.WinForms.Guna2TextBox tbPlateCasual;
        private Guna.UI2.WinForms.Guna2Button btSearchCasual;
        private Guna.UI2.WinForms.Guna2Button btOutCasual;
        private Guna.UI2.WinForms.Guna2Button btbClearCasual;
        private Guna.UI2.WinForms.Guna2Button btInCasual;
        private System.Windows.Forms.BindingSource casualrawBindingSource;
        private Metro_Parking metro_Parking;
        private Metro_ParkingTableAdapters.casual_rawTableAdapter casual_rawTableAdapter;
        private System.Windows.Forms.Timer Refresher;
        private System.Windows.Forms.BindingSource casualrawBindingSource1;
        private Metro_ParkingDataSet3 metro_ParkingDataSet3;
        private Metro_ParkingDataSet3TableAdapters.casual_rawTableAdapter casual_rawTableAdapter1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tbIdCasual;
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
