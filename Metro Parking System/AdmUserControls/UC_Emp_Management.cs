using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Metro_Parking_System.AdmData;
using Metro_Parking_System.AdmPrompts;
using Metro_Parking_System.Login;
using Metro_Parking_System1;

namespace Metro_Parking_System.AdmUserControls
{
    public partial class UC_Emp_Management : UserControl
    {
        private bool isUsernameShown = false;
        private bool isPasswordShown = false;


        public static int SubstitutedEmployeeId1 { get; set; }
        public static int SubstitutedEmployeeId2 { get; set; }
        public static int SubstituteEmployeeId1 { get; set; }
        public static int SubstituteEmployeeId2 { get; set; }

        public static bool isSubstitute1Deployed = false;
        public static bool isSubstitute2Deployed = false;



        public UC_Emp_Management()
        {
            InitializeComponent();

            CheckDatabase.Enabled = true;
            UpdateDeployButtonStatus();

            //btFixShiftJob.Enabled = false;
            //cbEmployeeSelector.SelectedIndexChanged += new EventHandler(cbEmployeeSelector_SelectedIndexChanged);

        }


        public static void SaveStateToDatabase()
        {
            databaseCodes.SaveSubstituteState(
                SubstitutedEmployeeId1, SubstitutedEmployeeId2,
                SubstituteEmployeeId1, SubstituteEmployeeId2,
                isSubstitute1Deployed, isSubstitute2Deployed
            );
        }



        private void cbEmployeeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmployeeInfo();

            string selectedText = cbEmployeeSelector.SelectedItem?.ToString() ?? "";

            if (selectedText == "SUBSTITUTE 1")
            {
                btDeployeSub.Enabled = !isSubstitute1Deployed;
            }
            else if (selectedText == "SUBSTITUTE 2")
            {
                btDeployeSub.Enabled = !isSubstitute2Deployed;
            }
            else
            {
                btDeployeSub.Enabled = false;
            }
        }


        private void btUpdate_Click(object sender, EventArgs e)
        {
            int selectedEmployeeId = cbEmployeeSelector.SelectedIndex + 1;
            Employee emp = databaseCodes.GetEmployeeById(selectedEmployeeId);

            // Pass the selected employee data to the UpdateProfile form
            UpdateProfile updateForm = new UpdateProfile(emp);

            // Subscribe to the event
            updateForm.OnUpdateSuccess += UpdateForm_OnUpdateSuccess;

            updateForm.Show();
        }

        private void UpdateForm_OnUpdateSuccess(object sender, EventArgs e)
        {
            // Reload the employee information
            LoadEmployeeInfo();
        }

        private void LoadEmployeeInfo()
        {
            int selectedEmployeeId = cbEmployeeSelector.SelectedIndex + 1;
            Employee emp = databaseCodes.GetEmployeeById(selectedEmployeeId);

            if (selectedEmployeeId == 5 || selectedEmployeeId == 6)
            {
                btDeployeSub.Enabled = true;
            }
            else
            {
                btDeployeSub.Enabled = false;
            }

            // Check the state of the show/hide flags to determine how to display the text
            lbUserName.Text = isUsernameShown && emp.empUser != null ? emp.empUser : new string('•', emp.empUser?.Length ?? 0);
            lbPassword.Text = isPasswordShown && emp.empPass != null ? emp.empPass : new string('•', emp.empPass?.Length ?? 0);

            lbFname.Text = emp.empFirstName ?? "N/A";
            lbMname.Text = emp.empMiddleName ?? "N/A";
            lbLname.Text = emp.empLastName ?? "N/A";
            lbJobdesc.Text = emp.jobDesc ?? "N/A";
            lbShift.Text = emp.shift ?? "N/A";

            switch (emp.shift)
            {
                case "Morning":
                    lbTimeStart.Text = "08:00 AM";
                    lbTimeEnd.Text = "02:30 PM";
                    break;
                case "Afternoon":
                    lbTimeStart.Text = "02:30 PM";
                    lbTimeEnd.Text = "09:00 PM";
                    break;
                case null: // Handling the null case
                case "N/A":
                    lbTimeStart.Text = "00:00 NA";
                    lbTimeEnd.Text = "00:00 NA";
                    break;
                default:
                    lbTimeStart.Text = "Unknown";
                    lbTimeEnd.Text = "Unknown";
                    break;
            }

            if (emp.empImg != null)
            {
                using (MemoryStream ms = new MemoryStream(emp.empImg))
                {
                    EmpShowPic.Image = Image.FromStream(ms);
                }
            }
            else
            {
                EmpShowPic.Image = null; // Or set a default image
                //MessageBox.Show("No Image Available");
            }
        }

