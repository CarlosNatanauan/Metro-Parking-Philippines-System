using Metro_Parking_System.AdmData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Parking_System.AdmUserControls
{
    public partial class UC_Shift_Summary : UserControl
    {
        public UC_Shift_Summary()
        {
            InitializeComponent();
        }

        public void PopulateShiftDetails(CoordinatorDetails morningA, CoordinatorDetails morningB, CoordinatorDetails afternoonA, CoordinatorDetails afternoonB)
        {
            SetCoordinatorDetails(emp1Morning, emp1MorningFNameMName, emp1MorningLName, morningA);
            SetCoordinatorDetails(emp2Morning, emp2MorningFNameMName, emp2MorningLName, morningB);
            SetCoordinatorDetails(emp1Afternoon, emp1AfternoonFNameMName, emp1AfternoonLName, afternoonA);
            SetCoordinatorDetails(emp2Afternoon, emp2AfternoonFNameMName, emp2AfternoonLName, afternoonB);
        }

        private void SetCoordinatorDetails(PictureBox imgBox, Label fNameMNameLabel, Label lNameLabel, CoordinatorDetails details)
        {
            imgBox.Image = details.Image != null ? Image.FromStream(new MemoryStream(details.Image)) : null;
            fNameMNameLabel.Text = details.FirstName + " " + details.MiddleName;
            lNameLabel.Text = details.LastName;
        }


        private void emp1Morning_Click(object sender, EventArgs e)
        {

        }

        private void emp1MorningLName_Click(object sender, EventArgs e)
        {

        }

        private void emp1MorningFNameMName_Click(object sender, EventArgs e)
        {

        }

        private void emp2Morning_Click(object sender, EventArgs e)
        {

        }

        private void emp2MorningLName_Click(object sender, EventArgs e)
        {

        }

        private void emp2MorningFNameMName_Click(object sender, EventArgs e)
        {

        }

        private void emp1Afternoon_Click(object sender, EventArgs e)
        {

        }

        private void emp1AfternoonLName_Click(object sender, EventArgs e)
        {

        }

        private void emp1AfternoonFNameMName_Click(object sender, EventArgs e)
        {

        }

        private void emp2Afternoon_Click(object sender, EventArgs e)
        {

        }

        private void emp2AfternoonLName_Click(object sender, EventArgs e)
        {

        }

        private void emp2AfternoonFNameMName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
