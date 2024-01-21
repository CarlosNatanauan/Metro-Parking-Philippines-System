using Metro_Parking_System1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Parking_System.UserControls
{
    public partial class UC_Casual_Log : UserControl
    {
        public UC_Casual_Log()
        {
            InitializeComponent();
            DateTime currentDate = DateTime.Now;
            currentDateLabel.Text = $"Successfully Exited Vehicles for {currentDate.ToString("MMMM dd, yyyy")}";
        }


        public void UpdateDataGridView()
        {
            dgvCasualLog.DataSource = databaseCodes.GetCurrentDayTimeoutsCasual();
        }


        private void UC_Casual_Log_Load(object sender, EventArgs e)
        {
           UpdateDataGridView();
           Refresher.Start();
        }

        // di na ata need ng refresher
        private void Refresher_Tick(object sender, EventArgs e)
        {
            dgvCasualLog.Invoke(new Action(() => dgvCasualLog.DataSource = databaseCodes.GetCurrentDayTimeoutsCasual()));
        }

        private void dgvCasualLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
