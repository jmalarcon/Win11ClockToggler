using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Win11ClockToggler
{
    internal class Win32APIs
    {
        //All needed Win32 APIs declarations
        //Documentation: https://docs.microsoft.com/en-us/windows/win32/api/winuser/

        #region Auxiliar constants
        internal static readonly int SW_HIDE = 0;   //Show control/window
        internal static readonly int SW_SHOW = 0x0005; //Hide control/window
        #endregion

        #region Interop declarations
        //Retrieves a handle to a window whose class name and window name match the specified strings.
        //The function searches child windows, beginning with the one following the specified child window.
        //This function does not perform a case-sensitive search.
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr hWndChildAfter, string className, string windowTitle);

        //Enumerates all top-level windows on the screen by passing the handle to each window, in turn, to an application-defined callback function.
        //EnumWindows continues until the last top-level window is enumerated or the callback function returns FALSE.
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        //Enumerates the child windows that belong to the specified parent window by passing the handle
        //to each child window, in turn, to an application-defined callback function
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool EnumChildWindows(IntPtr hwndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);

        //Retrieves the name of the class to which the specified window belong
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        //Sets the specified window's show state
        [DllImport("user32.dll")]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        //Know if an specific window/control is visible
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        internal static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);

        [DllImport("winbrand.dll", CharSet = CharSet.Unicode)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        internal static extern string BrandingFormatString(string format);


        #endregion

        #region internal methods to simplify the use of some APIs
        //Gets the window/control class name
        internal static string GetClassName(IntPtr hWnd)
        {
            int length;
            // Pre-allocate 256 characters, since this is the maximum class name length.
            StringBuilder ClassName = new StringBuilder(256);
            //Get the window class name
            length = GetClassName(hWnd, ClassName, ClassName.Capacity);
            return length > 0 ? ClassName.ToString() : "Unknown";
        }

        //An application-defined callback function used with the EnumChildWindows function.
        //It receives the child window handles.
        internal delegate bool EnumWindowsProc(IntPtr hwnd, IntPtr lParam);

        //Searches for the child controls of a Window
        internal static List<IntPtr> GetChildWindows(IntPtr ParentHandle)
        {
            List<IntPtr> ChildrenList = new List<IntPtr>();
            GCHandle ListHandle = GCHandle.Alloc(ChildrenList);
            try
            {
                EnumWindowsProc enumProc = new EnumWindowsProc(EnumAllWindows);
                EnumChildWindows(ParentHandle, enumProc, GCHandle.ToIntPtr(ListHandle));
            }
            finally
            {
                if (ListHandle.IsAllocated)
                    ListHandle.Free();
            }
            return ChildrenList;
        }

        internal static List<IntPtr> GetAllSecondaryTaskBars()
        {
            List<IntPtr> hwndList = new List<IntPtr>();
            GCHandle ListHandle = GCHandle.Alloc(hwndList);
            try
            {
                EnumWindowsProc enumProc = new EnumWindowsProc(EnumShell_SecondaryTrayWndWindows);
                EnumWindows(enumProc, GCHandle.ToIntPtr(ListHandle));
            }
            finally
            {
                if (ListHandle.IsAllocated)
                    ListHandle.Free();
            }
            return hwndList;
        }

        private static bool EnumAllWindows(IntPtr Handle, IntPtr Parameter)
        {
            List<IntPtr> ChildrenList = GCHandle.FromIntPtr(Parameter).Target as List<IntPtr>;
            if (ChildrenList == null)
                throw new Exception("GCHandle Target could not be cast as List(Of IntPtr)");
            ChildrenList.Add(Handle);
            return true;
        }

        private static bool EnumShell_SecondaryTrayWndWindows(IntPtr Handle, IntPtr Parameter)
        {
            List<IntPtr> ChildrenList = GCHandle.FromIntPtr(Parameter).Target as List<IntPtr>;
            if (ChildrenList == null)
                throw new Exception("GCHandle Target could not be cast as List(Of IntPtr)");
            //This is the class name for all the secondary taskbars
            //The structure is different from the main one
            if (Win32APIs.GetClassName(Handle) == "Shell_SecondaryTrayWnd")
            {
                ChildrenList.Add(Handle);
            }
            return true;
        }

        internal static void InvalidateWindow(IntPtr hWnd)
        {
            if (hWnd != IntPtr.Zero)
                InvalidateRect(hWnd, IntPtr.Zero, true);
        }

        //Use the Win32 API to get the brand string
        //We can use the System.Environment.OSVersion.Version.Build because in .NET framework it always shows an old version
        public static int GetWindowsMajorVersion()
        {
            string brand = Win32APIs.BrandingFormatString("%WINDOWS_LONG%");
            //Look for the Windows version in the string with a Regular Expression
            Regex regex = new Regex(@"Windows (\d+)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
            var matches = regex.Matches(brand);
            if (matches.Count > 0 && matches[0].Groups.Count > 1)   //The capture contains the version number
                return int.Parse(matches[0].Groups[1].Value);
            else
                return 11;  //If the API is not able to get the version, assume it's 11, which is the main aim of the app
        }

        #endregion
    }
}
