using Microsoft.Win32;
using System.Drawing;

namespace Win11ClockTogglerGUI.ColorThemes
{
    public class Theme
    {
        public virtual Color Foreground { get; }
        public virtual Color PanelBackground { get; }
        public virtual Color DisabledForeground { get; }
        public virtual Color DisabledPanelBackground { get;}
        public virtual Color Background { get; }
    }

    public static class ThemeHelper
    {
        /// <summary>
        /// Returns true if the Dark Theme is currently enabled in the system for applications
        /// </summary>
        /// <returns>Returns true if current app theme is dark and false if is light</returns>
        public static bool IsCurrentThemeDark()
        {
            try
            {
                //Try to read the setting from the registry
                return (int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1) == 0;

            }
            catch
            {
                //Default: Light Theme
                return false;
            }
        }

        public static Theme GetCurrentTheme()
        {
            if (IsCurrentThemeDark())
                return new ColorThemes.DarkTheme();
            else
                return new ColorThemes.LightTheme();
        }
    }
}
