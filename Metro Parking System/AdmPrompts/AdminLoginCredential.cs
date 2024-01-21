using Metro_Parking_System.AdmNavMenu;
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
    public partial class AdminLoginCredential : Form
    {

        

        public AdminLoginCredential()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return textBoxInput.Text; }
            set { textBoxInput.Text = value; }
        }

        public string LabelText
        {
            get { return lbUsernameorpass.Text; }
            set { lbUsernameorpass.Text = value; }
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Use the instance to call UpdateCredentials
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminLoginCredential_Load(object sender, EventArgs e)
        {

        }
    }
}
