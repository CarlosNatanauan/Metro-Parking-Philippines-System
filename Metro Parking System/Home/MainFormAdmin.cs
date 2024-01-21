using Guna.UI2.WinForms;
using Metro_Parking_System.AdmNavMenu;
using Metro_Parking_System.AdmPrompts;
using Metro_Parking_System.Login;
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
    public partial class mainFormAdmin : Form
    {


        bool sidebarExpand;
        Guna2Button lastClickedButton = null;
        private Form activeForm = null;

        public mainFormAdmin()
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
                if (activeForm is frmManageEmp)
                {
                    // Enable the gunaBTvehicle button
                    gunaBTupdateRates.Enabled = true;
                }
                else if (activeForm is frmGenerateRev)
                {
                    gunaBTrevenueReport.Enabled = true;
                }
                else if (activeForm is frmManageEmp)
                {
                    gunaBTmanageEmployee.Enabled = true;
                }
                else if (activeForm is frmSettings)
                {
                    gunaBTadminSettings.Enabled = true;
                }

                activeForm.Close();
                activeForm = null;
            }

        }

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




        private void mainFormAdmin_Load(object sender, EventArgs e)
        {
            

            sidebarTimer.Start();

            // Assign the ButtonClick method to the Click event of each button
            gunaBTupdateRates.Click += ButtonClick;
            gunaBTrevenueReport.Click += ButtonClick;
            gunaBTmanageEmployee.Click += ButtonClick;
            gunaBTadminSettings.Click += ButtonClick;


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

        private void gunaBTupdateRates_Click(object sender, EventArgs e)
        {
            value f = new value(this); // pass this form as argument
            openChildForm(f);
            f.TopLevel = false;
            mainContainer.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void gunaBTrevenueReport_Click(object sender, EventArgs e)
        {
            frmGenerateRev f = new frmGenerateRev(this); // pass this form as argument
            openChildForm(f);
            f.TopLevel = false;
            mainContainer.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void gunaBTmanageEmployee_Click(object sender, EventArgs e)
        {
            frmManageEmp f = new frmManageEmp(this); // pass this form as argument
            openChildForm(f);
            f.TopLevel = false;
            mainContainer.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        public void gunaBTSettings_Click(object sender, EventArgs e)
        {
            frmSettings f = new frmSettings(this); // pass this form as argument
            openChildForm(f);
            f.TopLevel = false;
            mainContainer.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void sidebarTimer_Tick_1(object sender, EventArgs e)
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

        public static class AppState
        {
            public static string CurrentAdminUsername { get; set; }
            public static string CurrentSessionId { get; set; } // New property to store the session ID
        }


        private void gunaBTLogOut_Click(object sender, EventArgs e)
        {
            // Debugging: Display the current admin's username
            //MessageBox.Show("Logging out admin: " + AppState.CurrentAdminUsername, "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                databaseCodes dbCodes = new databaseCodes();
                dbCodes.UpdateAdminLogoutTime(AppState.CurrentSessionId);

                // Open the MainLoginForm
                MainLoginForm mainLoginForm = new MainLoginForm();
                mainLoginForm.Show();

                // Close the current form (mainFormAdmin)
                this.Hide();
            }
            // Handle cancellation if needed
        }




        private void mainContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaBTadminSettings_Click(object sender, EventArgs e)
        {
            {
                frmSettings f = new frmSettings(this); // pass this form as argument
                openChildForm(f);
                f.TopLevel = false;
                mainContainer.Controls.Add(f);
                f.BringToFront();
                f.Show();
            }
        }

        private void mainFormAdmin_Shown(object sender, EventArgs e)
        {
            WelcomeMessage welcomeMessage = new WelcomeMessage();
            welcomeMessage.ShowDialog();
        }
    }
}
