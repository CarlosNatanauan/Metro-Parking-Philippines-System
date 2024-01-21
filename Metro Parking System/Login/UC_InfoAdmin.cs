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
using static Metro_Parking_System.mainFormAdmin;

namespace Metro_Parking_System.Login
{
    public partial class UC_InfoAdmin : UserControl
    {

        private MainLoginForm parentForm;
        public UC_InfoAdmin(MainLoginForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }



        private void btLoginAd_Click(object sender, EventArgs e)
        {
            string inputUsername = tbAdUser.Text;
            string inputPassword = tbAdPass.Text;

            databaseCodes dbCodes = new databaseCodes();
            bool isLoginSuccessful = dbCodes.VerifyAndLogAdminLogin(inputUsername, inputPassword);

            if (isLoginSuccessful)
            {
                AppState.CurrentAdminUsername = inputUsername; // Set the current admin's username
                //MessageBox.Show("Logged in as: " + AppState.CurrentAdminUsername, "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information); // Debugging message

                parentForm.ShowAdmFormAndClose();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                tbAdPass.PasswordChar = '\0'; // Show password
            }
            else
            {
                tbAdPass.PasswordChar = '●'; // Hide password
            }
        }

        private void UC_InfoAdmin_Load(object sender, EventArgs e)
        {

        }

        private void lbForgot_Click(object sender, EventArgs e)
        {
            SecurityKey securityKeyForm = new SecurityKey();
            securityKeyForm.ShowDialog(); // Show the form as a modal dialog
        }


    }
}
