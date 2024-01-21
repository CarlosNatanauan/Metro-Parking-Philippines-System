using System;
using System.Windows.Forms;
using System.Net;
using Metro_Parking_System.Login;
using System.Runtime.InteropServices;

namespace Metro_Parking_System.LoadingPage
{
    public partial class loadingPage : Form
    {
        private int tickCount = 0;

        public loadingPage()
        {
            InitializeComponent();
        }

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



        private void LoadingPage_Load(object sender, EventArgs e)
        {
            // to give the form round edges
            IntPtr roundRegion = CreateRoundRectRgn(0, 0, Width, Height, 40, 40);
            SetWindowRgn(Handle, roundRegion, true);//end

            // Start the progress bar and wait for 5 seconds
            Timer timer = new Timer();
            timer.Interval = 50; // Update the progress every 50ms
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            tickCount++;
            pbIpAddress.Value++;

            // Update the status label based on the tickCount
            if (tickCount % 20 == 0) // Change status every ~1 second
            {
                lblStatus.Text = GetStatusMessage(tickCount / 20);
            }

            if (pbIpAddress.Value >= pbIpAddress.Maximum)
            {
                Timer timer = sender as Timer;
                timer.Stop();
                lblStatus.Text = "Done. Launching application...";

                // Start a second timer to wait before closing the loading page
                Timer closeTimer = new Timer();
                closeTimer.Interval = 2000; // 2 seconds delay
                closeTimer.Tick += (s, args) =>
                {
                    closeTimer.Stop(); // Stop the closeTimer

                    // Just close the loading page. The main form will be shown after this form is closed in Main().
                    this.Invoke(new Action(() =>
                    {
                        this.Close();
                    }));
                };
                closeTimer.Start();
            }
        }


        private string GetStatusMessage(int statusStep)
        {
            // You can customize this method to return various status messages based on the current step
            switch (statusStep)
            {
                case 1:
                    return "Initializing...";
                case 2:
                    return "Loading configurations...";
                case 3:
                    return "Establishing database connection...";
                // Add more cases as needed for different statuses
                default:
                    return "Please wait...";
            }
        }



    }
}
