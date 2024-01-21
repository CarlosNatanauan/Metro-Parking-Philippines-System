using Metro_Parking_System.EmpData;
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

namespace Metro_Parking_System.EmpUserControls
{
    public partial class UC_LotMapSum : UserControl
    {
        public UC_LotMapSum()
        {
            InitializeComponent();
            timer1.Interval = 1000; // Set interval to 1 second
            timer1.Start();
        }

        private void UC_LotMapSum_Load(object sender, EventArgs e)
        {
            LoadParkingPlaceData();
            LoadParkingOccupied();
            // Updating the date label
            lbDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            // Updating the time label in 24-hour format
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }



        private void LoadParkingPlaceData()
        {
            databaseCodes dbCodes = new databaseCodes();
            ParkingPlace parkingPlace = dbCodes.GetParkingPlaceData();

            mt1Av.Text = parkingPlace.mt1.ToString();
            mt2Av.Text = parkingPlace.mt2.ToString();
            mt3Av.Text = parkingPlace.mt3.ToString();

            c1Av.Text = parkingPlace.c1.ToString();
            c2Av.Text = parkingPlace.c2.ToString();
            c3Av.Text = parkingPlace.c3.ToString();
            c4Av.Text = parkingPlace.c4.ToString();
            c5Av.Text = parkingPlace.c5.ToString();
            c6Av.Text = parkingPlace.c6.ToString();

            t1Av.Text = parkingPlace.t1.ToString();
            t2Av.Text = parkingPlace.t2.ToString();

            int totalAvailable = parkingPlace.mt1 + parkingPlace.mt2 + parkingPlace.mt3 +
                         parkingPlace.c1 + parkingPlace.c2 + parkingPlace.c3 +
                         parkingPlace.c4 + parkingPlace.c5 + parkingPlace.c6 +
                         parkingPlace.t1 + parkingPlace.t2;
            Available.Text = totalAvailable.ToString();

            int totalOccupied = 120 - totalAvailable;
            Occupied.Text = totalOccupied.ToString();

        }

        private void LoadParkingOccupied()
        {
            databaseCodes dbCodes = new databaseCodes();
            ParkingPlace parkingPlace = dbCodes.GetParkingPlaceData();

            mt1Oc.Text = (15 - parkingPlace.mt1).ToString();
            mt2Oc.Text = (15 - parkingPlace.mt2).ToString();
            mt3Oc.Text = (20 - parkingPlace.mt3).ToString();

            c1Oc.Text = (8 - parkingPlace.c1).ToString();
            c2Oc.Text = (8 - parkingPlace.c2).ToString();
            c3Oc.Text = (8 - parkingPlace.c3).ToString();
            c4Oc.Text = (8 - parkingPlace.c4).ToString();
            c5Oc.Text = (8 - parkingPlace.c5).ToString();
            c6Oc.Text = (10 - parkingPlace.c6).ToString();

            t1Oc.Text = (10 - parkingPlace.t1).ToString();
            t2Oc.Text = (10 - parkingPlace.t2).ToString();
        }


        private void refresher_Tick(object sender, EventArgs e)
        {
            LoadParkingPlaceData();
            LoadParkingOccupied();
        }

        private void Available_Click(object sender, EventArgs e)
        {

        }

        private void lbDate_Click(object sender, EventArgs e)
        {

        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Updating the date label
            lbDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            // Updating the time label in 24-hour format
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
