using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Parking_System.Prompt
{
    public partial class UpdatePlate : Form
    {
        public UpdatePlate()
        {
            InitializeComponent();
        }

        public string newPlateNumber
        {
            get { return textBoxInput.Text; }
            set { textBoxInput.Text = value; }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
