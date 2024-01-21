using Metro_Parking_System.AdmPrompts;
using Metro_Parking_System.LoadingPage;
using Metro_Parking_System.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Parking_System
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the loading page as a dialog
            loadingPage loadingForm = new loadingPage();
            loadingForm.ShowDialog();

            // After the loadingPage is closed, then run the main form.
            Application.Run(new MainLoginForm());
            //Application.Run(new mainFormAdmin());
        }
    }

}
