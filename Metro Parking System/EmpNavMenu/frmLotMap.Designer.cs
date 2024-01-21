namespace Metro_Parking_System
{
    partial class frmLotMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLotMap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btCloseLotMap = new Guna.UI2.WinForms.Guna2Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.realTime = new System.Windows.Forms.Timer(this.components);
            this.refresher = new System.Windows.Forms.Timer(this.components);
            this.btPlaceSummary = new Guna.UI2.WinForms.Guna2Button();
            this.btMap = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btCloseLotMap);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 31);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "PARKING LOT MAP";
            // 
            // btCloseLotMap
            // 
            this.btCloseLotMap.BorderRadius = 5;
            this.btCloseLotMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCloseLotMap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCloseLotMap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCloseLotMap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCloseLotMap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCloseLotMap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btCloseLotMap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCloseLotMap.ForeColor = System.Drawing.Color.White;
            this.btCloseLotMap.Location = new System.Drawing.Point(951, 3);
            this.btCloseLotMap.Name = "btCloseLotMap";
            this.btCloseLotMap.Size = new System.Drawing.Size(62, 25);
            this.btCloseLotMap.TabIndex = 0;
            this.btCloseLotMap.Text = "CLOSE";
            this.btCloseLotMap.Click += new System.EventHandler(this.btCloseLotMap_Click);
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
            // refresher
            // 
            this.refresher.Enabled = true;
            this.refresher.Interval = 1000;
            this.refresher.Tick += new System.EventHandler(this.refresher_Tick);
            // 
            // btPlaceSummary
            // 
            this.btPlaceSummary.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btPlaceSummary.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btPlaceSummary.CheckedState.FillColor = System.Drawing.Color.White;
            this.btPlaceSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPlaceSummary.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btPlaceSummary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPlaceSummary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btPlaceSummary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btPlaceSummary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPlaceSummary.Dock = System.Windows.Forms.DockStyle.Right;
            this.btPlaceSummary.FillColor = System.Drawing.Color.White;
            this.btPlaceSummary.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlaceSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btPlaceSummary.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btPlaceSummary.Location = new System.Drawing.Point(510, 0);
            this.btPlaceSummary.Name = "btPlaceSummary";
            this.btPlaceSummary.Size = new System.Drawing.Size(506, 45);
            this.btPlaceSummary.TabIndex = 134;
            this.btPlaceSummary.Text = "PLACE SUMMARY";
            this.btPlaceSummary.Click += new System.EventHandler(this.btPlaceSummary_Click);
            // 
            // btMap
            // 
            this.btMap.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btMap.Checked = true;
            this.btMap.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btMap.CheckedState.FillColor = System.Drawing.Color.White;
            this.btMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMap.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btMap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMap.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMap.FillColor = System.Drawing.Color.White;
            this.btMap.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btMap.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btMap.Location = new System.Drawing.Point(0, 0);
            this.btMap.Name = "btMap";
            this.btMap.Size = new System.Drawing.Size(506, 45);
            this.btMap.TabIndex = 1;
            this.btMap.Text = "LOT MAP";
            this.btMap.Click += new System.EventHandler(this.btMap_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btPlaceSummary);
            this.panel2.Controls.Add(this.btMap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 45);
            this.panel2.TabIndex = 135;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 76);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1016, 542);
            this.panelContainer.TabIndex = 136;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // frmLotMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 618);
            this.ControlBox = false;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLotMap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLotMap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btCloseLotMap;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer realTime;
        private System.Windows.Forms.Timer refresher;
        private Guna.UI2.WinForms.Guna2Button btPlaceSummary;
        private Guna.UI2.WinForms.Guna2Button btMap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainer;
    }
}