        private void UC_Emp_Management_Load(object sender, EventArgs e)
        {
            cbEmployeeSelector.SelectedIndex = 0; // Set the first item in ComboBox as selected
            LoadEmployeeInfo(); // Call a method to load the selected employee's info

            //CheckDatabase.Enabled = true;

            var state = databaseCodes.LoadSubstituteState();
            SubstitutedEmployeeId1 = state.Item1;
            SubstitutedEmployeeId2 = state.Item2;
            SubstituteEmployeeId1 = state.Item3;
            SubstituteEmployeeId2 = state.Item4;
            isSubstitute1Deployed = state.Item5;
            isSubstitute2Deployed = state.Item6;

            // Update the buttons accordingly
            UpdateDeployButtonStatus();
        }


        private void btShowUser_MouseUp(object sender, MouseEventArgs e)
        {
            int selectedEmployeeId = cbEmployeeSelector.SelectedIndex + 1;
            Employee emp = databaseCodes.GetEmployeeById(selectedEmployeeId);

            lbUserName.Text = emp.empUser != null ? new string('•', emp.empUser.Length) :""; // Hide with bullets or show N/A
        }

        private void btShowUser_MouseDown(object sender, MouseEventArgs e)
        {
            int selectedEmployeeId = cbEmployeeSelector.SelectedIndex + 1;
            Employee emp = databaseCodes.GetEmployeeById(selectedEmployeeId);

            lbUserName.Text = emp.empUser ?? ""; // Show actual username or N/A
        }




        private void btShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            int selectedEmployeeId = cbEmployeeSelector.SelectedIndex + 1;
            Employee emp = databaseCodes.GetEmployeeById(selectedEmployeeId);

