using Metro_Parking_System.AdmData;
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

namespace Metro_Parking_System.EmpPrompts
{
    public partial class WelcomeMessageEmp : Form
    {
        public WelcomeMessageEmp()
        {
            InitializeComponent();
            UpdateDateAndDay();
            timer.Start();
        }


        private void WelcomeMessageEmp_Load(object sender, EventArgs e)
        {
            lbCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");

            Employee employee = databaseCodes.GetEmployeeById(mainForm.LoggedInEmployeeId);
            string fullName = string.IsNullOrEmpty(employee.empMiddleName)
                ? $"{employee.empFirstName} {employee.empLastName}"
                : $"{employee.empFirstName} {employee.empMiddleName} {employee.empLastName}";
            lbEmpName.Text = fullName;
        }


        private void UpdateDateAndDay()
        {
            // Set the lcCurrentDate without the day part
            lcCurrentDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            // Set the lbOnlyDay with the day part only.
            lbOnlyDay.Text = DateTime.Now.ToString("dddd");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void lbEmpName_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
