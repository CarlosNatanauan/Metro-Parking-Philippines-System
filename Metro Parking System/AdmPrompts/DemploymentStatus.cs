using Metro_Parking_System.AdmData;
using Metro_Parking_System.AdmUserControls;
using Metro_Parking_System1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Metro_Parking_System.AdmPrompts
{
    public partial class DemploymentStatus : Form
    {
        public event EventHandler SubstitutedEmployeeListChanged;
        public event EventHandler FormClosedAndDataChanged;

        public DemploymentStatus()
        {
            InitializeComponent();
        }

        private void DemploymentStatus_Load(object sender, EventArgs e)
        {
            // Load the state from the database.
            var state = databaseCodes.LoadSubstituteState();
            UC_Emp_Management.SubstitutedEmployeeId1 = state.Item1;
            UC_Emp_Management.SubstitutedEmployeeId2 = state.Item2;
            UC_Emp_Management.SubstituteEmployeeId1 = state.Item3;
            UC_Emp_Management.SubstituteEmployeeId2 = state.Item4;
            UC_Emp_Management.isSubstitute1Deployed = state.Item5;
            UC_Emp_Management.isSubstitute2Deployed = state.Item6;

            PopulateSubstitutedEmployeeList();
        }

        private void PopulateSubstitutedEmployeeList()
        {
            List<Employee> substitutedEmployees = new List<Employee>();

            if (UC_Emp_Management.SubstitutedEmployeeId1 != 0)
            {
                Employee emp1 = databaseCodes.GetEmployeeById(UC_Emp_Management.SubstitutedEmployeeId1);
                if (emp1 != null)
                {
                    substitutedEmployees.Add(emp1);
                }
            }

            if (UC_Emp_Management.SubstitutedEmployeeId2 != 0)
            {
                Employee emp2 = databaseCodes.GetEmployeeById(UC_Emp_Management.SubstitutedEmployeeId2);
                if (emp2 != null)
                {
                    substitutedEmployees.Add(emp2);
                }
            }

            cbSubstitutedEmployeeList.DataSource = substitutedEmployees;
            cbSubstitutedEmployeeList.DisplayMember = "FullName";
            cbSubstitutedEmployeeList.ValueMember = "empID";

            activeSubCount.Text = substitutedEmployees.Count.ToString();

            // Close the form if the list is empty
            // Invoke the event if list count decreases.
            SubstitutedEmployeeListChanged?.Invoke(this, EventArgs.Empty);

            // If the list becomes empty, you can also close the form.
            if (substitutedEmployees.Count == 0)
            {
                // Optionally, invoke the event one more time before closing
                SubstitutedEmployeeListChanged?.Invoke(this, EventArgs.Empty);

                // Close the form
                this.Close();
            }
        }



        private void btDeploy_Click(object sender, EventArgs e)
        {
            if (cbSubstitutedEmployeeList.SelectedValue == null)
            {
                MessageBox.Show("Please select an employee to revert.");
                return;
            }

            int substitutedEmpId = (int)cbSubstitutedEmployeeList.SelectedValue;
            int substituteEmpId = 0;

            if (UC_Emp_Management.SubstitutedEmployeeId1 == substitutedEmpId)
            {
                substituteEmpId = UC_Emp_Management.SubstituteEmployeeId1;
            }
            else if (UC_Emp_Management.SubstitutedEmployeeId2 == substitutedEmpId)
            {
                substituteEmpId = UC_Emp_Management.SubstituteEmployeeId2;
            }
            else
            {
                MessageBox.Show("No matching deployed substitute found for the selected employee.");
                return;
            }

            // Assuming you have the SwapEmployeeDetails function implemented in databaseCodes
            databaseCodes.SwapEmployeeDetails(substitutedEmpId, substituteEmpId);


            UC_Emp_Management ucEmpManagement = new UC_Emp_Management();
            // Update status back to not deployed
            ucEmpManagement.SetSubstituteDeployedStatus(substituteEmpId, false);

            // Clear the stored IDs
            if (UC_Emp_Management.SubstitutedEmployeeId1 == substitutedEmpId)
            {
                UC_Emp_Management.SubstitutedEmployeeId1 = 0;
                UC_Emp_Management.SubstituteEmployeeId1 = 0;
            }
            else if (UC_Emp_Management.SubstitutedEmployeeId2 == substitutedEmpId)
            {
                UC_Emp_Management.SubstitutedEmployeeId2 = 0;
                UC_Emp_Management.SubstituteEmployeeId2 = 0;
            }

            MessageBox.Show("Employee has been returned to their regular shift and schedule.");

            // Refresh the ComboBox to reflect current state
            PopulateSubstitutedEmployeeList();

            databaseCodes.SaveSubstituteState(
            UC_Emp_Management.SubstitutedEmployeeId1, UC_Emp_Management.SubstitutedEmployeeId2,
            UC_Emp_Management.SubstituteEmployeeId1, UC_Emp_Management.SubstituteEmployeeId2,
            UC_Emp_Management.isSubstitute1Deployed, UC_Emp_Management.isSubstitute2Deployed
);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormClosedAndDataChanged?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void cbSubstitutedEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeSubCount.Text = (cbSubstitutedEmployeeList.DataSource as List<Employee>)?.Count.ToString() ?? "0";
        }


    }
}