            lbPassword.Text = new string('•', emp.empPass?.Length ?? 0); // Hide with bullets
        }

        private void btShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            int selectedEmployeeId = cbEmployeeSelector.SelectedIndex + 1;
            Employee emp = databaseCodes.GetEmployeeById(selectedEmployeeId);

            lbPassword.Text = emp.empPass ?? string.Empty; // Show actual password or empty if null
        }


        private void btReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to reset the selected employee's information? This action cannot be undone.",
                "WARNING",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.OK)
            {
                int selectedEmployeeId = cbEmployeeSelector.SelectedIndex + 1;
                databaseCodes.ResetEmployeeById(selectedEmployeeId);
                LoadEmployeeInfo(); // Reload the information to reflect the changes
            }
        }



        private void btFixShiftJob_Click(object sender, EventArgs e)
        {
            FixSchedAndJob fixSchedAndJobForm = new FixSchedAndJob();  // Create a new instance of FixSchedAndJob
            fixSchedAndJobForm.ChangesSaved += FixSchedAndJobForm_ChangesSaved;  // Subscribe to the ChangesSaved event
            fixSchedAndJobForm.Show();
        }

        private void FixSchedAndJobForm_ChangesSaved(object sender, EventArgs e)
        {
            // Refresh the data here.
            LoadEmployeeInfo();
        }


        private void CheckDatabase_Tick(object sender, EventArgs e)
        {
            bool result = databaseCodes.GetShiftDetails(out var morningA, out var morningB, out var afternoonA, out var afternoonB);
            btFixShiftJob.Enabled = result;
        }


        private void RefreshForm_Tick(object sender, EventArgs e)
        {

        }

        public void SetSubstituteDeployedStatus(int empId, bool isDeployed)
        {
            if (SubstituteEmployeeId1 == empId)
            {
                isSubstitute1Deployed = isDeployed;
            }
            else if (SubstituteEmployeeId2 == empId)
            {
                isSubstitute2Deployed = isDeployed;
            }
            UpdateDeployButtonStatus(); // This will now work fine since both are non-static

            SaveStateToDatabase();

        }


        private void UpdateDeployButtonStatus()
        {
            string selectedText = cbEmployeeSelector.SelectedItem?.ToString() ?? ""; // null coalescing for safety

            if (selectedText == "SUBSTITUTE 1")
            {
                btDeployeSub.Enabled = !isSubstitute1Deployed;
            }
            else if (selectedText == "SUBSTITUTE 2")
            {
                btDeployeSub.Enabled = !isSubstitute2Deployed;
            }
            else
            {
                btDeployeSub.Enabled = false;
            }

            // Enable or Disable btDeployStats button based on whether any of the substitutes are deployed
            btDeployStats.Enabled = isSubstitute1Deployed || isSubstitute2Deployed;


            // Debugging purpose
            //MessageBox.Show($"isSubstitute1Deployed: {isSubstitute1Deployed}, isSubstitute2Deployed: {isSubstitute2Deployed}");
        }




        private void btDeployeSub_Click(object sender, EventArgs e)
        {
            int selectedEmployeeId = cbEmployeeSelector.SelectedIndex + 1;

            string selectedEmployeeText = cbEmployeeSelector.SelectedItem?.ToString() ?? "";

            // The following lines will disable the button if a substitute is already deployed.
            if ((selectedEmployeeText == "SUBSTITUTE 1" && isSubstitute1Deployed) ||
                (selectedEmployeeText == "SUBSTITUTE 2" && isSubstitute2Deployed))
            {
                btDeployeSub.Enabled = false;
                return;
            }

            Employee selectedEmployee = databaseCodes.GetEmployeeById(selectedEmployeeId);
            DeploySubstitute deploySubstitute = new DeploySubstitute(selectedEmployee);

            deploySubstitute.SubstituteDeployed += () =>
            {
                // Fixing the logic to match Substitute 1 and 2 correctly
                if (selectedEmployeeText == "SUBSTITUTE 1")
                {
                    LoadEmployeeInfo();
                    isSubstitute1Deployed = true;
                    //MessageBox.Show("Setting isSubstitute1Deployed to true");
                }
                else if (selectedEmployeeText == "SUBSTITUTE 2")
                {
                    LoadEmployeeInfo();
                    isSubstitute2Deployed = true;
                    //MessageBox.Show("Setting isSubstitute2Deployed to true");
                }
                UpdateDeployButtonStatus();
            };

            deploySubstitute.Show();
        }


        public static void AssignSubstitute(int substitutedEmployeeId, int substituteEmployeeId)
        {
            if (substituteEmployeeId == 5) // SUBSTITUTE 1
            {
                SubstitutedEmployeeId1 = substitutedEmployeeId;
                SubstituteEmployeeId1 = substituteEmployeeId;
                isSubstitute1Deployed = true;
                //MessageBox.Show($"Stored Employee ID {substitutedEmployeeId} as Substitute 1");
            }
            else if (substituteEmployeeId == 6) // SUBSTITUTE 2
            {
                SubstitutedEmployeeId2 = substitutedEmployeeId;
                SubstituteEmployeeId2 = substituteEmployeeId;
                isSubstitute2Deployed = true;
                //MessageBox.Show($"Stored Employee ID {substitutedEmployeeId} as Substitute 2");
            }
            else
            {
                //MessageBox.Show("Invalid substitute ID");
            }

            SaveStateToDatabase();
        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GroupBox3_Click(object sender, EventArgs e)
        {

        }


        private void OnSubstitutedEmployeeListChanged(object sender, EventArgs e)
        {
            // Reload the information in UC_Emp_Management
            LoadEmployeeInfo();
            UpdateDeployButtonStatus(); // Update the button's status
        }

        private void btDeployStats_Click(object sender, EventArgs e)
        {
            using (DemploymentStatus demploymentStatus = new DemploymentStatus())
            {
                demploymentStatus.SubstitutedEmployeeListChanged += OnSubstitutedEmployeeListChanged;
                demploymentStatus.ShowDialog();  // Assuming you want this to be modal
            }
        }

        private void btClearAll_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to reset all employee information? This action cannot be undone.",
                "WARNING",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.OK)
            {
                databaseCodes.ResetAllEmployees();
                LoadEmployeeInfo(); // Reload the information to reflect the changes
            }
        }



    }
}
