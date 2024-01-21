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
    public partial class UC_InfoEmployee : UserControl
    {
        private MainLoginForm parentForm;

        public delegate void EmployeeLoginHandler(int employeeId);
        public event EmployeeLoginHandler OnEmployeeLogin;

        private Dictionary<string, int> failedLoginAttempts = new Dictionary<string, int>();
        private string currentUserOnCooldown;



        public UC_InfoEmployee(MainLoginForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            cooldownTimer.Interval = 1000; // 1 second
            cooldownTimer.Tick += CooldownTimer_Tick;
        }


        private void UC_InfoEmployee_Load(object sender, EventArgs e)
        {

        }


        private bool IsLoginAllowedForShift(string shift)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            TimeSpan startMorningShift = new TimeSpan(8, 0, 0); // 8:00 AM
            TimeSpan endMorningShift = new TimeSpan(14, 30, 0); // 2:30 PM
            TimeSpan startAfternoonShift = new TimeSpan(14, 30, 0); // 2:30 PM
            TimeSpan endAfternoonShift = new TimeSpan(21, 0, 0); // 9:00 PM

            if (shift == "Morning")
            {
                return currentTime >= startMorningShift && currentTime <= endMorningShift;
            }
            else if (shift == "Afternoon")
            {
                return currentTime >= startAfternoonShift && currentTime <= endAfternoonShift;
            }

            // If shift is not specified or doesn't match "Morning" or "Afternoon", default to false
            return false;
        }



        private void btLoginEmp_Click(object sender, EventArgs e)
        {
            string inputUsername = tbEmpUser.Text;
            string inputPassword = tbEmpPass.Text;

            // Check if user is currently on cooldown
            if (currentUserOnCooldown == inputUsername)
            {
                MessageBox.Show("Please wait for the cooldown period to end.", "Cooldown Active", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            databaseCodes dbCodes = new databaseCodes();
            int? employeeId = dbCodes.VerifyEmployeeCredentials(inputUsername, inputPassword);

            // Check if username is valid (exists in the database)
            bool isUsernameValid = dbCodes.IsUsernameValid(inputUsername);

            if (employeeId.HasValue)
            {
                // Check the shift time for the user
                string userShift = dbCodes.GetUserShift(inputUsername);
                if (IsLoginAllowedForShift(userShift))
                {
                    // Reset failed attempts on successful login
                    failedLoginAttempts[inputUsername] = 0;
                    mainForm.LoggedInEmployeeId = employeeId.Value;
                    parentForm.ShowEmpFormAndClose();
                }
                else
                {
                    MessageBox.Show("Login not allowed at this time for your shift.", "Login Restricted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                if (isUsernameValid)
                {
                    if (!failedLoginAttempts.ContainsKey(inputUsername))
                    {
                        failedLoginAttempts[inputUsername] = 0;
                    }

                    failedLoginAttempts[inputUsername]++;
                    if (failedLoginAttempts[inputUsername] >= 3)
                    {
                        // Show message before starting cooldown
                        MessageBox.Show("Due to multiple incorrect password attempts, you will be temporarily unable to log in for 1 minute.", "Login Temporarily Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Start cooldown
                        currentUserOnCooldown = inputUsername;
                        cooldownTimer.Start();
                        lbPassIncorrect.Text = "Locked: 1-min cooldown after 3 attempts -";
                        lbCooldown.Text = "01:00"; // Initialize with 1 minute
                        lbPassIncorrect.Visible = true;
                        lbCooldown.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }






        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                tbEmpPass.PasswordChar = '\0'; // Show password
            }
            else
            {
                tbEmpPass.PasswordChar = '●'; // Hide password
            }
        }

        private void CooldownTimer_Tick(object sender, EventArgs e)
        {
            if (lbCooldown.Text.Length >= 5 && lbCooldown.Text.Contains(":"))
            {
                int remainingMinutes = int.Parse(lbCooldown.Text.Substring(0, 2));
                int remainingSeconds = int.Parse(lbCooldown.Text.Substring(3));
                int remainingTime = remainingMinutes * 60 + remainingSeconds - 1;

                if (remainingTime <= 0)
                {
                    cooldownTimer.Stop();

                    if (currentUserOnCooldown != null && failedLoginAttempts.ContainsKey(currentUserOnCooldown))
                    {
                        failedLoginAttempts[currentUserOnCooldown] = 0;
                        currentUserOnCooldown = null;
                    }

                    lbPassIncorrect.Visible = false;
                    lbCooldown.Visible = false;
                }
                else
                {
                    lbCooldown.Text = $"{remainingTime / 60:D2}:{remainingTime % 60:D2}";
                }
            }
        }

        private void tbEmpUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
