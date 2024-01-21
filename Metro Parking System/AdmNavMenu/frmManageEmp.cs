using Metro_Parking_System.AdmUserControls;
using Metro_Parking_System.UserControls;
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

namespace Metro_Parking_System.AdmNavMenu
{
    public partial class frmManageEmp : Form
    {

        private mainFormAdmin MainFormAdmin { get; set; }
        public frmManageEmp(mainFormAdmin mainForm)
        {
            InitializeComponent();
            this.MainFormAdmin = mainForm;
            UC_Emp_Management uc = new UC_Emp_Management();
            addUserControl(uc);
        }

        private void btCloseManEmp_Click(object sender, EventArgs e)
        {
            MainFormAdmin.gunaBTmanageEmployee.Enabled = true;  // Enable the button when this form is closed
            MainFormAdmin.CloseActiveForm();
            this.Close();
        }

        private void realTime_Tick(object sender, EventArgs e)
        {//para gumalaw sya
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void frmManageEmp_Load(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            realTime.Interval = 1000;
            realTime.Enabled = true;
            realTime.Tick += new EventHandler(realTime_Tick);
        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btEmpMan_Click(object sender, EventArgs e)
        {
            UC_Emp_Management uc = new UC_Emp_Management();
            addUserControl(uc);
        }

        private bool isBackupInProgress = false;







        private void btShiftSum_Click(object sender, EventArgs e)
        {


            bool result = databaseCodes.GetShiftDetails(out var morningA, out var morningB, out var afternoonA, out var afternoonB);

            if (result) // Here we use the 'result' variable from above
            {
                UC_Shift_Summary success = new UC_Shift_Summary();
                success.PopulateShiftDetails(morningA, morningB, afternoonA, afternoonB);
                addUserControl(success);
            }
            else
            {
                UC_Error_Message error = new UC_Error_Message();
                addUserControl(error);
            }
        }



    }
}
