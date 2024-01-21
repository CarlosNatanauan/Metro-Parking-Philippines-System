using Metro_Parking_System.AdmPrompts;
using Metro_Parking_System1;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Parking_System.AdmNavMenu
{
    public partial class frmSettings : Form
    { 
        private mainFormAdmin MainFormAdmin { get; set; }
        private string originalUsername;
        private string originalPassword;

        public frmSettings(mainFormAdmin mainForm)
        {
            InitializeComponent();
            this.MainFormAdmin = mainForm;

            databaseCodes.CredentialsUpdated += UpdateCredentials;

            // Add these lines
            dtpMonthly.Format = DateTimePickerFormat.Custom;
            this.dtpMonthly.Value = DateTime.Now;
            dtpMonthly.CustomFormat = "MMMM, yyyy";


        }

        private void OpenAdminInformation()
        {
            AdminInformation adminInfoForm = new AdminInformation();
            // Subscribe to the CredentialsUpdated event
            adminInfoForm.CredentialsUpdated += UpdateCredentials;
            adminInfoForm.ShowDialog();

            UpdateCredentials();
        }



        private void frmSettings_Load(object sender, EventArgs e)
        {
            // Fetch username and password from database         
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            realTime.Interval = 1000;
            realTime.Enabled = true;
            realTime.Tick += new EventHandler(realTime_Tick);
            UpdateCredentials();
        }

        private void realTime_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btCloseSettings_Click_1(object sender, EventArgs e)
        {
            MainFormAdmin.gunaBTadminSettings.Enabled = true;  // Enable the button when this form is closed
            MainFormAdmin.CloseActiveForm();
            this.Close();
        }







        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UpdateCredentials()
        {
            // Fetch the new credentials from the database
            (string updatedUsername, string updatedPassword, string updatedFname, string updatedMname, string updatedLname) = databaseCodes.FetchAdminCredentials();

            originalUsername = updatedUsername;
            originalPassword = updatedPassword;

            // Update labels if needed
            lbUserName.Text = new string('•', originalUsername.Length);
            lbPassword.Text = new string('•', originalPassword.Length);

            // Update additional information
            lbAdminFname.Text = updatedFname;
            lbAdminMname.Text = updatedMname;
            lbAdminLname.Text = updatedLname;

            // Refresh UI controls
            lbUserName.Refresh();
            lbPassword.Refresh();
            lbAdminFname.Refresh();
            lbAdminMname.Refresh();
            lbAdminLname.Refresh();
        }


        private void UpdateRestoreProgress(int percentDone)
        {
            if (InvokeRequired) // Check if we are on a different thread
            {
                // If so, we call this same method on the UI thread
                Invoke(new Action<int>(UpdateRestoreProgress), percentDone);
            }
            else
            {
                // Otherwise, we can update the progress bar directly
                progressBar.Value = percentDone;
                // Update label or any other UI elements here if needed
            }
        }







        private void btUpdate_Click(object sender, EventArgs e)
        {
            OpenAdminInformation();
        }

        private void btShowUser_MouseDown(object sender, MouseEventArgs e)
        {
            lbUserName.Text = originalUsername;
        }

        private void btShowUser_MouseUp(object sender, MouseEventArgs e)
        {
            lbUserName.Text = new string('•', originalUsername.Length);
        }

        private void btShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            lbPassword.Text = originalPassword;
        }

        private void btShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            lbPassword.Text = new string('•', originalPassword.Length);
        }



        private void UpdateBackupProgress(int percentDone)
        {
            if (InvokeRequired) // Check if we are on a different thread
            {
                // If so, we call this same method on the UI thread
                Invoke(new Action<int>(UpdateBackupProgress), percentDone);
            }
            else
            {
                // Otherwise, we can update the progress bar directly
                progressBar.Value = percentDone;
            }
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Backup Files (*.bak)|*.bak";
            saveFileDialog.Title = "Where do you want to save the backup?";
            saveFileDialog.FileName = "Metro_Parking.bak";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupPath = saveFileDialog.FileName;
                txtBackupPath.Text = backupPath;

                // Start the backup operation on a new thread
                Task.Run(() =>
                {
                    try
                    {
                        databaseCodes.BackupDatabase(backupPath, UpdateBackupProgress);

                        // After backup is done, inform the user and reset the backup progress
                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show("Backup completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            progressBar.Value = 0;

                        }));
                    }
                    catch (Exception ex)
                    {
                        // If there's an error, show it and reset the backup progress
                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show($"Failed to backup the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }));
                    }
                });
            }

            // Clear the FileName so that it does not persist for the next time the dialog is opened
            saveFileDialog.FileName = "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Backup Files (*.bak)|*.bak";
            openFileDialog.Title = "Select a backup file to restore";
            // Set the default file name
            openFileDialog.FileName = "Metro_Parking.bak";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txtRestorePath.Text = filePath;
            }
            // Clear the FileName so that it does not persist for the next time the dialog is opened
            openFileDialog.FileName = "";
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string restorePath = txtRestorePath.Text;
            if (!string.IsNullOrEmpty(restorePath))
            {
                // Disable the restore button to prevent multiple clicks
                btnRestore.Enabled = false;
                lblStatus.Text = "Please wait, restoring database may take a while..."; // Set the status text
                lblStatus.Show();

                // Start the restore operation on a new thread
                Task.Run(() =>
                {
                    try
                    {
                        databaseCodes.RestoreDatabase(restorePath, UpdateRestoreProgress);

                        // We need to marshal the call to the UI thread
                        this.Invoke(new Action(() =>
                        {
                            lblStatus.Hide();
                            MessageBox.Show("Database restored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            progressBar.Value = 0;
                        }));
                    }
                    catch (Exception ex)
                    {
                        // We need to marshal the call to the UI thread
                        this.Invoke(new Action(() =>
                        {
                            lblStatus.Hide();
                            MessageBox.Show($"Failed to restore the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                    }
                    finally
                    {
                        // Re-enable the restore button whether the restore was successful or failed
                        this.Invoke(new Action(() => {
                            btnRestore.Enabled = true;  // Re-enable the restore button
                            progressBar.Value = 0;
                        }));
                    }
                });
            }
            else
            {
                MessageBox.Show("Please select a file to restore.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpMonthly_ValueChanged(object sender, EventArgs e)
        {
            databaseCodes dbCodes = new databaseCodes();
            int year = dtpMonthly.Value.Year;
            int month = dtpMonthly.Value.Month;

            DataTable data = dbCodes.GetAdminLogsByMonthAndYear(year, month);
            dgvAdminLog.DataSource = data;
        }

        private void dgvAdminLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
