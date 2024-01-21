using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Parking_System.EmpPrompts
{
    public partial class EditValue : Form
    {
        public decimal ValueToEdit { get; set; }
        public string Description { get; set; }  // Descriptive string for the field
        public decimal MinimumValue { get; set; }
        public decimal MaximumValue { get; set; }

        public EditValue(decimal value, string description, decimal minimumValue, decimal maximumValue)
        {
            InitializeComponent();
            ValueToEdit = value;
            Description = description;
            MinimumValue = minimumValue;
            MaximumValue = maximumValue; // Set the maximum value   

            textBoxInput.Text = ValueToEdit.ToString("0.00");
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            decimal enteredValue;

            // Check if the input is a valid decimal number
            if (!decimal.TryParse(textBoxInput.Text, out enteredValue))
            {
                MessageBox.Show("Please enter a valid number.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the entered value is within the specified min-max range
            if (enteredValue < MinimumValue || enteredValue > MaximumValue)
            {
                MessageBox.Show($"The value for \"{Description}\" must be between ₱{MinimumValue} and ₱{MaximumValue}.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ValueToEdit = enteredValue;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            decimal enteredValue;

            // Check if the input is a valid decimal number and within the specified min-max range
            if (!decimal.TryParse(textBoxInput.Text, out enteredValue) ||
                enteredValue < MinimumValue || enteredValue > MaximumValue)
            {
                textBoxInput.BackColor = Color.LightCoral; // Color to indicate error
            }
            else
            {
                textBoxInput.BackColor = Color.White; // Resetting to normal color when input is valid
            }
        }

        private void EditValue_Load(object sender, EventArgs e)
        {

        }
    }



  

}
