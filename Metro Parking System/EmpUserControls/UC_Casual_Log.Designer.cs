namespace Metro_Parking_System.UserControls
{
    partial class UC_Casual_Log
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
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.dgvCasualLog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.plateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casuallogBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.casual_log = new Metro_Parking_System.casual_log();
            this.casuallogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metro_ParkingDataSet4 = new Metro_Parking_System.Metro_ParkingDataSet4();
            this.casuallogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metro_Parking = new Metro_Parking_System.Metro_Parking();
            this.casual_logTableAdapter = new Metro_Parking_System.Metro_ParkingTableAdapters.casual_logTableAdapter();
            this.Refresher = new System.Windows.Forms.Timer(this.components);
            this.casual_logTableAdapter1 = new Metro_Parking_System.Metro_ParkingDataSet4TableAdapters.casual_logTableAdapter();
            this.casual_logTableAdapter2 = new Metro_Parking_System.casual_logTableAdapters.casual_logTableAdapter();
            this.logs = new Metro_Parking_System.logs();
            this.flatratelogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flatrate_logTableAdapter = new Metro_Parking_System.logsTableAdapters.flatrate_logTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasualLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casuallogBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casual_log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casuallogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_ParkingDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casuallogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_Parking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.currentDateLabel.Location = new System.Drawing.Point(5, 21);
            this.currentDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(428, 45);
            this.currentDateLabel.TabIndex = 41;
            this.currentDateLabel.Text = "Successfully Exited Vehicles";
            // 
            // dgvCasualLog
            // 
            this.dgvCasualLog.AllowUserToAddRows = false;
            this.dgvCasualLog.AllowUserToDeleteRows = false;
            this.dgvCasualLog.AllowUserToResizeColumns = false;
            this.dgvCasualLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCasualLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCasualLog.AutoGenerateColumns = false;
            this.dgvCasualLog.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCasualLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(217)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCasualLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCasualLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plateNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn});
            this.dgvCasualLog.DataSource = this.casuallogBindingSource2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCasualLog.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCasualLog.GridColor = System.Drawing.Color.White;
            this.dgvCasualLog.Location = new System.Drawing.Point(12, 82);
            this.dgvCasualLog.Name = "dgvCasualLog";
            this.dgvCasualLog.ReadOnly = true;
            this.dgvCasualLog.RowHeadersVisible = false;
            this.dgvCasualLog.Size = new System.Drawing.Size(991, 444);
            this.dgvCasualLog.TabIndex = 43;
            this.dgvCasualLog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCasualLog.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCasualLog.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCasualLog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCasualLog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCasualLog.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvCasualLog.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvCasualLog.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvCasualLog.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCasualLog.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCasualLog.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCasualLog.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCasualLog.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvCasualLog.ThemeStyle.ReadOnly = true;
            this.dgvCasualLog.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCasualLog.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCasualLog.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCasualLog.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCasualLog.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCasualLog.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCasualLog.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCasualLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCasualLog_CellContentClick);
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
            // casuallogBindingSource2
            // 
            this.casuallogBindingSource2.DataMember = "casual_log";
            this.casuallogBindingSource2.DataSource = this.casual_log;
            // 
            // casual_log
            // 
            this.casual_log.DataSetName = "casual_log";
            this.casual_log.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // casuallogBindingSource1
            // 
            this.casuallogBindingSource1.DataMember = "casual_log";
            this.casuallogBindingSource1.DataSource = this.metro_ParkingDataSet4;
            // 
            // metro_ParkingDataSet4
            // 
            this.metro_ParkingDataSet4.DataSetName = "Metro_ParkingDataSet4";
            this.metro_ParkingDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // casuallogBindingSource
            // 
            this.casuallogBindingSource.DataMember = "casual_log";
            this.casuallogBindingSource.DataSource = this.metro_Parking;
            // 
            // metro_Parking
            // 
            this.metro_Parking.DataSetName = "Metro_Parking";
            this.metro_Parking.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // casual_logTableAdapter
            // 
            this.casual_logTableAdapter.ClearBeforeFill = true;
            // 
            // Refresher
            // 
            this.Refresher.Interval = 1000;
            this.Refresher.Tick += new System.EventHandler(this.Refresher_Tick);
            // 
            // casual_logTableAdapter1
            // 
            this.casual_logTableAdapter1.ClearBeforeFill = true;
            // 
            // casual_logTableAdapter2
            // 
            this.casual_logTableAdapter2.ClearBeforeFill = true;
            // 
            // logs
            // 
            this.logs.DataSetName = "logs";
            this.logs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flatratelogBindingSource
            // 
            this.flatratelogBindingSource.DataMember = "flatrate_log";
            this.flatratelogBindingSource.DataSource = this.logs;
            // 
            // flatrate_logTableAdapter
            // 
            this.flatrate_logTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Casual_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dgvCasualLog);
            this.Controls.Add(this.currentDateLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Casual_Log";
            this.Size = new System.Drawing.Size(1014, 540);
            this.Load += new System.EventHandler(this.UC_Casual_Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasualLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casuallogBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casual_log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casuallogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_ParkingDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casuallogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metro_Parking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentDateLabel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCasualLog;
        private System.Windows.Forms.BindingSource casuallogBindingSource;
        private Metro_Parking metro_Parking;
        private Metro_ParkingTableAdapters.casual_logTableAdapter casual_logTableAdapter;
        private System.Windows.Forms.Timer Refresher;
        private System.Windows.Forms.BindingSource casuallogBindingSource1;
        private Metro_ParkingDataSet4 metro_ParkingDataSet4;
        private Metro_ParkingDataSet4TableAdapters.casual_logTableAdapter casual_logTableAdapter1;
        private System.Windows.Forms.BindingSource casuallogBindingSource2;
        private casual_log casual_log;
        private casual_logTableAdapters.casual_logTableAdapter casual_logTableAdapter2;
        private logs logs;
        private System.Windows.Forms.BindingSource flatratelogBindingSource;
        private logsTableAdapters.flatrate_logTableAdapter flatrate_logTableAdapter;
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
