
using Metro_Parking_System.AdmUserControls.Report_Generation.Detailed_Report_Buttons;
using Metro_Parking_System.AdmUserControls.Report_Generation.Report_Buttons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Parking_System.AdmUserControls.Report_Generation
{
    public partial class UC_DetailedInfo : UserControl
    {
        public UC_DetailedInfo()
        {
            InitializeComponent();
            UC_Daily_detailed uc = new UC_Daily_detailed();
            addUserControl(uc);
        }



        private void UC_DetailedInfo_Load(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelReport.Controls.Clear();
            panelReport.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void daily_Click(object sender, EventArgs e)
        {
            UC_Daily_detailed uc = new UC_Daily_detailed();
            addUserControl(uc);
        }

        private void weekly_Click(object sender, EventArgs e)
        {
            UC_Weekly_detailed uc = new UC_Weekly_detailed();
            addUserControl(uc);
        }

        private void monthly_Click(object sender, EventArgs e)
        {
            UC_Monthly_detailed uc = new UC_Monthly_detailed();
            addUserControl(uc);
        }

        private void yearly_Click(object sender, EventArgs e)
        {
            UC_Yearly_detailed uc = new UC_Yearly_detailed();
            addUserControl(uc);
        }
    }
}
