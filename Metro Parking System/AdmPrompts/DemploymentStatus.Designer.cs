namespace Metro_Parking_System.AdmPrompts
{
    partial class DemploymentStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemploymentStatus));
            this.labelPrompt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbSubstitutedEmployeeList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btDeploy = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.activeSubCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            this.labelPrompt.BackColor = System.Drawing.Color.Transparent;
            this.labelPrompt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.labelPrompt.Location = new System.Drawing.Point(26, 28);
            this.labelPrompt.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(258, 34);
            this.labelPrompt.TabIndex = 10;
            this.labelPrompt.Text = "DEPLOYMENT STATUS";
            // 
            // cbSubstitutedEmployeeList
            // 
            this.cbSubstitutedEmployeeList.BackColor = System.Drawing.Color.Transparent;
            this.cbSubstitutedEmployeeList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSubstitutedEmployeeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubstitutedEmployeeList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSubstitutedEmployeeList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSubstitutedEmployeeList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSubstitutedEmployeeList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSubstitutedEmployeeList.ItemHeight = 30;
            this.cbSubstitutedEmployeeList.Location = new System.Drawing.Point(26, 144);
            this.cbSubstitutedEmployeeList.Name = "cbSubstitutedEmployeeList";
            this.cbSubstitutedEmployeeList.Size = new System.Drawing.Size(258, 36);
            this.cbSubstitutedEmployeeList.TabIndex = 127;
            this.cbSubstitutedEmployeeList.SelectedIndexChanged += new System.EventHandler(this.cbSubstitutedEmployeeList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(23, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 126;
            this.label1.Text = "Select Substituted Employee";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BorderRadius = 5;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancel.Location = new System.Drawing.Point(97, 190);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 39);
            this.buttonCancel.TabIndex = 129;
            this.buttonCancel.Text = "CLOSE";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // btDeploy
            // 
            this.btDeploy.BorderRadius = 5;
            this.btDeploy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btDeploy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDeploy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDeploy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDeploy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDeploy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDeploy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btDeploy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDeploy.Location = new System.Drawing.Point(187, 190);
            this.btDeploy.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btDeploy.Name = "btDeploy";
            this.btDeploy.Size = new System.Drawing.Size(97, 39);
            this.btDeploy.TabIndex = 128;
            this.btDeploy.Text = "REVERT";
            this.btDeploy.Click += new System.EventHandler(this.btDeploy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 130;
            this.label2.Text = "Active Substitutes:";
            // 
            // activeSubCount
            // 
            this.activeSubCount.AutoSize = true;
            this.activeSubCount.BackColor = System.Drawing.SystemColors.Control;
            this.activeSubCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeSubCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(43)))));
            this.activeSubCount.Location = new System.Drawing.Point(193, 69);
            this.activeSubCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.activeSubCount.Name = "activeSubCount";
            this.activeSubCount.Size = new System.Drawing.Size(23, 25);
            this.activeSubCount.TabIndex = 131;
            this.activeSubCount.Text = "0";
            // 
            // DemploymentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 257);
            this.ControlBox = false;
            this.Controls.Add(this.activeSubCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.btDeploy);
            this.Controls.Add(this.cbSubstitutedEmployeeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DemploymentStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DemploymentStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labelPrompt;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubstitutedEmployeeList;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private Guna.UI2.WinForms.Guna2Button btDeploy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label activeSubCount;
    }
}