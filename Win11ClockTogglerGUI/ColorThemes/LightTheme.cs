using System.Drawing;
using System.Windows.Forms;

namespace Win11ClockTogglerGUI.ColorThemes
{
    // Color references:
    // https://learn.microsoft.com/en-us/visualstudio/extensibility/ux-guidelines/color-value-reference-for-visual-studio?view=vs-2022
    public class LightTheme : Theme
    {
        //Enabled panel Foreground text color
        public override Color Foreground { get => Color.FromArgb(255, 30, 30, 30); }
        //Enabled panel panel background color
        public override Color PanelBackground { get => Color.FromArgb(255, 245, 245, 245); }
        //Disabled panel foreground text color
        public override Color DisabledForeground { get => Color.FromArgb(255, 162, 164, 165); }
        //Disabled panel background text color
        public override Color DisabledPanelBackground { get => Color.FromArgb(255, 245, 245, 245); }
        //Form background
        public override Color Background { get => Color.FromArgb(255, 238, 238, 242); }
    }
}
