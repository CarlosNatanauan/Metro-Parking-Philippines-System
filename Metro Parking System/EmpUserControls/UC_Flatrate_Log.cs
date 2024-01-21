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
    public partial class UC_Flatrate_Log : UserControl
    {
        public UC_Flatrate_Log()
        {
            InitializeComponent();
        }


        public void UpdateDataGridView()
        {
            // Bind the DataGridView to the data source
            dgvFlatrateLog.DataSource = databaseCodes.GetCurrentDayTimeoutsFlatrate();

        }



        private void UC_Flatrate_Log_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();

            DateTime currentDate = DateTime.Now;
            currentDateLabel.Text = $"Successfully Exited Vehicles for {currentDate.ToString("MMMM dd, yyyy")}";
            Refresher.Start();
        }

        //di na ata need ng refresher
        private void Refresher_Tick(object sender, EventArgs e)
        {
            dgvFlatrateLog.Invoke(new Action(() => dgvFlatrateLog.DataSource = databaseCodes.GetCurrentDayTimeoutsFlatrate()));
        }

        private void dgvFlatrateLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
