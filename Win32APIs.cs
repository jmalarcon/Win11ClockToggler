using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;

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
                EnumWindowsProc enumProc = new EnumWindowsProc(EnumWindow);
                EnumChildWindows(ParentHandle, EnumWindow, GCHandle.ToIntPtr(ListHandle));
            }
            finally
            {
                if (ListHandle.IsAllocated)
                    ListHandle.Free();
            }
            return ChildrenList;
        }

        private static bool EnumWindow(IntPtr Handle, IntPtr Parameter)
        {
            List<IntPtr> ChildrenList = GCHandle.FromIntPtr(Parameter).Target as List<IntPtr>;
            if (ChildrenList == null)
                throw new Exception("GCHandle Target could not be cast as List(Of IntPtr)");
            ChildrenList.Add(Handle);
            return true;
        }
#endregion
    }
}
