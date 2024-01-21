namespace Metro_Parking_System.AdmNavMenu
{
    partial class frmManageEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageEmp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btCloseManEmp = new Guna.UI2.WinForms.Guna2Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.realTime = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btEmpMan = new Guna.UI2.WinForms.Guna2Button();
            this.btShiftSum = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btCloseManEmp);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 31);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "MANAGE EMPLOYEE";
            // 
            // btCloseManEmp
            // 
            this.btCloseManEmp.BorderRadius = 5;
            this.btCloseManEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCloseManEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCloseManEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCloseManEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCloseManEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCloseManEmp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btCloseManEmp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCloseManEmp.ForeColor = System.Drawing.Color.White;
            this.btCloseManEmp.Location = new System.Drawing.Point(951, 3);
            this.btCloseManEmp.Name = "btCloseManEmp";
            this.btCloseManEmp.Size = new System.Drawing.Size(62, 25);
            this.btCloseManEmp.TabIndex = 0;
            this.btCloseManEmp.Text = "CLOSE";
            this.btCloseManEmp.Click += new System.EventHandler(this.btCloseManEmp_Click);
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
            // realTime
            // 
            this.realTime.Tick += new System.EventHandler(this.realTime_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btEmpMan);
            this.panel2.Controls.Add(this.btShiftSum);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 45);
            this.panel2.TabIndex = 8;
            // 
            // btEmpMan
            // 
            this.btEmpMan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btEmpMan.Checked = true;
            this.btEmpMan.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btEmpMan.CheckedState.FillColor = System.Drawing.Color.White;
            this.btEmpMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEmpMan.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btEmpMan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEmpMan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btEmpMan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btEmpMan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEmpMan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEmpMan.FillColor = System.Drawing.Color.White;
            this.btEmpMan.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmpMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btEmpMan.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btEmpMan.Location = new System.Drawing.Point(0, 0);
            this.btEmpMan.Name = "btEmpMan";
            this.btEmpMan.Size = new System.Drawing.Size(506, 45);
            this.btEmpMan.TabIndex = 3;
            this.btEmpMan.Text = "EMPLOYEE MANAGEMENT";
            this.btEmpMan.Click += new System.EventHandler(this.btEmpMan_Click);
            // 
            // btShiftSum
            // 
            this.btShiftSum.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btShiftSum.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btShiftSum.CheckedState.FillColor = System.Drawing.Color.White;
            this.btShiftSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btShiftSum.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btShiftSum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btShiftSum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btShiftSum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btShiftSum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btShiftSum.Dock = System.Windows.Forms.DockStyle.Right;
            this.btShiftSum.FillColor = System.Drawing.Color.White;
            this.btShiftSum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShiftSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btShiftSum.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btShiftSum.Location = new System.Drawing.Point(510, 0);
            this.btShiftSum.Name = "btShiftSum";
            this.btShiftSum.Size = new System.Drawing.Size(506, 45);
            this.btShiftSum.TabIndex = 2;
            this.btShiftSum.Text = "SHIFT SUMMARY";
            this.btShiftSum.Click += new System.EventHandler(this.btShiftSum_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Silver;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 76);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1016, 542);
            this.panelContainer.TabIndex = 9;
            // 
            // frmManageEmp
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmManageEmp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManageEmp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btCloseManEmp;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer realTime;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btShiftSum;
        private Guna.UI2.WinForms.Guna2Button btEmpMan;
        private System.Windows.Forms.Panel panelContainer;
    }
}