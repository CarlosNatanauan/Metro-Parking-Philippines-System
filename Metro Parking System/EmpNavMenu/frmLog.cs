using Metro_Parking_System.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Parking_System
{
    public partial class frmLog : Form
    {
        private mainForm MainForm { get; set; }
        public frmLog(mainForm mainForm)
        {
            InitializeComponent();
            this.MainForm = mainForm;
            UC_Flatrate_Log uc = new UC_Flatrate_Log();
            addUserControl(uc);
        }

        private void realTime_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            realTime.Interval = 1000;
            realTime.Enabled = true;
            realTime.Tick += new EventHandler(realTime_Tick);
        }

        private void btCloseLog_Click(object sender, EventArgs e)
        {
            MainForm.gunaBTvehicle.Enabled = true;  // Enable the button when this form is closed
            MainForm.CloseActiveForm();
            this.Close();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btFlatrateLog_Click(object sender, EventArgs e)
        {
            UC_Flatrate_Log uc = new UC_Flatrate_Log();
            addUserControl(uc);
        }

        private void btCasualLog_Click(object sender, EventArgs e)
        {
            UC_Casual_Log uc = new UC_Casual_Log();
            addUserControl(uc);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
