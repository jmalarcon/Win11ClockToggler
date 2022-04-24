using System;
using System.Drawing;
using System.Windows.Forms;
using Win11ClockToggler;

namespace Win11ClockTogglerGUI
{
    public partial class Win11ClockTogglerGUI : Form
    {

        private bool IsDirty = false;
        private IntPtr CurrentMonitoredWindow = IntPtr.Zero;

        public Win11ClockTogglerGUI()
        {
            InitializeComponent();
        }

        private void CheckBoxes_Paint(object sender, PaintEventArgs e)
        {
            CheckBox current = ((CheckBox)sender);
            //Draw border
            ControlPaint.DrawBorder(e.Graphics, current.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void DisableCheckBox(CheckBox chkBox)
        {
            chkBox.Enabled = false;
            chkBox.ForeColor = SystemColors.InactiveCaption;
            chkBox.BackColor = SystemColors.ControlLight;
            chkBox.Font = new Font(chkBox.Font, FontStyle.Italic);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (IsDirty) 
                btnHideShow_Click(null, null);
            this.Close();
        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            //By default, hide at least the clock
            Helper.TaskbarElement tbeToToggle = Helper.TaskbarElement.Clock;
            //If the user wants, toggle the full notification area
            if (chkNotifArea.Checked) tbeToToggle = Helper.TaskbarElement.FullNotificationArea;

            //Operation performed (hide or show) (received as information of the operation that has been done)
            Helper.SWOperation operation = Helper.SWOperation.None;

            //Toggle Date/time and/or notification areas
            Helper.ToggleTaskbarElements(tbeToToggle, out operation);

            switch (operation)
            {
                case Helper.SWOperation.Hide:
                    IsDirty = true;
                    btnExit.Text = "Restore && Exit";
                    pnlCheckBoxes.Enabled = false;
                    if (chkNotifArea.Checked)
                    {
                        //Monitor the notification area in case it pops up again for any reason
                        CurrentMonitoredWindow = Helper.GetDateTimeControlHWnd();
                        tmrShowMonitor.Enabled = true;
                    }
                    break;
                case Helper.SWOperation.Show:
                    IsDirty = false;
                    btnExit.Text = "Exit";
                    pnlCheckBoxes.Enabled = true;
                    if (chkNotifArea.Checked)
                    {
                        //Stop monitoring the notificaton area
                        tmrShowMonitor.Enabled = false;
                        CurrentMonitoredWindow = IntPtr.Zero;
                    }
                    break;
                default:  //Controls can't be found: something has changed in the underlying structure: notify
                    MessageBox.Show(@"The notification area and/or the Date/Time controls have not been found.

This program is designed for Windows 11. 

Maybe your version of Windows 11 is newer and the layout of the taskbar has changed.

Please, contact me through GitHub (https://github.com/jmalarcon/Win11ClockToggler) 
and let me know about this issue. Thanks!",
"Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            //Disable clock in secondary taskbars
            if (chkAllDisplays.Checked)
                Helper.ShowOrHideSecondaryTaskbarsElementWindow();

        }

        private void Win11ClockTogglerGUI_Load(object sender, EventArgs e)
        {
            DisableCheckBox(chkDateTime);   //This is always fixed, for information purposes, because the Date/Time is always toggled
            //Check if there are secondary taskbars in secondary windows
            if (!Helper.AreThereSecondaryTaskbars())
            { 
                //Disable checkbox if there are not secondary taskbars
                chkAllDisplays.Checked = false;
                DisableCheckBox(chkAllDisplays);
            }
            //TODO: Check for new version in background
        }

        //Timer to monitor if the current notification area pops up again because of a new icon or notification
        private void tmrShowMonitor_Tick(object sender, EventArgs e)
        {
            if (CurrentMonitoredWindow != IntPtr.Zero) //Monitoring on
            {
                //If it has been put visible again, hide it
                if (Helper.IsWindowVisible(CurrentMonitoredWindow))
                    Helper.HideWindow(CurrentMonitoredWindow);
            }
            else    //Monitoring off
                return;
        }

    }
}
