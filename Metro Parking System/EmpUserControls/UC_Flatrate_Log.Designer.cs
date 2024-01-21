namespace Metro_Parking_System.UserControls
{
    partial class UC_Flatrate_Log
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
            this.flatratelogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metro_ParkingDataSet2 = new Metro_Parking_System.Metro_ParkingDataSet2();
            this.flatratelogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metro_Parking = new Metro_Parking_System.Metro_Parking();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.flatrate_logTableAdapter = new Metro_Parking_System.Metro_ParkingTableAdapters.flatrate_logTableAdapter();
            this.Refresher = new System.Windows.Forms.Timer(this.components);
            this.flatrate_logTableAdapter1 = new Metro_Parking_System.Metro_ParkingDataSet2TableAdapters.flatrate_logTableAdapter();
            this.metro_ParkingDataSet6 = new Metro_Parking_System.Metro_ParkingDataSet6();
            this.metroParkingDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metro_ParkingDataSet7 = new Metro_Parking_System.Metro_ParkingDataSet7();
            this.flatratelogBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.flatrate_logTableAdapter2 = new Metro_Parking_System.Metro_ParkingDataSet7TableAdapters.flatrate_logTableAdapter();
            this.dgvFlatrateLog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.plateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_ParkingDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_Parking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_ParkingDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroParkingDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_ParkingDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatrateLog)).BeginInit();
            this.SuspendLayout();
            // 
            // flatratelogBindingSource1
            // 
            this.flatratelogBindingSource1.DataMember = "flatrate_log";
            this.flatratelogBindingSource1.DataSource = this.metro_ParkingDataSet2;
            // 
            // metro_ParkingDataSet2
            // 
            this.metro_ParkingDataSet2.DataSetName = "Metro_ParkingDataSet2";
            this.metro_ParkingDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flatratelogBindingSource
            // 
            this.flatratelogBindingSource.DataMember = "flatrate_log";
            this.flatratelogBindingSource.DataSource = this.metro_Parking;
            // 
            // metro_Parking
            // 
            this.metro_Parking.DataSetName = "Metro_Parking";
            this.metro_Parking.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.currentDateLabel.Location = new System.Drawing.Point(5, 21);
            this.currentDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(437, 45);
            this.currentDateLabel.TabIndex = 44;
            this.currentDateLabel.Text = "Successfully Exited Vehicles ";
            // 
            // flatrate_logTableAdapter
            // 
            this.flatrate_logTableAdapter.ClearBeforeFill = true;
            // 
            // Refresher
            // 
            this.Refresher.Interval = 1000;
            this.Refresher.Tick += new System.EventHandler(this.Refresher_Tick);
            // 
            // flatrate_logTableAdapter1
            // 
            this.flatrate_logTableAdapter1.ClearBeforeFill = true;
            // 
            // metro_ParkingDataSet6
            // 
            this.metro_ParkingDataSet6.DataSetName = "Metro_ParkingDataSet6";
            this.metro_ParkingDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroParkingDataSet6BindingSource
            // 
            this.metroParkingDataSet6BindingSource.DataSource = this.metro_ParkingDataSet6;
            this.metroParkingDataSet6BindingSource.Position = 0;
            // 
            // metro_ParkingDataSet7
            // 
            this.metro_ParkingDataSet7.DataSetName = "Metro_ParkingDataSet7";
            this.metro_ParkingDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flatratelogBindingSource2
            // 
            this.flatratelogBindingSource2.DataMember = "flatrate_log";
            this.flatratelogBindingSource2.DataSource = this.metro_ParkingDataSet7;
            // 
            // flatrate_logTableAdapter2
            // 
            this.flatrate_logTableAdapter2.ClearBeforeFill = true;
            // 
            // dgvFlatrateLog
            // 
            this.dgvFlatrateLog.AllowUserToAddRows = false;
            this.dgvFlatrateLog.AllowUserToDeleteRows = false;
            this.dgvFlatrateLog.AllowUserToResizeColumns = false;
            this.dgvFlatrateLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFlatrateLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFlatrateLog.AutoGenerateColumns = false;
            this.dgvFlatrateLog.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvFlatrateLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(217)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatrateLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFlatrateLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plateNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn});
            this.dgvFlatrateLog.DataSource = this.flatratelogBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlatrateLog.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFlatrateLog.GridColor = System.Drawing.Color.White;
            this.dgvFlatrateLog.Location = new System.Drawing.Point(12, 82);
            this.dgvFlatrateLog.Name = "dgvFlatrateLog";
            this.dgvFlatrateLog.ReadOnly = true;
            this.dgvFlatrateLog.RowHeadersVisible = false;
            this.dgvFlatrateLog.Size = new System.Drawing.Size(991, 444);
            this.dgvFlatrateLog.TabIndex = 45;
            this.dgvFlatrateLog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFlatrateLog.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFlatrateLog.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFlatrateLog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFlatrateLog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFlatrateLog.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvFlatrateLog.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvFlatrateLog.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvFlatrateLog.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFlatrateLog.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatrateLog.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFlatrateLog.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFlatrateLog.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvFlatrateLog.ThemeStyle.ReadOnly = true;
            this.dgvFlatrateLog.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFlatrateLog.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFlatrateLog.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatrateLog.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFlatrateLog.ThemeStyle.RowsStyle.Height = 22;
            this.dgvFlatrateLog.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFlatrateLog.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFlatrateLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlatrateLog_CellContentClick);
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
            this.nameDataGridViewTextBoxColumn.HeaderText = "DRIVER\'S NAME";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "TIME OUT";
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            this.timeOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "RATE";
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
            // UC_Flatrate_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dgvFlatrateLog);
            this.Controls.Add(this.currentDateLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Flatrate_Log";
            this.Size = new System.Drawing.Size(1014, 540);
            this.Load += new System.EventHandler(this.UC_Flatrate_Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_ParkingDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_Parking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_ParkingDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroParkingDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_ParkingDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatrateLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.BindingSource flatratelogBindingSource;
        private Metro_Parking metro_Parking;
        private Metro_ParkingTableAdapters.flatrate_logTableAdapter flatrate_logTableAdapter;
        private System.Windows.Forms.Timer Refresher;
        private System.Windows.Forms.BindingSource flatratelogBindingSource1;
        private Metro_ParkingDataSet2 metro_ParkingDataSet2;
        private Metro_ParkingDataSet2TableAdapters.flatrate_logTableAdapter flatrate_logTableAdapter1;
        private System.Windows.Forms.BindingSource flatratelogBindingSource2;
        private Metro_ParkingDataSet7 metro_ParkingDataSet7;
        private Metro_ParkingDataSet6 metro_ParkingDataSet6;
        private System.Windows.Forms.BindingSource metroParkingDataSet6BindingSource;
        private Metro_ParkingDataSet7TableAdapters.flatrate_logTableAdapter flatrate_logTableAdapter2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFlatrateLog;
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
