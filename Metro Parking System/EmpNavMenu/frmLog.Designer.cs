namespace Metro_Parking_System
{
    partial class frmLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btCloseLog = new Guna.UI2.WinForms.Guna2Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.realTime = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btCasualLog = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btFlatrateLog = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btCloseLog);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 31);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "VEHICLE LOG";
            // 
            // btCloseLog
            // 
            this.btCloseLog.BorderRadius = 5;
            this.btCloseLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCloseLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCloseLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCloseLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCloseLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCloseLog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btCloseLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCloseLog.ForeColor = System.Drawing.Color.White;
            this.btCloseLog.Location = new System.Drawing.Point(951, 3);
            this.btCloseLog.Name = "btCloseLog";
            this.btCloseLog.Size = new System.Drawing.Size(62, 25);
            this.btCloseLog.TabIndex = 0;
            this.btCloseLog.Text = "CLOSE";
            this.btCloseLog.Click += new System.EventHandler(this.btCloseLog_Click);
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
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 76);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1016, 542);
            this.panelContainer.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btCasualLog
            // 
            this.btCasualLog.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCasualLog.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCasualLog.CheckedState.FillColor = System.Drawing.Color.White;
            this.btCasualLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCasualLog.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btCasualLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCasualLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCasualLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCasualLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCasualLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCasualLog.FillColor = System.Drawing.Color.White;
            this.btCasualLog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCasualLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btCasualLog.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCasualLog.Location = new System.Drawing.Point(510, 0);
            this.btCasualLog.Name = "btCasualLog";
            this.btCasualLog.Size = new System.Drawing.Size(506, 45);
            this.btCasualLog.TabIndex = 2;
            this.btCasualLog.Text = "CASUAL RATE LOG";
            this.btCasualLog.Click += new System.EventHandler(this.btCasualLog_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btFlatrateLog);
            this.panel2.Controls.Add(this.btCasualLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 45);
            this.panel2.TabIndex = 6;
            // 
            // btFlatrateLog
            // 
            this.btFlatrateLog.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btFlatrateLog.Checked = true;
            this.btFlatrateLog.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btFlatrateLog.CheckedState.FillColor = System.Drawing.Color.White;
            this.btFlatrateLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFlatrateLog.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btFlatrateLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btFlatrateLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btFlatrateLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btFlatrateLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btFlatrateLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.btFlatrateLog.FillColor = System.Drawing.Color.White;
            this.btFlatrateLog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFlatrateLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btFlatrateLog.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btFlatrateLog.Location = new System.Drawing.Point(0, 0);
            this.btFlatrateLog.Name = "btFlatrateLog";
            this.btFlatrateLog.Size = new System.Drawing.Size(506, 45);
            this.btFlatrateLog.TabIndex = 1;
            this.btFlatrateLog.Text = "FLAT RATE LOG";
            this.btFlatrateLog.Click += new System.EventHandler(this.btFlatrateLog_Click);
            // 
            // frmLog
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
            this.Name = "frmLog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btCloseLog;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer realTime;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btCasualLog;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btFlatrateLog;
    }
}