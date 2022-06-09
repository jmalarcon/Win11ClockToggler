using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win11ClockToggler;

namespace Win11ClockTogglerGUI
{
    internal static class Program
    {
        const string appGuid = "200715dd-acc1-47f2-926a-4d673d405947";  //Random guid to uniquely identify this app
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
            {
                if (mutex.WaitOne(0, false))    //If there's not another instance of the app running, launch it
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Win11ClockTogglerGUI());
                }
                else
                {
                    //Finds existing app window through it's title and brings it to the foreground
                    Win11ClockTogglerGUI frm = new Win11ClockTogglerGUI();
                    Helper.BringWindowToFront(frm.Text);
                    frm.Close();
                }
            }
        }

    }
}
