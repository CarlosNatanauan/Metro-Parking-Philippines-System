using Metro_Parking_System.AdmData;
using Metro_Parking_System.AdmUserControls;
using Metro_Parking_System1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Metro_Parking_System.AdmPrompts
{
    public partial class DeploySubstitute : Form
    {
        private Employee selectedEmployee;
        public event Action SubstituteDeployed;
        public event Action<int, bool> SubstituteDeployedStatusChanged;
        public event EventHandler SubstitutedEmployeeListChanged;
        public DeploySubstitute(Employee selectedEmployee)
        {
            InitializeComponent();
            this.selectedEmployee = selectedEmployee;
            LoadEmployeeInfo();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmployeeInfo();
        }

        private void LoadEmployeeInfo()
        {
            // Fetch the selected employee's ID from the ComboBox
            if (cbEmployeeSelectorDeploy.SelectedValue != null)
            {
                object selectedValue = cbEmployeeSelectorDeploy.SelectedValue;

                int selectedEmployeeId;

                // Check the type and handle accordingly
                if (selectedValue is int intValue)
                {
                    selectedEmployeeId = intValue;
                }
                else if (selectedValue is string stringValue && int.TryParse(stringValue, out int parsedValue))
                {
                    selectedEmployeeId = parsedValue;
                }
                else
                {
                    // Handle other cases as needed.
                    return;
                }

                // Fetch the employee information
                Employee emp = databaseCodes.GetEmployeeById(selectedEmployeeId);

                // Handle deployed employees
                string lastName = emp.empLastName;
                string firstName = emp.empFirstName;
                string middleInitial = emp.empMiddleName != null ? emp.empMiddleName.Substring(0, 1) : " ";

                lbFullName_regular.Text = $"{lastName}, {firstName} {middleInitial}";
                lbJobdesc.Text = emp.jobDesc ?? "N/A";
                lbShift.Text = emp.shift ?? "N/A";

                // Handle selected substitute, if any
                if (selectedEmployee != null)
                {
                    string lastName_sub = selectedEmployee.empLastName;
                    string firstName_sub = selectedEmployee.empFirstName;
                    string middleInitial_sub = selectedEmployee.empMiddleName != null ? selectedEmployee.empMiddleName.Substring(0, 1) : " ";

                    lbFullName_subs.Text = $"{lastName_sub}, {firstName_sub} {middleInitial_sub}";
                }
            }
        }


        private void PopulateEmployeeSelector()
        {
            List<Employee> employees = databaseCodes.GetEmployeesWithJobAndShift();

            // Assuming cbEmployeeSelector is the ComboBox
            cbEmployeeSelectorDeploy.DataSource = employees;
            cbEmployeeSelectorDeploy.DisplayMember = "FullName";  // Change this to the computed property
            cbEmployeeSelectorDeploy.ValueMember = "empID";  // We use ID for value for easy fetch later
        }


        private void DeploySubstitute_Load(object sender, EventArgs e)
        {
            PopulateEmployeeSelector();
            cbEmployeeSelectorDeploy.SelectedIndex = 0; // Set the first item in ComboBox as selected
            LoadEmployeeInfo();
        }

        private void btDeploy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to substitute the selected employee?",
                                                        "Warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                if (cbEmployeeSelectorDeploy.SelectedValue == null || selectedEmployee == null)
                {
                    // Handle this case, e.g., show an error message.
                    return;
                }

                int empId1 = (int)cbEmployeeSelectorDeploy.SelectedValue;
                int empId2 = selectedEmployee.empID;  // This is the ID of the Substitute.

                // Swap employee details in the database
                databaseCodes.SwapEmployeeDetails(empId1, empId2);

                // Assign the substitute using the centralized function
                UC_Emp_Management.AssignSubstitute(empId1, empId2);

                // Save state to database after assigning substitute
                databaseCodes.SaveSubstituteState(
                    UC_Emp_Management.SubstitutedEmployeeId1, UC_Emp_Management.SubstitutedEmployeeId2,
                    UC_Emp_Management.SubstituteEmployeeId1, UC_Emp_Management.SubstituteEmployeeId2,
                    UC_Emp_Management.isSubstitute1Deployed, UC_Emp_Management.isSubstitute2Deployed
                );

                // Make the substitute deployed by passing empId2 (the ID of the Substitute)
                UC_Emp_Management ucEmpManagement = new UC_Emp_Management();
                ucEmpManagement.SetSubstituteDeployedStatus(empId2, true);


                MessageBox.Show("Successfully deployed selected Substitute");
                // Optionally, refresh the UI
                LoadEmployeeInfo();

                // Invoke the event to notify that a substitute has been deployed
                SubstituteDeployed?.Invoke();
                SubstituteDeployedStatusChanged?.Invoke(empId2, true);
                // Close the DeploySubstitute form
                this.Close();
            }
        }

    }
}
