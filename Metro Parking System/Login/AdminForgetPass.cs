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

namespace Metro_Parking_System.Login
{
    public partial class AdminForgetPass : Form
    {
        public AdminForgetPass()
        {
            InitializeComponent();
        }


        private void AdminForgetPass_Load(object sender, EventArgs e)
        {
            // Additional initialization code if needed
        }

        private void tbNewpPass_TextChanged(object sender, EventArgs e)
        {
            lbPasswordValidation.Visible = true; // Make the label visible
            string newPassword = tbNewpPass.Text;
            ValidatePassword(newPassword);
        }


        private void tbConfirmPass_TextChanged(object sender, EventArgs e)
        {
            lbPasswordConfirmation.Visible = true; // Make the label visible
            string newPassword = tbNewpPass.Text;
            string confirmPassword = tbConfirmPass.Text;

            if (newPassword == confirmPassword)
            {
                lbPasswordConfirmation.Text = "Passwords match";
                lbPasswordConfirmation.ForeColor = Color.Green;
            }
            else
            {
                lbPasswordConfirmation.Text = "Passwords do not match";
                lbPasswordConfirmation.ForeColor = Color.Red;
            }
        }



        private void btSet_Click(object sender, EventArgs e)
        {
            string newPassword = tbNewpPass.Text;
            string confirmPassword = tbConfirmPass.Text;

            if (!ValidatePassword(newPassword))
            {
                MessageBox.Show("Password does not meet the requirements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed with updating the password in the database
            try
            {
                databaseCodes.UpdateAdminPassword(newPassword); // Call the static method directly
                MessageBox.Show("Password successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after successful update
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidatePassword(string password)
        {
            bool isValid = password.Length >= 8 && password.Length <= 11 &&
                           password.Any(char.IsUpper) &&
                           password.Any(char.IsDigit) &&
                           password.Any(char.IsLower) &&
                           password.Any(c => !char.IsLetterOrDigit(c));
            lbPasswordValidation.Text = isValid ? "Password valid" : "8-11 chars, mix of num, lower, upper, symbols";
            lbPasswordValidation.ForeColor = isValid ? Color.Green : Color.Red;
            return isValid;
        }



        private void lbPasswordConfirmation_Click(object sender, EventArgs e)
        {

        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
