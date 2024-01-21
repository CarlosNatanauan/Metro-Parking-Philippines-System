namespace Metro_Parking_System.AdmNavMenu
{
    partial class frmGenerateRev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerateRev));
            this.realTime = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.btCloseGenRev = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btReportGeneration = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btDetailedInfo = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // realTime
            // 
            this.realTime.Tick += new System.EventHandler(this.realTime_Tick);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(453, 3);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(110, 25);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "HH:MM:SS";
            // 
            // btCloseGenRev
            // 
            this.btCloseGenRev.BorderRadius = 5;
            this.btCloseGenRev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCloseGenRev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCloseGenRev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCloseGenRev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCloseGenRev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCloseGenRev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btCloseGenRev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCloseGenRev.ForeColor = System.Drawing.Color.White;
            this.btCloseGenRev.Location = new System.Drawing.Point(951, 3);
            this.btCloseGenRev.Name = "btCloseGenRev";
            this.btCloseGenRev.Size = new System.Drawing.Size(62, 25);
            this.btCloseGenRev.TabIndex = 0;
            this.btCloseGenRev.Text = "CLOSE";
            this.btCloseGenRev.Click += new System.EventHandler(this.btCloseGenRev_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "REPORTS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btCloseGenRev);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 31);
            this.panel1.TabIndex = 7;
            // 
            // btReportGeneration
            // 
            this.btReportGeneration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btReportGeneration.Checked = true;
            this.btReportGeneration.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btReportGeneration.CheckedState.FillColor = System.Drawing.Color.White;
            this.btReportGeneration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReportGeneration.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btReportGeneration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btReportGeneration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btReportGeneration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btReportGeneration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btReportGeneration.Dock = System.Windows.Forms.DockStyle.Left;
            this.btReportGeneration.FillColor = System.Drawing.Color.White;
            this.btReportGeneration.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportGeneration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btReportGeneration.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btReportGeneration.Location = new System.Drawing.Point(0, 0);
            this.btReportGeneration.Name = "btReportGeneration";
            this.btReportGeneration.Size = new System.Drawing.Size(506, 45);
            this.btReportGeneration.TabIndex = 1;
            this.btReportGeneration.Text = "REVENUE REPORT";
            this.btReportGeneration.Click += new System.EventHandler(this.btReportGeneration_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 76);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1016, 542);
            this.panelContainer.TabIndex = 9;
            // 
            // btDetailedInfo
            // 
            this.btDetailedInfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btDetailedInfo.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDetailedInfo.CheckedState.FillColor = System.Drawing.Color.White;
            this.btDetailedInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDetailedInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btDetailedInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDetailedInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDetailedInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDetailedInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDetailedInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btDetailedInfo.FillColor = System.Drawing.Color.White;
            this.btDetailedInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDetailedInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btDetailedInfo.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDetailedInfo.Location = new System.Drawing.Point(510, 0);
            this.btDetailedInfo.Name = "btDetailedInfo";
            this.btDetailedInfo.Size = new System.Drawing.Size(506, 45);
            this.btDetailedInfo.TabIndex = 3;
            this.btDetailedInfo.Text = "DETAILED REPORT";
            this.btDetailedInfo.Click += new System.EventHandler(this.btDetailedInfo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btDetailedInfo);
            this.panel2.Controls.Add(this.btReportGeneration);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 45);
            this.panel2.TabIndex = 8;
            // 
            // frmGenerateRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1016, 618);
            this.ControlBox = false;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmGenerateRev";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGenerateRev_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer realTime;
        private System.Windows.Forms.Label lbTime;
        private Guna.UI2.WinForms.Guna2Button btCloseGenRev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btReportGeneration;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btDetailedInfo;
    }
}