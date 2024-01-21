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

namespace Metro_Parking_System
{
    public partial class frmParkingRate : Form
    {
        private mainForm MainForm { get; set; }
        public frmParkingRate(mainForm mainForm)
        {
            InitializeComponent();
            this.MainForm = mainForm;
        }


        private void realTime_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void frmParkingRate_Load(object sender, EventArgs e)
        {

            databaseCodes dbCodes = new databaseCodes();
            dbCodes.FetchRates();

            lbRateCasTwoHours.Text = "₱" + databaseCodes.RateCasTwoHours.ToString();
            lbRateCasSucHours.Text = "₱" + databaseCodes.RateCasSucHours.ToString();
            lbRateFlatEntry.Text = "₱" + databaseCodes.RateFlatEntry.ToString();
            lbOthersPenLossTix.Text = "₱" + databaseCodes.OthersPenLossTix.ToString();
            lbOthersPenOverStay.Text = "₱" + databaseCodes.OthersPenOverStay.ToString();
            lbOthersDisPwdSen.Text = databaseCodes.OthersDisPwdSen.ToString() + "%";

            lbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            realTime.Interval = 1000;
            realTime.Enabled = true;
            realTime.Tick += new EventHandler(realTime_Tick);
        }

        private void btCloseRates_Click(object sender, EventArgs e)
        {
            MainForm.gunaBTvehicle.Enabled = true;  // Enable the button when this form is closed
            MainForm.CloseActiveForm();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
    }
}
