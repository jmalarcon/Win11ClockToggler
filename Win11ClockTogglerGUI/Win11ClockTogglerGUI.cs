using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Win11ClockToggler;
using System.Runtime.InteropServices;

namespace Win11ClockTogglerGUI
{
    public partial class Win11ClockTogglerGUI : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        private bool IsDirty = false;
        private List<IntPtr> CurrentMonitoredControls = new List<IntPtr>();
        private string LatestVersion;
        //Registry keys to save the latest status of the checks
        private readonly string REG_CHKNOTIFAREA_STATUS = "chkNotifArea_Status";
        private readonly string REG_CHKALLLDISPLAYS_STATUS = "chkAllDisplays_Status";

        private static int TOGGLE_KEY_ID = 1;
        private static int STEALTH_KEY_ID = 2;

        public Win11ClockTogglerGUI()
        {
            InitializeComponent();

            // Register hotkeys
            int keyModifiers = 0x008 + 0x004; // Win + Shift
            RegisterHotKey(this.Handle, TOGGLE_KEY_ID, keyModifiers, (int)Keys.F6);
            RegisterHotKey(this.Handle, STEALTH_KEY_ID, keyModifiers, (int)Keys.F7);
        }

        private void CheckBoxes_Paint(object sender, PaintEventArgs e)
        {
            CheckBox current = ((CheckBox)sender);
            //Draw border
            ControlPaint.DrawBorder(e.Graphics, current.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void DisableCheckBox(JCS.ToggleSwitch chkBox)
        {
            chkBox.Enabled = false;
            chkBox.Parent.ForeColor = SystemColors.InactiveCaption;
            chkBox.Parent.BackColor = SystemColors.ControlLight;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Process any messages sent to this window
        protected override void WndProc(ref Message m)
        {
            bool passThroughMsg = true;

            // Catch the WM_HOTKEY message to handle any hotkeys being pressed
            // https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-hotkey
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                if (id == TOGGLE_KEY_ID) 
                {
                    btnHideShow_Click(null, null);
                }
                else if (id == STEALTH_KEY_ID) 
                {
                    toggleStealthMode();
                }
            }

            // Catch the WM_SYSCOMMAND message
            // https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand
            const int WM_SYSCOMMAND = 0x0112;
            if (m.Msg == WM_SYSCOMMAND)
            {
                // When the window is being minimized (SC_MINIMIZE)
                const int SC_MINIMIZE = 0xf020;
                if (m.WParam.ToInt32() == SC_MINIMIZE)
                {
                    passThroughMsg = false; // To prevent the regular minimize behaviour
                    toggleStealthMode(); 
                }
            }

            if (passThroughMsg)
            {
                base.WndProc(ref m);
            }
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
            operation = Helper.ToggleTaskbarElements(tbeToToggle);

            switch (operation)
            {
                case Helper.SWOperation.Hide:
                    IsDirty = true;
                    btnExit.Text = "Restore && Exit";
                    pnlCheckBoxes.Enabled = false;
                    //Monitor the notification area in case it pops up again for any reason
                    //(if the user hasn't enabled Focus Assist, any notification or any new icon added to the tray will show all again)
                    CurrentMonitoredControls.Add(Helper.GetDateTimeControlHWnd());  //Always monitor the Datetime control
                    if (chkNotifArea.Checked)
                        CurrentMonitoredControls.AddRange(Helper.GetNotificationAreaHWnds());   //It's a different list depending on the Windows version
                    tmrShowMonitor.Enabled = true;
                    //Add notification icon (hack in Win10 to be able to restore the real width of the taskbar when showing it again)
                    if (Helper.IsWindows10)
                        notifyIcon.Visible = true;
                    break;
                case Helper.SWOperation.Show:
                    IsDirty = false;
                    btnExit.Text = "Exit";
                    pnlCheckBoxes.Enabled = true;
                    //Stop monitoring the notificaton area
                    tmrShowMonitor.Enabled = false;
                    CurrentMonitoredControls = new List<IntPtr>();
                    //This is a hack: dispose the notification icon (although it's not visible) to force a redraw of the notification area in Windows 10
                    if (Helper.IsWindows10)
                        notifyIcon.Visible = false;
                    break;
                default:  //Controls can't be found: something has changed in the underlying structure: notify
                    MessageBox.Show(@"The notification area and/or the Date/Time controls have not been found.

This program is designed for Windows 11 (and works with Windows 10 too). 

Maybe you're using a newer version of Windows. 
Or maybe your version of Windows 11 is newer and the layout of the taskbar has changed.

Please, contact me through GitHub (https://github.com/jmalarcon/Win11ClockToggler) 
and let me know about this issue. Thanks!",
"Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            //Disable clock in secondary taskbars
            if (chkSecondary.Checked)
                Helper.ShowOrHideSecondaryTaskbarsElementWindow();

        }

        //Form load 
        private void Win11ClockTogglerGUI_Load(object sender, EventArgs e)
        {
            DisableCheckBox(chkDateTime);   //This is always fixed, for information purposes, because the Date/Time is always toggled
            //Get the latest state of the option checkboxes to keep them the same
            chkNotifArea.Checked = (Helper.ReadRegValue(REG_CHKNOTIFAREA_STATUS, "1") == "1");
            chkSecondary.Checked = (Helper.ReadRegValue(REG_CHKALLLDISPLAYS_STATUS, "1") == "1");

            //Check if there are secondary taskbars in secondary windows
            if (!Helper.AreThereSecondaryTaskbars())
            {
                //Disable checkbox if there are not secondary taskbars
                chkSecondary.Checked = false;
                DisableCheckBox(chkSecondary);
            }
            //Check for new version in background
            bgwCheckVersion.RunWorkerAsync();
        }

        //Form closing
        private void Win11ClockTogglerGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save the status of the checks to keep the latest option
            Helper.SaveRegValue(REG_CHKNOTIFAREA_STATUS, chkNotifArea.Checked ? "1" : "0");
            Helper.SaveRegValue(REG_CHKALLLDISPLAYS_STATUS, chkSecondary.Checked ? "1" : "0");

            if (IsDirty)
                btnHideShow_Click(null, null);

            //Dispose Notify icons because of Windows 10 hack
            if (Helper.IsWindows10 && chkNotifArea.Checked)
            {
                try
                {
                    notifyIcon.Icon.Dispose();
                    notifyIcon.Dispose();
                }
                catch { }
            }
        }

        private void toggleStealthMode()
        {
            if (Visible)
            {
                Hide();
                MessageBox.Show("The Win11ClockToggler window is now completely hidden.\nWhenever you want to bring it back, press Win+Shift+F7.");
                
            }
            else
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                BringToFront();
            }
        }

        //Timer to monitor if the current notification area pops up again because of a new icon or notification
        private void tmrShowMonitor_Tick(object sender, EventArgs e)
        {
            if (CurrentMonitoredControls.Count > 0) //Monitoring on
            {
                CurrentMonitoredControls.ForEach(ctrlHWnd =>
                {
                    //If it has been put visible again, hide it
                    if (Helper.IsControlVisible(ctrlHWnd))
                        Helper.HideControl(ctrlHWnd);
                });
            }
            else    //Monitoring off
                return;
        }

        //Check the latest version available in the background
        private void bgwCheckVersion_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            LatestVersion = VersionChecker.GetLatestAvailableVersion();
        }

        //When the latest version info is available
        private void bgwCheckVersion_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //If there's a new version, show the label with the infomation and link
            if (LatestVersion != null && LatestVersion != string.Empty)
            {
                lnkNewVersion.Text = $"⚠ New version {LatestVersion} available! Click here to download...";
                lnkNewVersion.LinkArea = new LinkArea(0, lnkNewVersion.Text.Length);
                lnkNewVersion.Visible = true;
            }
        }

        private void lnkNewVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jmalarcon/Win11ClockToggler/releases");
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
        }
    }
}
