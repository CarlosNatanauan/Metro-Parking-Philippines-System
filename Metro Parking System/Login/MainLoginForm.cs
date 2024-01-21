using Metro_Parking_System.AdmNavMenu;
using Metro_Parking_System1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Parking_System.Login
{
    public partial class MainLoginForm : Form
    {
        //backup
        private frmSettings settingsForm;


        //for timer
        private DateTime lastUpdated = DateTime.MinValue;
        private bool? wasPreviouslyTrue = null;

        // Fields for sliding icon animation
        private Timer _timer;
        private bool _isTextAdmin;
        private int _iconOffset;

        private bool _isFirstClick = true;

        // Field for storing the icon
        private Bitmap _iconForSwitch;

        // to give the form round edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        [DllImport("user32.dll", EntryPoint = "SetWindowRgn")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);
        // end

        public MainLoginForm()
        {
            InitializeComponent();
            InitializeTimer();


            RefreshForm.Enabled = false;
            CheckDatabase.Enabled = true;

            // to give the form round edges
            IntPtr roundRegion = CreateRoundRectRgn(0, 0, Width, Height, 50, 50);
            SetWindowRgn(Handle, roundRegion, true);//end

            UC_InfoEmployee ucad = new UC_InfoEmployee(this);
            addUserControl(ucad);

            // Wire the custom paint event for the GUNA UI button
            btSwitch.Paint += BtSwitch_Paint;



        }

        private void InitializeTimer()
        {
            _timer = new Timer();
            _timer.Interval = 10;
            _timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _iconOffset += 10;
            int iconWidth = _iconForSwitch.Width;

            if (_iconOffset >= btSwitch.Width - iconWidth)
            {
                _timer.Stop();
                _isTextAdmin = !_isTextAdmin;
                _iconOffset = 0;
                btSwitch.Text = _isTextAdmin ? "EMPLOYEE" : "ADMIN";
            }

            btSwitch.Invalidate();
        }


        private void BtSwitch_Paint(object sender, PaintEventArgs e)
        {
            if (_timer.Enabled)
            {
                btSwitch.Text = string.Empty;
            }

            int padding = 5; // Set the desired padding value here

            // Draw the icon
            int iconWidth = _iconForSwitch.Width;
            int iconHeight = _iconForSwitch.Height;
            int iconX = _isTextAdmin ? btSwitch.Width - iconWidth - _iconOffset - padding : _iconOffset + padding;
            int iconY = (btSwitch.Height - iconHeight) / 2;
            e.Graphics.DrawImage(_iconForSwitch, iconX, iconY, iconWidth, iconHeight);
        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelUser.Controls.Clear();
            panelUser.Controls.Add(userControl);
            userControl.BringToFront();
        }


        public void ShowEmpFormAndClose()
        {
            mainForm main = new mainForm();
            main.FormClosed += (s, e) => this.Close();
            main.Show();
            this.Hide();
        }

        public void ShowAdmFormAndClose()
        {
            mainFormAdmin main = new mainFormAdmin();
            main.FormClosed += (s, e) => this.Close();
            main.Show();
            this.Hide();
        }


        

        private void btSwitch_Click(object sender, EventArgs e)
        {
               
            bool result = databaseCodes.GetShiftDetails(out var morningA, out var morningB, out var afternoonA, out var afternoonB);

            if (!result)
            {
                _isFirstClick = true;
                btSwitch.Enabled = false; // Disable the button if validation fails
                btSwitch.FillColor = ColorTranslator.FromHtml("#7D8995");
                UC_InfoAdmin ucad = new UC_InfoAdmin(this);
                addUserControl(ucad);

                // Use BeginInvoke to delay the execution of the MessageBox
                this.BeginInvoke((MethodInvoker)delegate
                {
                    MessageBox.Show(
                   "AYUSIN MO YUNG EMPLOYEE RECORDS PLEASE LANG", "HOYYYYY!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                });

                return; // Exit the method here if validation fails
            }



            if (_isFirstClick)
            {
                _isFirstClick = false;
            }

            btSwitch.Text = string.Empty;
            _timer.Start();

            if (_isTextAdmin)
            {
                btSwitch.FillColor = ColorTranslator.FromHtml("#7D8995");
                UC_InfoAdmin ucad = new UC_InfoAdmin(this);
                addUserControl(ucad);
            }
            else
            {
                btSwitch.FillColor = ColorTranslator.FromHtml("#555555");
                UC_InfoEmployee ucemp = new UC_InfoEmployee(this);
                addUserControl(ucemp);
            }
        }


        private void MainLoginForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                btSwitch.PerformClick();
                btSwitch.Text = "ADMIN";

                // Get the assembly where the embedded resource is located (usually the current assembly)
                var assembly = GetType().Assembly;

                // Construct the full resource name with the namespace and folder path
                string resourceNamespace = "Metro_Parking_System.Images.ic_forSwitch.png";
                // Make sure to adjust the namespace and folder path to match the actual location of your image resource.

                // Load the image as a stream from the embedded resource
                using (Stream stream = assembly.GetManifestResourceStream(resourceNamespace))
                {
                    if (stream == null)
                    {
                        MessageBox.Show("Error loading image: Resource not found.");
                        return;
                    }

                    // Create the Bitmap object from the stream
                    _iconForSwitch = new Bitmap(stream);
                }
            }
            catch (Exception ex)
            {
                // Log or display the error message to help with troubleshooting
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }



        private void MainLoginForm_Shown(object sender, EventArgs e)
        {
            //this.ActiveControl = null;
        }

        private void RefreshForm_Tick(object sender, EventArgs e)
        {
            DateTime? timestampNullable = databaseCodes.GetRefreshTimestampAdmin();
            if (timestampNullable.HasValue && timestampNullable.Value > lastUpdated)
            {
                // refresh method
                bool result = databaseCodes.GetShiftDetails(out var morningA, out var morningB, out var afternoonA, out var afternoonB);

                if (!result)
                {//show admin
                    //_isFirstClick = true;
                    btSwitch.Hide();
                    UC_InfoAdmin ucad = new UC_InfoAdmin(this);
                    addUserControl(ucad);

                    // Use BeginInvoke to delay the execution of the MessageBox
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        MessageBox.Show(
                       "AYUSIN MO YUNG EMPLOYEE RECORDS PLEASE LANG", "HOYYYYY!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    });

                }
                else {
                    //show employee
                    //_isFirstClick = false;
                    btSwitch.Show();
                    //btSwitch.PerformClick();
                    btSwitch.Text = "EMPLOYEE";
                    btSwitch.Enabled = true;
                    btSwitch.FillColor = ColorTranslator.FromHtml("#555555");
                    UC_InfoEmployee ucad = new UC_InfoEmployee(this);
                    addUserControl(ucad);
                }

                lastUpdated = timestampNullable.Value;
                RefreshForm.Enabled = false; // Disable further refresh until needed
            }
        }

        private void CheckDatabase_Tick(object sender, EventArgs e)
        {


            bool result = databaseCodes.GetShiftDetails(out var morningA, out var morningB, out var afternoonA, out var afternoonB);
            // If this is the first time checking, set the initial state
            if (wasPreviouslyTrue == null)
            {
                wasPreviouslyTrue = result;
                return;
            }

            // If the state has changed since the last check
            if (result != wasPreviouslyTrue)
            {
                // Explicitly check the state transition: from true to false or from false to true
                if ((result && !wasPreviouslyTrue.Value) || (!result && wasPreviouslyTrue.Value))
                {
                    RefreshForm.Enabled = true;
                    DateTime newTimestamp = DateTime.Now;
                    try
                    {
                        databaseCodes.UpdateRefreshTimestampAdmin(newTimestamp);
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Handle the exception here, e.g., log the error or notify the user
                        Console.WriteLine(ex.Message);
                        // Optionally, re-enable any disabled UI elements or retry the operation
                    }

                }
                wasPreviouslyTrue = result; // Update the state
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Display a message box with Yes and No buttons and a Question icon
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the system?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the Yes button was pressed
            if (dialogResult == DialogResult.Yes)
            {
                // Close the form
                this.Close();
            }
            // If the No button was pressed, nothing happens and the form remains open
        }




    }
}
