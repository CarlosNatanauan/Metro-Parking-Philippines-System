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

namespace Metro_Parking_System.AdmUserControls.Revenue_Generation
{
    public partial class UC_RevenueGeneration : UserControl
    {
        public UC_RevenueGeneration()
        {
            InitializeComponent();

            UC_Daily uc = new UC_Daily();
            addUserControl(uc);
        }

        private void UC_RevenueGeneration_Load(object sender, EventArgs e)
        {

        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelReport.Controls.Clear();
            panelReport.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void daily_Click_1(object sender, EventArgs e)
        {
            UC_Daily uc = new UC_Daily();
            addUserControl(uc);
        }

        private void weekly_Click_1(object sender, EventArgs e)
        {
            UC_Weekly uc = new UC_Weekly();
            addUserControl(uc);
        }

        private void monthly_Click_1(object sender, EventArgs e)
        {
            UC_Monthly uc = new UC_Monthly();
            addUserControl(uc);
        }

        private void yearly_Click_1(object sender, EventArgs e)
        {
            UC_Yearly uc = new UC_Yearly();
            addUserControl(uc);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
