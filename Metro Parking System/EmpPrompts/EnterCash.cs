using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Metro_Parking_System.Prompt
{
    public partial class EnterCash : Form
    {

        public decimal CashEntered { get; private set; }
        public bool IsDiscountApplied { get; private set; }
        public bool IsTicketLost { get; private set; }

        private bool validationMessageShown = false;
        public bool IsPaidButtonClicked { get; private set; } = false;
        public event Action<bool, bool> RateChanged;
        private decimal parkingRate;



        public EnterCash()
        {
            InitializeComponent();
            tbCashInput.Text = parkingRate.ToString("0.00");
            tbCashInput.SelectAll();
        }

        public void SetTemporaryRate(decimal rate)
        {
            tbParkingRate.Text = $"P{rate.ToString("0.00")}";
            parkingRate = rate;  // Store the rate in a private field
            tbCashInput.Text = parkingRate.ToString("0.00");
            tbCashInput.SelectAll();
        }

        private void EnterCash_Load(object sender, EventArgs e)
        {
            tbCashInput.Focus();

        }

        private void tbCash_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbCashInput.Text, out decimal enteredValue) && enteredValue >= parkingRate)
            {
                tbCashInput.BackColor = SystemColors.Window; // Reset to default color when input is valid
            }
            else
            {
                tbCashInput.BackColor = Color.LightCoral; // Set to error color when input is invalid
            }

            validationTimer.Stop();
            validationTimer.Start();
        }

        private void tbCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string validationError = ValidateInput();
                if (validationError != null)
                {
                    MessageBox.Show(validationError, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SetCashAndCloseForm();
            }
        }

        private void btPaidEnterCash_Click(object sender, EventArgs e)
        {
            if (Tbticket.Checked && !TbVerified.Checked)
            {
                MessageBox.Show("Identity should be verified", "Verification Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (RBdiscount.Checked && string.IsNullOrWhiteSpace(btDiscCardInfo.Text))
            {
                lbCardWarning.Visible = true; // Show card warning label
                MessageBox.Show("Please enter the discount card information.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btDiscCardInfo.Focus();
                return;
            }

            string validationError = ValidateInput();
            if (validationError != null)
            {
                MessageBox.Show(validationError, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IsPaidButtonClicked = true;
            SetCashAndCloseForm();
        }

        private void SetCashAndCloseForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RBdiscount_CheckedChanged(object sender, EventArgs e)
        {
            IsDiscountApplied = RBdiscount.Checked;
            RateChanged?.Invoke(IsDiscountApplied, IsTicketLost);
            tbCashInput.Focus();
            btDiscCardInfo.Enabled = RBdiscount.Checked;
            lbCardWarning.Visible = RBdiscount.Checked && string.IsNullOrWhiteSpace(btDiscCardInfo.Text);
        }


        private void Tbticket_CheckedChanged(object sender, EventArgs e)
        {
            IsTicketLost = Tbticket.Checked;
            TbVerified.Enabled = Tbticket.Checked; // Enable TbVerified when Tbticket is checked
            lbVerificationWarning.Visible = Tbticket.Checked;
            RateChanged?.Invoke(IsDiscountApplied, IsTicketLost);
            ValidateInput();
            tbCashInput.Focus();
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private string ValidateInput()
        {
            if (!decimal.TryParse(tbCashInput.Text, out decimal cash))
            {
                return "Please enter a valid number.";
            }

            if (cash < parkingRate)
            {
                return $"You must enter at least P{parkingRate:0.00}.";
            }

            CashEntered = cash; // Update the property if the input is valid
            return null; // No error
        }


        private void validationTimer_Tick(object sender, EventArgs e)
        {
            validationTimer.Stop();
            ValidateInput();
        }

        private void tbCashInput_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbCashInput.Text, out decimal enteredValue))
            {
                if (enteredValue < parkingRate)
                {
                    tbCashInput.BackColor = Color.LightCoral;
                    lbCashWarning.Visible = true; // Show cash warning label
                }
                else
                {
                    tbCashInput.BackColor = SystemColors.Window;
                    lbCashWarning.Visible = false; // Hide cash warning label
                }
            }
            else
            {
                tbCashInput.BackColor = Color.LightCoral;
                lbCashWarning.Visible = true; // Show cash warning label
            }

            validationTimer.Stop();
            validationTimer.Start();
        }


        private void tbCashInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string validationError = ValidateInput();
                if (validationError != null)
                {
                    MessageBox.Show(validationError, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SetCashAndCloseForm();
            }
        }


        public string DiscountInfo
        {
            get { return RBdiscount.Checked && !string.IsNullOrWhiteSpace(btDiscCardInfo.Text) ? btDiscCardInfo.Text : null; }
        }


        private void btDiscCardInfo_TextChanged(object sender, EventArgs e)
        {
            lbCardWarning.Visible = string.IsNullOrWhiteSpace(btDiscCardInfo.Text);

        }

        private void TbVerified_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
