using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Win11ClockToggler
{
    public static class Helper
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

        //Property to tell if the current operating system is Windows 10 or not
        public static bool IsWindows10
        {
            get
            {
                return Win32APIs.GetWindowsMajorVersion() == 10;
            }
        }

        #region Public Methods exposed to the other apps

        /// <summary>
        /// Returns true or false wether the DateTime control for the current operating system is visible or not.
        /// </summary>
        /// <returns></returns>
        public static bool IsDateTimeVisible()
        {
            return Win32APIs.IsWindowVisible(GetDateTimeControlHWnd());
        }

        /// <summary>
        /// Shows or hides the indicated element
        /// </summary>
        /// <param name="tbeToShowOrHide">The element to show or hide (full notificatipn area or just the clock and system icons)</param>
        /// <param name="shown">This reference parameter is used to indicate inf the element has been shown (true) or hidden (false) 
        /// to make further decissions later in the code based on this.</param>
        /// <remarks>It will detect the current element state (shown or hidden) and toggle it</remarks>
        public static SWOperation ToggleTaskbarElements(TaskbarElement tbeToShowOrHide)
        {
            //The result of the operation
            SWOperation operationPerformed = SWOperation.None;

            //Get the Clock hWnd (different under Win10 and 11)
            IntPtr clockHWnd = GetDateTimeControlHWnd();
            if (clockHWnd != IntPtr.Zero)     //If Zero the taskbar has changed and is neither Win10 nor Win11
            {
                //Get the current visible status of the clock element: that will define the whole set visibility status to return a value
                operationPerformed = IsControlVisible(clockHWnd) ? SWOperation.Hide : SWOperation.Show;  //To notify the operation to the caller

                //Toggle Date/Time visibility (the system icons area in Win11 or just the Clock element in Win10)
                ToggleControlVisibility(clockHWnd);

                //If we want to actuate over the full notification area, then we need to show/hide the first button (the chevron) and the SysPager
                if (tbeToShowOrHide == TaskbarElement.FullNotificationArea)
                {
                    List<IntPtr> elementsToToggle = GetNotificationAreaHWnds();
                    if (elementsToToggle.Count > 0)
                    {
                        elementsToToggle.ForEach(elt =>
                        {
                            //Change the visibility accordingly for each element (to be coherent with the main operation with the clock)
                            if (Win32APIs.IsWindowVisible(elt))
                                HideControl(elt);
                            else
                                ShowControl(elt);
                        });
                    }
                }
            }

            //If we reach this point, nothing has been discovered (it's not Win 10 or 11)
            return operationPerformed;
        }

        public static void ShowTaskbarElements(TaskbarElement tbeToShowOrHide)
        {
            //Get the Clock hWnd (different under Win10 and 11)
            IntPtr clockHWnd = GetDateTimeControlHWnd();
            if (clockHWnd != IntPtr.Zero)     //If Zero the taskbar has changed and is neither Win10 nor Win11
            {
                //Get the current visible status of the clock element: that will define the whole set visibility status to return a value

                //Toggle Date/Time visibility (the system icons area in Win11 or just the Clock element in Win10)
                ShowControl(clockHWnd);

                //If we want to actuate over the full notification area, then we need to show/hide the first button (the chevron) and the SysPager
                if (tbeToShowOrHide == TaskbarElement.FullNotificationArea)
                {
                    List<IntPtr> elementsToToggle = GetNotificationAreaHWnds();
                    if (elementsToToggle.Count > 0)
                    {
                        elementsToToggle.ForEach(elt =>
                        {
                            ShowControl(elt);
                        });
                    }
                }
            }
        }

        public static void HideTaskbarElements(TaskbarElement tbeToShowOrHide)
        {
            //Get the Clock hWnd (different under Win10 and 11)
            IntPtr clockHWnd = GetDateTimeControlHWnd();
            if (clockHWnd != IntPtr.Zero)     //If Zero the taskbar has changed and is neither Win10 nor Win11
            {
                //Get the current visible status of the clock element: that will define the whole set visibility status to return a value

                //Toggle Date/Time visibility (the system icons area in Win11 or just the Clock element in Win10)
                HideControl(clockHWnd);

                //If we want to actuate over the full notification area, then we need to show/hide the first button (the chevron) and the SysPager
                if (tbeToShowOrHide == TaskbarElement.FullNotificationArea)
                {
                    List<IntPtr> elementsToToggle = GetNotificationAreaHWnds();
                    if (elementsToToggle.Count > 0)
                    {
                        elementsToToggle.ForEach(elt =>
                        {
                            HideControl(elt);
                        });
                    }
                }
            }
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
                        ToggleControlVisibility(dateTimeWnd);
                    }
                }
            );
        }

        //Gets the hWnd for the DateTime container control, depending on the current structure of the taskbar (changes between Windows versions)
        public static IntPtr GetDateTimeControlHWnd()
        {
            IntPtr clockHWnd = IntPtr.Zero; //Default value

            //Get Tray Win32 child windows
            List<IntPtr> children = GetTrayNotifyHWndChildren();
            if (children.Count > 0)     //If Zero the taskbar has changed and is not Win10 Or 11
            {
                //Get the clock (date/time) control in Windows 11
                clockHWnd = children.Find(child => Win32APIs.GetClassName(child) == "Windows.UI.Composition.DesktopWindowContentBridge");
                if (clockHWnd == IntPtr.Zero)   //Check for control in Windows 10
                {
                    clockHWnd = children.Find(child => Win32APIs.GetClassName(child) == "TrayClockWClass");
                }
            }
            return clockHWnd;
        }

        //Gets a list of hWnds for all the controls we need to manipulate to show/hide the notification area (depends on the O.S.)
        public static List<IntPtr> GetNotificationAreaHWnds()
        {
            List<IntPtr> res = new List<IntPtr>();

            if (IsWindows10)
            {
                //In Windows 10 we hide the full notification area because otherwise
                //a lot of system icons would be still visible with gaps (and it's ugly)
                //We could have added the same controls as in Win11, but it will lead to those ugle gaps
                res.Add(GetTrayNotifyHWnd());
            }
            else //Windows 11
            {
                List<IntPtr> children = GetTrayNotifyHWndChildren();
                //In Windows 11, we need to hide the chevron and the SysPager individually, since everything is located in it.
                //In Wind11 is not enough to hide the TrayNotifyWnd (it won't hide everything) so:
                //1. Get the hWnd for first button (chevron)
                IntPtr chevronHWnd = children.Find(child => Win32APIs.GetClassName(child) == "Button"); //It's the first one in Win11&10, but just in case
                //2.- Get hWnd for the SysPager element (contains all the notification icons)
                IntPtr syspagerHWnd = children.Find(child => Win32APIs.GetClassName(child) == "SysPager");  //It's the same one in Win11&10

                //Ceck if they haveve been found and add them.
                //If one is missing the structure has been changed and I'll need to update the program, so notify the user
                if (chevronHWnd != IntPtr.Zero && syspagerHWnd != IntPtr.Zero)
                {
                    res.Add(chevronHWnd);
                    res.Add(syspagerHWnd);
                }
            }
            //It can return an empty list, the full notification area for Win10 or the needed controls for Win11
            return res;
        }

        //true if there are currently secondary bars in te system
        public static bool AreThereSecondaryTaskbars()
        {
            return Win32APIs.GetAllSecondaryTaskBars().Count > 0;
        }

        public static bool IsControlVisible(IntPtr hWnd)
        {
            return Win32APIs.IsWindowVisible(hWnd);
        }

        public static void BlinkControl(IntPtr hWnd)
        {
            Win32APIs.ShowWindow(hWnd, Win32APIs.SW_HIDE);
            Thread.Sleep(250);
            Win32APIs.ShowWindow(hWnd, Win32APIs.SW_SHOW);

        }

        public static void HideControl(IntPtr hWnd)
        {
            Win32APIs.ShowWindow(hWnd, Win32APIs.SW_HIDE);
        }

        public static void ShowControl(IntPtr hWnd)
        {
            Win32APIs.ShowWindow(hWnd, Win32APIs.SW_SHOW);
        }

        public static void ToggleControlVisibility(IntPtr hWnd)
        {
            if (IsControlVisible(hWnd))
                HideControl(hWnd);
            else
                ShowControl(hWnd);
        }

        //Finds a Window by its title and brings it Window to the foreground
        public static void BringWindowToFront(string title)
        {
            // Get a handle to the specified application (search Window by title)
            IntPtr handle = Win32APIs.FindWindow(null, title);

            // If it's found...
            if (handle != IntPtr.Zero)
            {
                //Bring it to the foreground
                Win32APIs.SetForegroundWindow(handle);
            }
        }

        #endregion

        #region Internal auxiliary methods

        internal static IntPtr GetTaskbarHWnd()
        {
            //Find Taskbar handler
            return Win32APIs.FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Shell_TrayWnd", null);
        }

        internal static IntPtr GetTrayNotifyHWnd()
        {
            return GetTrayNotifyHWnd(GetTaskbarHWnd());
        }

        //Gets the hWnd from a cached Taskbar hWnd instead of searching again for it
        internal static IntPtr GetTrayNotifyHWnd(IntPtr hWndTaskbar)
        {
            //Find Notification Tray handler
            return Win32APIs.FindWindowEx(hWndTaskbar, IntPtr.Zero, "TrayNotifyWnd", null);
        }

        internal static List<IntPtr> GetTaskbarHWndChildren()
        {
            IntPtr hWnd = GetTaskbarHWnd();
            if (hWnd == IntPtr.Zero)
                return new List<IntPtr>();  //Empty list
            else
                return Win32APIs.GetChildWindows(hWnd);
        }

        internal static List<IntPtr> GetTrayNotifyHWndChildren()
        {
            IntPtr hWnd = GetTrayNotifyHWnd();
            if (hWnd == IntPtr.Zero)
                return new List<IntPtr>();  //Empty list
            else
                return Win32APIs.GetChildWindows(hWnd);
        }

        #endregion

        #region Data saving and reading (Not used anymore)
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

        //Gets the last time a version check was made
        public static DateTime GetLastVersionCheckDateTime()
        {
            //Default value (never checked)
            DateTime checkedDT = DateTime.MinValue;

            string sCheckedDT = ReadRegValue(REG_LAST_VERSION_CHECK_VALUE);
            if (sCheckedDT != string.Empty)
                DateTime.TryParse(sCheckedDT, out checkedDT);

            return checkedDT;
        }

        //Saves current time as the last time the version was checked
        public static void SaveLastVersionCheckDateTime()
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

        //Checks if the key exists or not, creating it if needed
        internal static void EnsureAppKeyExists()
        {
            if (!RegKeyExists(REG_KEY))
                Registry.CurrentUser.CreateSubKey(REG_KEY, true);
        }

        //Saves to te registry the list of already hiden Hwnds before hiding the elements
        public static void SaveRegValue(string name, string value)
        {
            EnsureAppKeyExists();
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(REG_KEY, true);
            registryKey.SetValue(name, value);
        }

        //Reads a value from registry
        public static string ReadRegValue(string name, string defaultValue = "")
        {
            string value = defaultValue;
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(REG_KEY);
                value = (string)registryKey.GetValue(name);
            }
            catch { }
            if (value == null) value = defaultValue;
            return value;
        }

        #endregion
    }
}
