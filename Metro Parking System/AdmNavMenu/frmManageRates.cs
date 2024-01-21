using Metro_Parking_System.EmpPrompts;
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

namespace Metro_Parking_System.AdmNavMenu
{
    public partial class value : Form
    {

        private mainFormAdmin MainFormAdmin { get; set; }
        public value(mainFormAdmin mainForm)
        {
            InitializeComponent();
            this.MainFormAdmin = mainForm;
        }

        private void btCloseManRates_Click(object sender, EventArgs e)
        {
            MainFormAdmin.gunaBTupdateRates.Enabled = true;  // Enable the button when this form is closed
            MainFormAdmin.CloseActiveForm();
            this.Close();
        }

        private void realTime_Tick(object sender, EventArgs e)
        {//para gumalaw sya
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void frmManageRates_Load(object sender, EventArgs e)
        {
            databaseCodes dbCodes = new databaseCodes();
            dbCodes.FetchRates();
            //retrive value from database
            lbRateCasTwoHours.Text = ":  ₱" + databaseCodes.RateCasTwoHours.ToString("0.00");
            lbRateCasSucHours.Text = ":  ₱" + databaseCodes.RateCasSucHours.ToString();
            lbRateFlatEntry.Text = ":  ₱" + databaseCodes.RateFlatEntry.ToString();
            lbOthersPenLossTix.Text = ":  ₱" + databaseCodes.OthersPenLossTix.ToString();
            lbOthersPenOverStay.Text = ":  ₱" + databaseCodes.OthersPenOverStay.ToString();
            lbOthersDisPwdSen.Text = ":  "+databaseCodes.OthersDisPwdSen.ToString() + "%";

            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            realTime.Interval = 1000;
            realTime.Enabled = true;
            realTime.Tick += new EventHandler(realTime_Tick);
        }


        private void UpdateRate(string fieldName, Label label, decimal minimumValue, decimal maximumValue, string description)
        {
            object currentValueObj = typeof(databaseCodes).GetProperty(fieldName).GetValue(null);
            decimal currentValue = Convert.ToDecimal(currentValueObj);
            EditValue editForm = new EditValue(currentValue, description, minimumValue, maximumValue); ; // pass description to the constructor
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                databaseCodes.UpdateRate(fieldName, editForm.ValueToEdit);
                label.Text = ":  ₱" + (editForm.ValueToEdit % 1 == 0 ? editForm.ValueToEdit.ToString("0.00") : editForm.ValueToEdit.ToString("0.00")) + (fieldName == "OthersDisPwdSen" ? "%" : "");
            }
        }


        private void btRateCasTwoHours_Click(object sender, EventArgs e)
        {
            UpdateRate("RateCasTwoHours", lbRateCasTwoHours, 20,30, "(Casual) First two Hours");
        }

        private void btRateCasSucHours_Click(object sender, EventArgs e)
        {
             UpdateRate("RateCasSucHours", lbRateCasSucHours, 10,15, "(Casual)Succeeding Hours");
        }

        private void btRateFlatEntry_Click(object sender, EventArgs e)
        {
            UpdateRate("RateFlatEntry", lbRateFlatEntry, 20,30, "(Flatrate)Per Entry");
        }

        private void btOthersPenLossTix_Click(object sender, EventArgs e)
        {
            UpdateRate("OthersPenLossTix", lbOthersPenLossTix, 200, 300, "Lost Ticket");
        }

        private void btOthersPenOverStay_Click(object sender, EventArgs e)
        {
            UpdateRate("OthersPenOverStay", lbOthersPenOverStay, 500,700, "Over Staying");
        }

        private void btOthersDisPwdSen_Click(object sender, EventArgs e)
        {
            UpdateRate("OthersDisPwdSen", lbOthersDisPwdSen, 20,30, "PWD/Senior");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
