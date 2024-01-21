namespace Metro_Parking_System
{
    partial class frmVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btCloseVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.realTime = new System.Windows.Forms.Timer(this.components);
            this.btCasual = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btFlatrate = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btCloseVehicle);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 31);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "VEHICLE IN/OUT";
            // 
            // btCloseVehicle
            // 
            this.btCloseVehicle.BorderRadius = 5;
            this.btCloseVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCloseVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCloseVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCloseVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCloseVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCloseVehicle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btCloseVehicle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCloseVehicle.ForeColor = System.Drawing.Color.White;
            this.btCloseVehicle.Location = new System.Drawing.Point(951, 3);
            this.btCloseVehicle.Name = "btCloseVehicle";
            this.btCloseVehicle.Size = new System.Drawing.Size(62, 25);
            this.btCloseVehicle.TabIndex = 0;
            this.btCloseVehicle.Text = "CLOSE";
            this.btCloseVehicle.Click += new System.EventHandler(this.btCloseVehicle_Click);
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
            // btCasual
            // 
            this.btCasual.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCasual.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCasual.CheckedState.FillColor = System.Drawing.Color.White;
            this.btCasual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCasual.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btCasual.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCasual.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCasual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCasual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCasual.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCasual.FillColor = System.Drawing.Color.White;
            this.btCasual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCasual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btCasual.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCasual.Location = new System.Drawing.Point(510, 0);
            this.btCasual.Name = "btCasual";
            this.btCasual.Size = new System.Drawing.Size(506, 45);
            this.btCasual.TabIndex = 2;
            this.btCasual.Text = "CASUAL RATE PARKING";
            this.btCasual.Click += new System.EventHandler(this.btCasual_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btCasual);
            this.panel2.Controls.Add(this.btFlatrate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 45);
            this.panel2.TabIndex = 4;
            // 
            // btFlatrate
            // 
            this.btFlatrate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btFlatrate.Checked = true;
            this.btFlatrate.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btFlatrate.CheckedState.FillColor = System.Drawing.Color.White;
            this.btFlatrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFlatrate.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btFlatrate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btFlatrate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btFlatrate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btFlatrate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btFlatrate.FillColor = System.Drawing.Color.White;
            this.btFlatrate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFlatrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.btFlatrate.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btFlatrate.Location = new System.Drawing.Point(0, 0);
            this.btFlatrate.Name = "btFlatrate";
            this.btFlatrate.Size = new System.Drawing.Size(506, 45);
            this.btFlatrate.TabIndex = 1;
            this.btFlatrate.Text = "FLAT RATE PARKING";
            this.btFlatrate.Click += new System.EventHandler(this.btFlatrate_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Silver;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 76);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1016, 542);
            this.panelContainer.TabIndex = 5;
            // 
            // frmVehicle
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
            this.Name = "frmVehicle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVehicle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btCloseVehicle;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer realTime;
        private Guna.UI2.WinForms.Guna2Button btCasual;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btFlatrate;
        private System.Windows.Forms.Panel panelContainer;
    }
}