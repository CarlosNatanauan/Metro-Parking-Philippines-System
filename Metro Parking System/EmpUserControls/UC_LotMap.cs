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
    public partial class UC_LotMap : UserControl
    {
        public UC_LotMap()
        {
            InitializeComponent();
        }

        private void LoadParkingPlaceData()
        {
            databaseCodes dbCodes = new databaseCodes();
            ParkingPlace parkingPlace = dbCodes.GetParkingPlaceData();

            mt1.Text = parkingPlace.mt1.ToString();
            mt2.Text = parkingPlace.mt2.ToString();
            mt3.Text = parkingPlace.mt3.ToString();

            c1.Text = parkingPlace.c1.ToString();
            c2.Text = parkingPlace.c2.ToString();
            c3.Text = parkingPlace.c3.ToString();
            c4.Text = parkingPlace.c4.ToString();
            c5.Text = parkingPlace.c5.ToString();
            c6.Text = parkingPlace.c6.ToString();

            t1.Text = parkingPlace.t1.ToString();
            t2.Text = parkingPlace.t2.ToString();



            int totalAvailable = parkingPlace.mt1 + parkingPlace.mt2 + parkingPlace.mt3 +
             parkingPlace.c1 + parkingPlace.c2 + parkingPlace.c3 +
             parkingPlace.c4 + parkingPlace.c5 + parkingPlace.c6 +
             parkingPlace.t1 + parkingPlace.t2;
            Available.Text = totalAvailable.ToString();

            int totalOccupied = 120 - totalAvailable;
            Occupied.Text = totalOccupied.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UC_LotMap_Load(object sender, EventArgs e)
        {
            LoadParkingPlaceData();
        }

        private void refresher_Tick(object sender, EventArgs e)
        {
            LoadParkingPlaceData();
        }

        private void realTime_Tick(object sender, EventArgs e)
        {

        }
    }
}
