using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Win11ClockToggler
{
    public class Helper
    {
        //Enum to decide if you want to hide the clock only or the full notification area
        public enum TaskbarElement
        {
            Clock = 0,
            FullNotificationArea = 1
        }

        //Enum to inform about the operation taking place
        public enum SWOperation
        {
            None = 0,   //No operation performed (element not found)
            Show = 1,   //Shows element(s)
            Hide = 2    //Hides element(s)
        }

        /// <summary>
        /// Shows or hides the indicated element
        /// </summary>
        /// <param name="tbeToShowOrHide">The element to show or hide (full notificatipn area or just the clock and system icons)</param>
        /// <param name="shown">This reference parameter is used to indicate inf the element has been shown (true) or hidden (false) 
        /// to make further decissions later in the code based on this.</param>
        /// <remarks>It will detect the current element state (shown or hidden) and toggle it</remarks>
        public static bool ToggleTaskbarElements(TaskbarElement tbeToShowOrHide, out SWOperation operationPerformed)
        {
            IntPtr hWndTaskbar = GetTaskbarHWnd();
            if (hWndTaskbar != IntPtr.Zero)
            {
                //Windows 11: Find the notification area handler inside the taskbar (includes the system icons, which include the clock)
                IntPtr hWndNotifArea = GetTrayNotifyHWnd(hWndTaskbar);
                if (hWndNotifArea != IntPtr.Zero)
                {
                    //Enumerate notification area children to find the needed hWnds (datetime, chevron, SysPager)
                    List<IntPtr> children = Win32APIs.GetChildWindows(hWndNotifArea);

                    //Get the clock (date/time) control in Windows 11
                    IntPtr clockHWnd = children.Find(child => Win32APIs.GetClassName(child) == "Windows.UI.Composition.DesktopWindowContentBridge");
                    if (clockHWnd == IntPtr.Zero)   //Check for Windows 10
                    {
                        clockHWnd = children.Find(child => Win32APIs.GetClassName(child) == "Clock");
                    }

                    //If not clock has been found, exit with failure
                    if (clockHWnd == IntPtr.Zero)
                        goto Failure;

                    //Get the current visible status of the clock element: that will define the whole set visibility status to return a value
                    operationPerformed = IsWindowVisible(clockHWnd) ? SWOperation.Hide : SWOperation.Show;  //To notify the operation to the caller

                    //If we want to actuate over the full notification area, then we need to show/hide the first button (the chevron) and the SysPager
                    if (tbeToShowOrHide == TaskbarElement.FullNotificationArea)
                    {
                        //Get hWnd for first button (chevron)
                        IntPtr chevronHWnd = children.Find(child => Win32APIs.GetClassName(child) == "Button"); //It's usually the first one, but just in case
                        //Get hWnd for the SysPager element (contains all the notification icons)
                        IntPtr syspagerHWnd = children.Find(child => Win32APIs.GetClassName(child) == "SysPager");

                        //Toggle notification area icons
                        if (chevronHWnd != IntPtr.Zero) ToggleWindowVisibility(chevronHWnd);
                        if (syspagerHWnd != IntPtr.Zero) ToggleWindowVisibility(syspagerHWnd);
                    }

                    //Finally toggle the system icons area (with the date/time)
                    ToggleWindowVisibility(clockHWnd);
                    return true;    //Success
                }
            }

        Failure:
            //If we reach this point, nothing has been discovered
            operationPerformed = SWOperation.None;
            return false;   //Failure
        }

        public static IntPtr GetTaskbarHWnd()
        {
            //Find Taskbar handler
            return Win32APIs.FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Shell_TrayWnd", null);
        }

        public static IntPtr GetTrayNotifyHWnd()
        {
            return GetTrayNotifyHWnd(GetTaskbarHWnd());
        }

        //Gets the hWnd from a cached Taskbar hWnd instead of searching again for it
        public static IntPtr GetTrayNotifyHWnd(IntPtr hWndTaskbar)
        {
            //Find Notification Tray handler
            return Win32APIs.FindWindowEx(hWndTaskbar, IntPtr.Zero, "TrayNotifyWnd", null);
        }

        public static IntPtr GetDateTimeControlHWnd()
        {
            IntPtr clockHWnd = IntPtr.Zero;
            IntPtr hWndTaskbar = GetTaskbarHWnd();
            if (hWndTaskbar != IntPtr.Zero)
            {
                //Windows 11: Find the notification area handler inside the taskbar (includes the system icons, which include the clock)
                IntPtr hWndNotifArea = GetTrayNotifyHWnd(hWndTaskbar);
                if (hWndNotifArea != IntPtr.Zero)
                {
                    //Enumerate notification area children to find the needed hWnds (datetime, chevron, SysPager)
                    List<IntPtr> children = Win32APIs.GetChildWindows(hWndNotifArea);

                    //Get the clock (date/time) control in Windows 11
                    clockHWnd = children.Find(child => Win32APIs.GetClassName(child) == "Windows.UI.Composition.DesktopWindowContentBridge");
                    if (clockHWnd == IntPtr.Zero)   //Check for Windows 10
                    {
                        clockHWnd = children.Find(child => Win32APIs.GetClassName(child) == "ClockButton");
                    }
                }
            }
            return clockHWnd;
        }

        //true if there are currently secondary bars in te system
        public static bool AreThereSecondaryTaskbars()
        {
            return Win32APIs.GetAllSecondaryTaskBars().Count > 0;
        }

        public static void ShowOrHideSecondaryTaskbarsElementWindow()
        {
            //Find Windows secondary Taskbar (it's like a secondary tray from the main one)
            //Secondary Taskbar handler
            List<IntPtr> secondaryTaskBars = Win32APIs.GetAllSecondaryTaskBars();

            secondaryTaskBars.ForEach(
                hWndSecTaskbar =>
                {
                    //Enumerate notification area children
                    List<IntPtr> children = Win32APIs.GetChildWindows(hWndSecTaskbar);
                    //The last DesktopWindowContentBridge is the datetime/clock
                    var dateTimeWnd = children.FindLast(child =>
                        Win32APIs.GetClassName(child) == "Windows.UI.Composition.DesktopWindowContentBridge" || //Windows 11
                        Win32APIs.GetClassName(child) == "ClockButton");    //Windows 10

                    //If found, just toggle its visibility
                    if (dateTimeWnd != IntPtr.Zero)
                    {
                        ToggleWindowVisibility(dateTimeWnd);
                    }
                }
            );
        }

        static public bool IsWindowVisible(IntPtr hWnd)
        {
            return Win32APIs.IsWindowVisible(hWnd);
        }

        static public void BlinkWindow(IntPtr hWnd)
        {
            Win32APIs.ShowWindow(hWnd, Win32APIs.SW_HIDE);
            Thread.Sleep(250);
            Win32APIs.ShowWindow(hWnd, Win32APIs.SW_SHOW);

        }

        static public void HideWindow(IntPtr hWnd)
        {
            Win32APIs.ShowWindow(hWnd, Win32APIs.SW_HIDE);
        }

        static public void ShowWindow(IntPtr hWnd)
        {
            Win32APIs.ShowWindow(hWnd, Win32APIs.SW_SHOW);
        }

        static public void ToggleWindowVisibility(IntPtr hWnd)
        {
            if (IsWindowVisible(hWnd))
                HideWindow(hWnd);
            else
                ShowWindow(hWnd);
        }

        #region Data saving and reading
        //Registry location for this app settings
        static readonly string REG_KEY = @"SOFTWARE\Win11ClockToggler";
        static readonly string REG_HWNDS_VALUE = "HiddenHwnds";
        static readonly string REG_LAST_VERSION_CHECK_VALUE = "LastVersionCheck"; 

        //Read the list of Hwnds already hidden from Windows registry
        internal static List<int> GetHiddenHwnds()
        {
            List<int> res = new List<int>();
            string strHwnds = ReadRegValue(REG_HWNDS_VALUE);
            if (strHwnds != String.Empty)
                res = strHwnds.Split('|').Select(int.Parse).ToList<int>();
            return res;
        }

        //Saves to te registry the list of already hiden Hwnds before hiding the elements
        internal static void SaveHiddenHwnds(List<int> hiddenHwnds)
        {
            string value = string.Join("|", hiddenHwnds.ToArray());
            EnsureAppKeyExists();
            SaveRegValue(REG_HWNDS_VALUE, value);
        }

        //Checks if the key exists or not, creating it if needed
        internal static void EnsureAppKeyExists()
        {
            if (!RegKeyExists(REG_KEY))
                Registry.CurrentUser.CreateSubKey(REG_KEY, true);
        }

        //Gets the last time a version check was made
        internal static DateTime GetLastVersionCheckDateTime()
        {
            //Default value (never checked)
            DateTime checkedDT = DateTime.MinValue;

            string sCheckedDT = ReadRegValue(REG_LAST_VERSION_CHECK_VALUE);
            if (sCheckedDT != string.Empty)
                DateTime.TryParse(sCheckedDT, out checkedDT);

            return checkedDT;
        }

        //Saves current time as the last time the version was checked
        internal static void SaveLastVersionCheckDateTime()
        {
            SaveRegValue(REG_LAST_VERSION_CHECK_VALUE, DateTime.Now.ToString());
        }
        #endregion

        #region General registry helpers
        //Check if the key exists or not
        internal static bool RegKeyExists(string regKey)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(regKey);
                return (key != null);
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Saves to te registry the list of already hiden Hwnds before hiding the elements
        internal static void SaveRegValue(string name, string value)
        {
            EnsureAppKeyExists();
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(REG_KEY, true);
            registryKey.SetValue(name, value);
        }

        //Reads a value from registry
        internal static string ReadRegValue(string name)
        {
            string value = string.Empty;
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(REG_KEY);
                value = (string)registryKey.GetValue(name);
            }
            catch { }
            return value;
        }

        #endregion
    }
}
