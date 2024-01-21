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

namespace Metro_Parking_System.AdmPrompts
{
    public partial class AdminInformation : Form
    {

        public delegate void CredentialsUpdatedDelegate();
        public event CredentialsUpdatedDelegate CredentialsUpdated;

        public AdminInformation()
        {
            InitializeComponent();
        }


        public void ShowCredential()
        {
            // Fetch the new credentials from the database
            (string updatedUsername, string updatedPassword, string updatedFname, string updatedMname, string updatedLname) = databaseCodes.FetchAdminCredentials();

            // Update additional information
            tbUserName.Text = updatedUsername;
            tbPassword.Text = updatedPassword;
            tbFirstName.Text = updatedFname;
            tbMiddleName.Text = updatedMname;
            tbLastName.Text = updatedLname;

            // Refresh UI controls
        }


        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            ValidateUsername(tbUserName.Text);
        }
        private void tbUserName_Leave(object sender, EventArgs e)
        {
            ValidateUsername(tbUserName.Text);
        }
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword(tbPassword.Text);
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            ValidatePassword(tbPassword.Text);
        }


        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            // First Name should not be null
            if (!string.IsNullOrWhiteSpace(tbFirstName.Text))  // Fixed from tbLastName.Text
            {
                lbFnameValidation.Show();  // Fixed from tbFirstName.Show();
                lbFnameValidation.Text = "First name set!";  // Fixed from tbFirstName.Text;
                lbFnameValidation.ForeColor = Color.Green;  // Fixed from tbFirstName.ForeColor;
            }
            else
            {
                lbFnameValidation.Show();  // Fixed from tbFirstName.Show();
                lbFnameValidation.Text = "First name required.";  // Fixed from tbFirstName.Text;
                lbFnameValidation.ForeColor = Color.Red;  // Fixed from tbFirstName.ForeColor;
            }
        }

        private void tbMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            // Last Name should not be null
            if (!string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                lbLnameValidation.Show();
                lbLnameValidation.Text = "Last name set!";
                lbLnameValidation.ForeColor = Color.Green;
            }
            else
            {
                lbLnameValidation.Show();
                lbLnameValidation.Text = "Last name required.";
                lbLnameValidation.ForeColor = Color.Red;
            }
        }

        private void lbUsernameValidation_Click(object sender, EventArgs e)
        {
            
        }

        private void lbPasswordValidation_Click(object sender, EventArgs e)
        {

        }

        private void lbFnameValidation_Click(object sender, EventArgs e)
        {

        }

        private void lbLnameValidation_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save these changes?", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    databaseCodes.UpdateAdminCredentials(tbUserName.Text, tbPassword.Text, tbFirstName.Text, tbMiddleName.Text, tbLastName.Text);
                    MessageBox.Show("Credentials updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Invoke the delegate to notify that credentials have been updated
                    CredentialsUpdated?.Invoke();

                    this.Close(); // Close the form after updating
                }
            }
            else
            {
                MessageBox.Show("Please correct the highlighted fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool IsInputValid()
        {
            // Validate username and password along with first and last names
            return ValidateUsername(tbUserName.Text) && ValidatePassword(tbPassword.Text) && !string.IsNullOrWhiteSpace(tbFirstName.Text) && !string.IsNullOrWhiteSpace(tbLastName.Text);
        }

        private bool ValidateUsername(string username)
        {
            bool isValid = !string.IsNullOrWhiteSpace(username) &&
                           username.Length >= 5 && username.Length <= 11 &&
                           username.Any(char.IsDigit) &&
                           username.Any(char.IsUpper);
            lbUsernameValidation.Text = isValid ? "Username valid" : "5-11 chars, 1 num, 1 upper";
            lbUsernameValidation.ForeColor = isValid ? Color.Green : Color.Red;
            return isValid;
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




        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminInformation_Load(object sender, EventArgs e)
        {
            ShowCredential();
        }



        private void tbFirstName_Leave(object sender, EventArgs e)
        {
            // Check when focus leaves the text box
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                lbFnameValidation.Show();
                lbFnameValidation.Text = "First name required.";
                lbFnameValidation.ForeColor = Color.Red;
            }
            else
            {
                lbFnameValidation.Show();
                lbFnameValidation.Text = "First name set!";
                lbFnameValidation.ForeColor = Color.Green;

            }
        }

        private void tbMiddleName_Leave(object sender, EventArgs e)
        {

        }

        private void tbLastName_Leave(object sender, EventArgs e)
        {
            // Check when focus leaves the text box
            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                lbLnameValidation.Show();
                lbLnameValidation.Text = "Last name required.";
                lbLnameValidation.ForeColor = Color.Red;
            }
            else
            {
                lbLnameValidation.Show();
                lbLnameValidation.Text = "Last name set!";
                lbLnameValidation.ForeColor = Color.Green;

            }
        }


    }
}
