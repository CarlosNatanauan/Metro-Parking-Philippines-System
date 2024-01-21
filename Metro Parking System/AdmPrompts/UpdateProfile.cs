using Metro_Parking_System.AdmData;
using Metro_Parking_System1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Metro_Parking_System.AdmPrompts
{
    public partial class UpdateProfile : Form
    {
        private bool isUpdatingComboBoxes = false;
        //for timer
        //private DateTime lastUpdated = DateTime.MinValue;

        public delegate void UpdateHandler(object sender, EventArgs e);
        public event UpdateHandler OnUpdateSuccess;

        private Employee emp;
        public UpdateProfile(Employee selectedEmp)
        {
            InitializeComponent();
            this.emp = selectedEmp;
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            lbUsernameValidation.Hide();
            lbPasswordValidation.Hide();
            lbLnameValidation.Hide();
            lbFnameValidation.Hide();

            tbUserName.Text = emp.empUser;
            tbPassword.Text = emp.empPass;
            tbFirstName.Text = emp.empFirstName;
            tbMiddleName.Text = emp.empMiddleName;
            tbLastName.Text = emp.empLastName;

            // Display Image
            if (emp.empImg != null)
            {
                using (MemoryStream ms = new MemoryStream(emp.empImg))
                {
                    EmpSetPic.Image = Image.FromStream(ms);
                }
            }

            if (emp.empID == 5 || emp.empID == 6)
            {
                // Handle 'Not Assigned' for job description
                if (emp.jobDesc == null)
                {
                    cbJobDescription.Items.Add("Not Assigned");
                }
                else
                {
                    cbJobDescription.Items.Add(emp.jobDesc);
                }
                cbJobDescription.SelectedIndex = 0;
                cbJobDescription.Enabled = false;

                // Handle 'Not Assigned' for shift
                if (emp.shift == null)
                {
                    cbShift.Items.Add("Not Assigned");
                }
                else
                {
                    cbShift.Items.Add(emp.shift);
                }
                cbShift.SelectedIndex = 0;
                cbShift.Enabled = false;

                return;  // Exit the method early
            }




            // Update ComboBoxes
            UpdateComboBoxes();  // Populate ComboBoxes

            // Check if all roles for all shifts are taken
            bool allRolesTakenForAllShifts = true;
            List<string> availableShifts = new List<string> { "Morning", "Afternoon" };
            List<string> availableRoles = new List<string> { "Entry Lead", "Exit Lead" };

            foreach (var shift in availableShifts)
            {
                foreach (var role in availableRoles)
                {
                    int count = databaseCodes.GetEmployeeCountByRoleAndShift(role, shift);
                    if (count < 1)
                    {
                        allRolesTakenForAllShifts = false;
                        break;
                    }
                }
                if (!allRolesTakenForAllShifts)
                {
                    break;
                }
            }

            if (allRolesTakenForAllShifts)
            {
                // Disable both combo boxes if all roles for all shifts are taken
                cbShift.Enabled = false;
                cbJobDescription.Enabled = false;
            }
            else
            {
                // Enable the combo boxes and set their selected items
                cbShift.Enabled = true;
                cbJobDescription.Enabled = true;

                if (emp.shift != null && cbShift.Items.Contains(emp.shift))
                {
                    cbShift.SelectedItem = emp.shift;
                }

                if (emp.jobDesc != null && cbJobDescription.Items.Contains(emp.jobDesc))
                {
                    cbJobDescription.SelectedItem = emp.jobDesc;
                }
            }
        }



        private void EmpSetPic_Click(object sender, EventArgs e)
        {

        }

        private void btChangePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files(*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load image and convert to binary
                Image image = Image.FromFile(openFileDialog.FileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    emp.empImg = ms.ToArray();
                }

                // Display in PictureBox
                EmpSetPic.Image = image;
            }
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                MessageBox.Show("Required information is missing.");
                return;
            }

            if (lbUsernameValidation.ForeColor == Color.Red || lbPasswordValidation.ForeColor == Color.Red)
            {
                MessageBox.Show("Username or password is not set properly. Please review the requirements.");
                return;
            }

            // Collect updated data
            emp.empUser = tbUserName.Text;
            emp.empPass = tbPassword.Text;
            emp.empFirstName = tbFirstName.Text;
            emp.empMiddleName = tbMiddleName.Text;
            emp.empLastName = tbLastName.Text;

            // Check if the selected items are "Not Assigned"
            var selectedJobDesc = cbJobDescription.SelectedItem?.ToString();
            var selectedShift = cbShift.SelectedItem?.ToString();

            emp.jobDesc = selectedJobDesc == "Not Assigned" ? null : selectedJobDesc;
            emp.shift = selectedShift == "Not Assigned" ? null : selectedShift;

            // Update in database
            databaseCodes.UpdateEmployee(emp);

            // Trigger the event
            OnUpdateSuccess?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Employee updated successfully!");

            // Close form
            this.Close();

            // Optional: close form or show success message
            databaseCodes.UpdateRefreshTimestampAdmin(DateTime.Now);
        }




        //update after consultation
        private void UpdateComboBoxes()
        {
            if (isUpdatingComboBoxes) return;
            isUpdatingComboBoxes = true;

            // Save the current selections
            string savedShift = cbShift.SelectedItem?.ToString();
            string savedJobDescription = cbJobDescription.SelectedItem?.ToString();

            try
            {
                // Clear ComboBoxes
                cbShift.Items.Clear();
                cbJobDescription.Items.Clear();

                if (emp.empID == 5 || emp.empID == 6)
                {
                    // The same logic as in UpdateProfile_Load can be here
                    if (emp.jobDesc == null)
                    {
                        cbJobDescription.Items.Add("Not Assigned");
                    }
                    else
                    {
                        cbJobDescription.Items.Add(emp.jobDesc);
                    }
                    cbJobDescription.SelectedIndex = 0;
                    cbJobDescription.Enabled = false;

                    if (emp.shift == null)
                    {
                        cbShift.Items.Add("Not Assigned");
                    }
                    else
                    {
                        cbShift.Items.Add(emp.shift);
                    }
                    cbShift.SelectedIndex = 0;
                    cbShift.Enabled = false;

                    return;  // Exit the method early
                }




                List<string> availableShifts = new List<string> { "Morning", "Afternoon" };
                List<string> availableRoles = new List<string> { "Entry Lead", "Exit Lead" };

                // Populate shifts
                foreach (var shift in availableShifts)
                {
                    int count = databaseCodes.GetEmployeeCountByShift(shift);
                    if (count >= 2 && (emp.shift == null || !emp.shift.Equals(shift, StringComparison.OrdinalIgnoreCase)))
                    {
                        continue;
                    }
                    cbShift.Items.Add(shift);
                }

                // Restore the saved shift or set default selection for Shifts
                if (savedShift != null && cbShift.Items.Contains(savedShift))
                {
                    cbShift.SelectedItem = savedShift;
                }
                else if (cbShift.Items.Count > 0)
                {
                    cbShift.SelectedIndex = 0;
                }

                // Populate roles based on selected shift
                string selectedShift = cbShift.SelectedItem?.ToString();
                if (selectedShift != null)
                {
                    foreach (var role in availableRoles)
                    {
                        int count = databaseCodes.GetEmployeeCountByRoleAndShift(role, selectedShift);
                        if (count >= 1 && (emp.jobDesc == null || !emp.jobDesc.Equals(role, StringComparison.OrdinalIgnoreCase)))
                        {
                            continue;
                        }
                        cbJobDescription.Items.Add(role);
                    }
                }

                // Restore the saved job description or set default selection for Job Description
                if (savedJobDescription != null && cbJobDescription.Items.Contains(savedJobDescription))
                {
                    cbJobDescription.SelectedItem = savedJobDescription;
                }
                else if (cbJobDescription.Items.Count > 0)
                {
                    cbJobDescription.SelectedIndex = 0;
                }
                else
                {
                    cbJobDescription.Enabled = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception in UpdateComboBoxes: " + e.Message);
            }
            finally
            {
                isUpdatingComboBoxes = false;  // Reset the flag to false
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxes();
        }

        private void cbJobDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxes();
        }

        private void lbUsernameValidation_Click(object sender, EventArgs e)
        {

        }

        private void lbPasswordValidation_Click(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            // Username must be 5-11 characters long and contain at least one number and one upper case letter
            if (tbUserName.Text.Length >= 5 && tbUserName.Text.Length <= 11 && tbUserName.Text.Any(char.IsDigit)
                && tbUserName.Text.Any(char.IsUpper))
            {
                lbUsernameValidation.Show();
                lbUsernameValidation.Text = "Username set!";
                lbUsernameValidation.ForeColor = Color.Green;
            }
            else
            {
                lbUsernameValidation.Show();
                lbUsernameValidation.Text = "5-11 chars, 1 num, 1 upper.";
                lbUsernameValidation.ForeColor = Color.Red;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            // Password must be 8-11 characters long and contain both numbers and alphabets and symbols
            if (tbPassword.Text.Length >= 8 && tbPassword.Text.Length <= 11 && tbPassword.Text.Any(char.IsDigit) &&
                tbPassword.Text.Any(char.IsLower) && tbPassword.Text.Any(char.IsUpper) &&
                tbPassword.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                lbPasswordValidation.Show();
                lbPasswordValidation.Text = "Password set!";
                lbPasswordValidation.ForeColor = Color.Green;
            }
            else
            {
                lbPasswordValidation.Show();
                lbPasswordValidation.Text = "8-11 chars, mix of num, lower, upper, symbols.";
                lbPasswordValidation.ForeColor = Color.Red;
            }
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




        private void tbFirstName_Leave(object sender, EventArgs e)
        {
            // Check when focus leaves the text box
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                lbFnameValidation.Show();
                lbFnameValidation.Text = "First name required.";
                lbFnameValidation.ForeColor = Color.Red;
            }
            else {
                lbFnameValidation.Show();
                lbFnameValidation.Text = "First name set!";
                lbFnameValidation.ForeColor = Color.Green;

            }
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

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                lbUsernameValidation.Show();
                lbUsernameValidation.Text = "Username required.";
                lbUsernameValidation.ForeColor = Color.Red;
            }
            else if (tbUserName.Text.Length >= 5 && tbUserName.Text.Length <= 11 && tbUserName.Text.Any(char.IsDigit)
                    && tbUserName.Text.Any(char.IsUpper))
            {
                lbUsernameValidation.Show();
                lbUsernameValidation.Text = "Username set!";
                lbUsernameValidation.ForeColor = Color.Green;
            }
            else
            {
                lbUsernameValidation.Show();
                lbUsernameValidation.Text = "5-11 chars, 1 num, 1 upper.";
                lbUsernameValidation.ForeColor = Color.Red;
            }
        }


        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))  // Fixed from tbUserName.Text
            {
                lbPasswordValidation.Show();
                lbPasswordValidation.Text = "Password required.";
                lbPasswordValidation.ForeColor = Color.Red;
            }
            else if (tbPassword.Text.Length >= 8 && tbPassword.Text.Length <= 11 && tbPassword.Text.Any(char.IsDigit) &&
                tbPassword.Text.Any(char.IsLower) && tbPassword.Text.Any(char.IsUpper) &&
                tbPassword.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                lbPasswordValidation.Show();
                lbPasswordValidation.Text = "Password set!";
                lbPasswordValidation.ForeColor = Color.Green;
            }
            else
            {
                lbPasswordValidation.Show();
                lbPasswordValidation.Text = "8-11 chars, mix of num, lower, upper, symbols.";
                lbPasswordValidation.ForeColor = Color.Red;
            }
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
    }
}
