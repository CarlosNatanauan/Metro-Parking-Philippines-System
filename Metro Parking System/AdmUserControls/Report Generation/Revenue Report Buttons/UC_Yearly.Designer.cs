namespace Metro_Parking_System.AdmUserControls.Report_Generation.Report_Buttons
{
    partial class UC_Yearly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Yearly));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpYearly = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.tbTotalVehicle = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbTotalRevenue = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbStatusDaily = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btViewReport = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.dtpYearly);
            this.guna2Panel1.Controls.Add(this.currentDateLabel);
            this.guna2Panel1.Controls.Add(this.tbTotalVehicle);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel1.Controls.Add(this.tbTotalRevenue);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.lbStatusDaily);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.btViewReport);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(716, 352);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // dtpYearly
            // 
            this.dtpYearly.Checked = true;
            this.dtpYearly.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.dtpYearly.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYearly.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpYearly.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYearly.Location = new System.Drawing.Point(221, 67);
            this.dtpYearly.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpYearly.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpYearly.Name = "dtpYearly";
            this.dtpYearly.Size = new System.Drawing.Size(109, 36);
            this.dtpYearly.TabIndex = 69;
            this.dtpYearly.Value = new System.DateTime(2023, 10, 28, 22, 58, 12, 901);
            this.dtpYearly.ValueChanged += new System.EventHandler(this.dpYearly_ValueChanged);
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.currentDateLabel.Location = new System.Drawing.Point(227, 9);
            this.currentDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(263, 45);
            this.currentDateLabel.TabIndex = 64;
            this.currentDateLabel.Text = "YEARLY REPORT";
            // 
            // tbTotalVehicle
            // 
            this.tbTotalVehicle.BorderRadius = 5;
            this.tbTotalVehicle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotalVehicle.DefaultText = "";
            this.tbTotalVehicle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTotalVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTotalVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTotalVehicle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTotalVehicle.Enabled = false;
            this.tbTotalVehicle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotalVehicle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tbTotalVehicle.HideSelection = false;
            this.tbTotalVehicle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotalVehicle.Location = new System.Drawing.Point(322, 165);
            this.tbTotalVehicle.Margin = new System.Windows.Forms.Padding(9);
            this.tbTotalVehicle.Name = "tbTotalVehicle";
            this.tbTotalVehicle.PasswordChar = '\0';
            this.tbTotalVehicle.PlaceholderText = "";
            this.tbTotalVehicle.ReadOnly = true;
            this.tbTotalVehicle.SelectedText = "";
            this.tbTotalVehicle.Size = new System.Drawing.Size(205, 53);
            this.tbTotalVehicle.TabIndex = 33;
            this.tbTotalVehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(33, 166);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(287, 52);
            this.guna2HtmlLabel5.TabIndex = 32;
            this.guna2HtmlLabel5.Text = "TOTAL VEHICLE:";
            // 
            // tbTotalRevenue
            // 
            this.tbTotalRevenue.BorderRadius = 5;
            this.tbTotalRevenue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotalRevenue.DefaultText = "";
            this.tbTotalRevenue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTotalRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTotalRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTotalRevenue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTotalRevenue.Enabled = false;
            this.tbTotalRevenue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tbTotalRevenue.HideSelection = false;
            this.tbTotalRevenue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotalRevenue.Location = new System.Drawing.Point(322, 223);
            this.tbTotalRevenue.Margin = new System.Windows.Forms.Padding(9);
            this.tbTotalRevenue.Name = "tbTotalRevenue";
            this.tbTotalRevenue.PasswordChar = '\0';
            this.tbTotalRevenue.PlaceholderText = "";
            this.tbTotalRevenue.ReadOnly = true;
            this.tbTotalRevenue.SelectedText = "";
            this.tbTotalRevenue.Size = new System.Drawing.Size(205, 53);
            this.tbTotalRevenue.TabIndex = 31;
            this.tbTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(15, 224);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(305, 52);
            this.guna2HtmlLabel4.TabIndex = 30;
            this.guna2HtmlLabel4.Text = "TOTAL REVENUE:";
            // 
            // lbStatusDaily
            // 
            this.lbStatusDaily.BackColor = System.Drawing.Color.Transparent;
            this.lbStatusDaily.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusDaily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.lbStatusDaily.Location = new System.Drawing.Point(221, 107);
            this.lbStatusDaily.Name = "lbStatusDaily";
            this.lbStatusDaily.Size = new System.Drawing.Size(130, 34);
            this.lbStatusDaily.TabIndex = 29;
            this.lbStatusDaily.Text = "AVAILABLE";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(18, 107);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(197, 34);
            this.guna2HtmlLabel1.TabIndex = 28;
            this.guna2HtmlLabel1.Text = "REPORT STATUS:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(57, 67);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(158, 34);
            this.guna2HtmlLabel2.TabIndex = 27;
            this.guna2HtmlLabel2.Text = "SELECT YEAR:";
            // 
            // btViewReport
            // 
            this.btViewReport.BorderRadius = 5;
            this.btViewReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btViewReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btViewReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btViewReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btViewReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btViewReport.Enabled = false;
            this.btViewReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btViewReport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btViewReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btViewReport.Location = new System.Drawing.Point(483, 295);
            this.btViewReport.Margin = new System.Windows.Forms.Padding(4);
            this.btViewReport.Name = "btViewReport";
            this.btViewReport.Size = new System.Drawing.Size(224, 50);
            this.btViewReport.TabIndex = 70;
            this.btViewReport.Text = "GENERATE REPORT";
            this.btViewReport.Click += new System.EventHandler(this.btViewReport_Click);
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
            // UC_Yearly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UC_Yearly";
            this.Size = new System.Drawing.Size(723, 358);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbTotalVehicle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox tbTotalRevenue;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbStatusDaily;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.Label currentDateLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpYearly;
        private Guna.UI2.WinForms.Guna2Button btViewReport;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
