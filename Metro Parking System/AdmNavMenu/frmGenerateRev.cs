using Metro_Parking_System.AdmUserControls.Report_Generation;
using Metro_Parking_System.AdmUserControls.Revenue_Generation;
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

namespace Metro_Parking_System.AdmNavMenu
{
    public partial class frmGenerateRev : Form
    {
        private mainFormAdmin MainFormAdmin { get; set; }

        public frmGenerateRev(mainFormAdmin mainForm)
        {
            InitializeComponent();
            this.MainFormAdmin = mainForm;
            UC_RevenueGeneration uc = new UC_RevenueGeneration();
            addUserControl(uc);
        }

        private void btCloseGenRev_Click(object sender, EventArgs e)
        {
            MainFormAdmin.gunaBTrevenueReport.Enabled = true;  // Enable the button when this form is closed
            MainFormAdmin.CloseActiveForm();
            this.Close();
        }

        private void frmGenerateRev_Load(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            realTime.Interval = 1000;
            realTime.Enabled = true;
            realTime.Tick += new EventHandler(realTime_Tick);
        }

        private void realTime_Tick(object sender, EventArgs e)
        {//para gumalaw sya
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btReportGeneration_Click(object sender, EventArgs e)
        {
            UC_RevenueGeneration uc = new UC_RevenueGeneration();
            addUserControl(uc);
        }

        private void btDetailedInfo_Click(object sender, EventArgs e)
        {
            UC_DetailedInfo uc = new UC_DetailedInfo();
            addUserControl(uc);
        }
    }
}
