using Guna.UI2.WinForms;
using Metro_Parking_System.AdmData;
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
    public partial class FixSchedAndJob : Form
    {
        public event EventHandler ChangesSaved;
        Dictionary<int, (ComboBox cbShift, ComboBox cbJobDescription)> employeeComboBoxMap = new Dictionary<int, (ComboBox, ComboBox)>();
        private bool skipFirstValidation = true;
        public FixSchedAndJob()
        {
            InitializeComponent();
        }

        private void FixSchedAndJob_Load(object sender, EventArgs e)
        {
            List<Employee> employees = databaseCodes.FetchEmployeesWithNonNullJobDescAndShift();

            for (int i = 0; i < employees.Count; i++)
            {
                if (i > 3) break;

                Employee emp = employees[i];
                string fullName;

                if (string.IsNullOrEmpty(emp.empMiddleName))
                {
                    fullName = $"{emp.empLastName}, {emp.empFirstName}";
                }
                else
                {
                    fullName = $"{emp.empLastName}, {emp.empFirstName} {emp.empMiddleName[0]}.";
                }

                string jobDesc = emp.jobDesc;
                string shift = emp.shift;

                Guna2HtmlLabel lblEmp = this.Controls.Find($"lbEmp{i + 1}", true).FirstOrDefault() as Guna2HtmlLabel;
                ComboBox cbShift = this.Controls.Find($"cbShift{i + 1}", true).FirstOrDefault() as ComboBox;
                ComboBox cbJobDescription = this.Controls.Find($"cbJobDescription{i + 1}", true).FirstOrDefault() as ComboBox;

                if (lblEmp != null)
                {
                    lblEmp.Text = fullName;
                }

                if (cbShift != null)
                {
                    cbShift.SelectedIndex = shift == "Morning" ? 0 : 1;
                }

                if (cbJobDescription != null)
                {
                    cbJobDescription.SelectedIndex = jobDesc == "Entry Lead" ? 0 : 1;
                }

                // Map the employee ID to their respective combo boxes
                employeeComboBoxMap[emp.empID] = (cbShift, cbJobDescription);
            }
            ValidateShiftAndJob();
            skipFirstValidation = false;
        }


        private bool ValidateShiftAndJob()
        {
            Dictionary<string, int> shiftJobCombinationCount = new Dictionary<string, int>();
            List<Employee> employeesToUpdate = new List<Employee>();

            foreach (var entry in employeeComboBoxMap)
            {
                int empId = entry.Key;
                var (cbShift, cbJobDescription) = entry.Value;

                string shift = cbShift.SelectedIndex == 0 ? "Morning" : "Afternoon";
                string jobDesc = cbJobDescription.SelectedIndex == 0 ? "Entry Lead" : "Exit Lead";
                string shiftJobCombination = $"{shift}:{jobDesc}";

                employeesToUpdate.Add(new Employee { empID = empId, shift = shift, jobDesc = jobDesc });

                if (shiftJobCombinationCount.ContainsKey(shiftJobCombination))
                {
                    shiftJobCombinationCount[shiftJobCombination]++;
                }
                else
                {
                    shiftJobCombinationCount[shiftJobCombination] = 1;
                }
            }

            bool properlySet = shiftJobCombinationCount.All(kvp => kvp.Value == 1) && shiftJobCombinationCount.Count == 4;

            if (properlySet)
            {
                lbStatus.Text = "PROPERLY SET";
                lbStatus.ForeColor = Color.Green;
            }
            else
            {
                lbStatus.Text = "FIX NEEDED";
                lbStatus.ForeColor = Color.Red;
            }

            return properlySet;
        }





        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbEmp1_Click(object sender, EventArgs e)
        {

        }

        private void lbEmp2_Click(object sender, EventArgs e)
        {

        }

        private void lbEmp3_Click(object sender, EventArgs e)
        {

        }

        private void lbEmp4_Click(object sender, EventArgs e)
        {

        }

        private void cbShift1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateShiftAndJob();
        }

        private void cbShift2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateShiftAndJob();
        }

        private void cbShift3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateShiftAndJob();
        }

        private void cbShift4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateShiftAndJob();
        }

        private void cbJobDescription1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateShiftAndJob();
        }

        private void cbJobDescription2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateShiftAndJob();
        }

        private void cbJobDescription3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateShiftAndJob();
        }

        private void cbJobDescription4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateShiftAndJob();
        }

        private void lbStatus_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool isProperlySet = ValidateShiftAndJob();

            if (isProperlySet)
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to change the job and shift of the employees?", "Confirm", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {
                    foreach (var entry in employeeComboBoxMap)
                    {
                        int empId = entry.Key;
                        var (cbShift, cbJobDescription) = entry.Value;

                        string shift = cbShift.SelectedIndex == 0 ? "Morning" : "Afternoon";
                        string jobDesc = cbJobDescription.SelectedIndex == 0 ? "Entry Lead" : "Exit Lead";

                        databaseCodes.UpdateEmployeeShiftAndJob(empId, shift, jobDesc);
                    }

                    MessageBox.Show("Changes saved successfully!");
                    this.Close();
                }
                ChangesSaved?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("The job description and shift schedule need to be properly set to avoid errors.", "Warning", MessageBoxButtons.OK);
            }
            ChangesSaved?.Invoke(this, EventArgs.Empty);
        }
    }
}
