using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Metro_Parking_System.AdmData;
using Metro_Parking_System.AdmPrompts;
using Metro_Parking_System.EmpPrompts;
using Metro_Parking_System.Login;
using Metro_Parking_System1;

namespace Metro_Parking_System
{

    public partial class mainForm : Form
    {
        public static int LoggedInEmployeeId { get; set; }

        bool sidebarExpand;
        Guna2Button lastClickedButton = null;
        private Form activeForm = null;
        public mainForm()
        {
            InitializeComponent();
            sidebarExpand = true;
            
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(childForm);
            mainContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        public void CloseActiveForm()
        {
            if (activeForm != null)
            {
                // Check if the active form is of type frmVehicle
                if (activeForm is frmVehicle)
                {
                    // Enable the gunaBTvehicle button
                    gunaBTvehicle.Enabled = true;
                }
                else if (activeForm is frmParkingRate)
                {
                    gunaBTrates.Enabled = true;
                }
                else if (activeForm is frmLotMap)
                {
                    gunaBTmap.Enabled = true;
                }
                else if (activeForm is frmLog)
                {
                    gunaBTlog.Enabled = true;
                }

                activeForm.Close();
                activeForm = null;
            }

        }



        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

            sidebarTimer.Start();

            // Assign the ButtonClick method to the Click event of each button
            gunaBTvehicle.Click += ButtonClick;
            gunaBTrates.Click += ButtonClick;
            gunaBTmap.Click += ButtonClick;
            gunaBTlog.Click += ButtonClick;

            Employee employee = databaseCodes.GetEmployeeById(mainForm.LoggedInEmployeeId);
            string fullName = string.IsNullOrEmpty(employee.empMiddleName)
                ? $"{employee.empFirstName} {employee.empLastName}"
                : $"{employee.empFirstName} {employee.empMiddleName} {employee.empLastName}";
            lbEmpName.Text = fullName;

            lbJobDesc.Text = employee.jobDesc;

        }



        // Create a single Click event handler for all buttons
        private void ButtonClick(object sender, EventArgs e)
        {
            // Then cast sender to Guna2Button so we can access the clicked button
            var clickedButton = (Guna2Button)sender;

            // Enable the last clicked button if it exists
            if (lastClickedButton != null)
            {
                lastClickedButton.Enabled = true;
            }

            // Disable the clicked button and store it as the last clicked button
            clickedButton.Enabled = false;
            lastClickedButton = clickedButton;

            // If the sidebar is maximized, set sidebarExpand to true to start minimizing it
            if (sidebar.Width == sidebar.MaximumSize.Width)
            {
                sidebarExpand = true;
                sidebarTimer.Start();
            }
        }


        private void gunaBTvehicle_Click(object sender, EventArgs e)
        {
            frmVehicle f = new frmVehicle(this); // pass this form as argument
            openChildForm(f);
            f.TopLevel = false;
            mainContainer.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void gunaBTrates_Click(object sender, EventArgs e)
        {
            frmParkingRate f = new frmParkingRate(this); // pass this form as argument
            openChildForm(f);
            f.TopLevel = false;
            mainContainer.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void gunaBTmap_Click(object sender, EventArgs e)
        {
            frmLotMap f = new frmLotMap(this); // pass this form as argument
            openChildForm(f);
            f.TopLevel = false;
            mainContainer.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void gunaBTlog_Click(object sender, EventArgs e)
        {
            frmLog f = new frmLog(this);
            openChildForm(f);
            f.TopLevel = false;
            mainContainer.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }



        private void gunaBTLogOut_Click(object sender, EventArgs e)
        {
            // Display the confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Open the MainLoginForm
                MainLoginForm mainLoginForm = new MainLoginForm();
                mainLoginForm.Show();

                // Close the current form (mainFormAdmin)
                this.Hide();
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuButton1_Click(object sender, EventArgs e)
        {
            // If the sidebar is minimized, set sidebarExpand to false to start maximizing it
            if (sidebar.Width == sidebar.MinimumSize.Width)
            {
                sidebarExpand = false;
                sidebarTimer.Start();
            }
            // If the sidebar is maximized, set sidebarExpand to true to start minimizing it
            else if (sidebar.Width == sidebar.MaximumSize.Width)
            {
                sidebarExpand = true;
                sidebarTimer.Start();
            }
        }

        private void mainContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            WelcomeMessageEmp welcomeMessageEmp = new WelcomeMessageEmp();
            welcomeMessageEmp.ShowDialog();
        }

        private void lbEmpName_Click(object sender, EventArgs e)
        {

        }
    }
}
