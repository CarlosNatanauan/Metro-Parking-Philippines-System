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
    public partial class SecurityKey : Form
    {
        public SecurityKey()
        {
            InitializeComponent();
        }

        private void tbSecurityKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string enteredKey = tbSecurityKey.Text;
            const string correctKey = "FUENSID373";

            if (enteredKey == correctKey)
            {
                this.Close(); // Close the SecurityKey form
                AdminForgetPass forgetPassForm = new AdminForgetPass();
                forgetPassForm.ShowDialog(); // Show the AdminForgetPass form
            }
            else
            {
                MessageBox.Show("Incorrect Security Key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
