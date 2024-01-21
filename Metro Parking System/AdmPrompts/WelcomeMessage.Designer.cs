namespace Metro_Parking_System.AdmPrompts
{
    partial class WelcomeMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeMessage));
            this.labelPrompt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new Guna.UI2.WinForms.Guna2Button();
            this.lcCurrentDate = new System.Windows.Forms.Label();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbOnlyDay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            this.labelPrompt.BackColor = System.Drawing.Color.White;
            this.labelPrompt.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(78)))));
            this.labelPrompt.Location = new System.Drawing.Point(114, 9);
            this.labelPrompt.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(421, 67);
            this.labelPrompt.TabIndex = 11;
            this.labelPrompt.Text = "WELCOME ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(40)))), ((int)(((byte)(16)))));
            this.label2.Location = new System.Drawing.Point(26, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 45);
            this.label2.TabIndex = 132;
            this.label2.Text = "Date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(40)))), ((int)(((byte)(16)))));
            this.label1.Location = new System.Drawing.Point(22, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 45);
            this.label1.TabIndex = 133;
            this.label1.Text = "Time: ";
            // 
            // buttonOK
            // 
            this.buttonOK.BorderRadius = 5;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(278, 254);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(92, 49);
            this.buttonOK.TabIndex = 134;
            this.buttonOK.Text = "OKAY";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // lcCurrentDate
            // 
            this.lcCurrentDate.AutoSize = true;
            this.lcCurrentDate.BackColor = System.Drawing.Color.White;
            this.lcCurrentDate.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcCurrentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(40)))), ((int)(((byte)(16)))));
            this.lcCurrentDate.Location = new System.Drawing.Point(117, 147);
            this.lcCurrentDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lcCurrentDate.Name = "lcCurrentDate";
            this.lcCurrentDate.Size = new System.Drawing.Size(90, 45);
            this.lcCurrentDate.TabIndex = 135;
            this.lcCurrentDate.Text = "Date";
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.BackColor = System.Drawing.Color.White;
            this.lbCurrentTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(40)))), ((int)(((byte)(16)))));
            this.lbCurrentTime.Location = new System.Drawing.Point(117, 192);
            this.lbCurrentTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(94, 45);
            this.lbCurrentTime.TabIndex = 136;
            this.lbCurrentTime.Text = "Time";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbOnlyDay
            // 
            this.lbOnlyDay.AutoSize = true;
            this.lbOnlyDay.BackColor = System.Drawing.Color.White;
            this.lbOnlyDay.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOnlyDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(40)))), ((int)(((byte)(16)))));
            this.lbOnlyDay.Location = new System.Drawing.Point(117, 100);
            this.lbOnlyDay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbOnlyDay.Name = "lbOnlyDay";
            this.lbOnlyDay.Size = new System.Drawing.Size(84, 47);
            this.lbOnlyDay.TabIndex = 137;
            this.lbOnlyDay.Text = "Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(40)))), ((int)(((byte)(16)))));
            this.label3.Location = new System.Drawing.Point(32, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 47);
            this.label3.TabIndex = 138;
            this.label3.Text = "Day:";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(649, 498);
            this.guna2PictureBox1.TabIndex = 139;
            this.guna2PictureBox1.TabStop = false;
            // 
            // WelcomeMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 498);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbOnlyDay);
            this.Controls.Add(this.lbCurrentTime);
            this.Controls.Add(this.lcCurrentDate);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPrompt);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WelcomeMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labelPrompt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button buttonOK;
        private System.Windows.Forms.Label lcCurrentDate;
        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbOnlyDay;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}