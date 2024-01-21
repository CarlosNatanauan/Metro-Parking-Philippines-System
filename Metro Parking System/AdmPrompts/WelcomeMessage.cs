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
    public partial class WelcomeMessage : Form
    {
        public WelcomeMessage()
        {
            InitializeComponent();
            UpdateDateAndDay();
            timer.Start();
        }


        private void UpdateDateAndDay()
        {
            // Set the lcCurrentDate without the day part
            lcCurrentDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            // Set the lbOnlyDay with the day part only.
            lbOnlyDay.Text = DateTime.Now.ToString("dddd");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void WelcomeMessage_Load(object sender, EventArgs e)
        {
            lbCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
