using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Win11ClockToggler;

namespace Win11ClockTogglerGUI
{
    public partial class Win11ClockTogglerGUI : Form
    {

        private bool IsDirty = false;
        private List<IntPtr> CurrentMonitoredControls = new List<IntPtr>();
        private string LatestVersion;
        //Registry keys to save the latest status of the checks
        private readonly string REG_CHKNOTIFAREA_STATUS = "chkNotifArea_Status";
        private readonly string REG_CHKALLLDISPLAYS_STATUS = "chkAllDisplays_Status";

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
                    {
                        try
                        {
                            notifyIcon.Icon.Dispose();
                            notifyIcon.Dispose();
                        }
                        catch { }
                    }
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
            if (chkAllDisplays.Checked)
                Helper.ShowOrHideSecondaryTaskbarsElementWindow();

        }

        //Form load 
        private void Win11ClockTogglerGUI_Load(object sender, EventArgs e)
        {
            DisableCheckBox(chkDateTime);   //This is always fixed, for information purposes, because the Date/Time is always toggled
            //Get the latest state of the option checkboxes to keep them the same
            chkNotifArea.Checked = (Helper.ReadRegValue(REG_CHKNOTIFAREA_STATUS, "1") == "1");
            chkAllDisplays.Checked = (Helper.ReadRegValue(REG_CHKALLLDISPLAYS_STATUS, "1") == "1");

            //Check if there are secondary taskbars in secondary windows
            if (!Helper.AreThereSecondaryTaskbars())
            { 
                //Disable checkbox if there are not secondary taskbars
                chkAllDisplays.Checked = false;
                DisableCheckBox(chkAllDisplays);
            }
            //Check for new version in background
            bgwCheckVersion.RunWorkerAsync();
        }

        //Form closing
        private void Win11ClockTogglerGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save the status of the checks to keep the latest option
            Helper.SaveRegValue(REG_CHKNOTIFAREA_STATUS, chkNotifArea.Checked ? "1" : "0");
            Helper.SaveRegValue(REG_CHKALLLDISPLAYS_STATUS, chkAllDisplays.Checked ? "1" : "0");

            if (IsDirty)
                btnHideShow_Click(null, null);
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
                lnkNewVersion.LinkArea = new LinkArea(0, lnkNewVersion.Text.Length-1);    //All the text except the icon is a link
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
    }
}
