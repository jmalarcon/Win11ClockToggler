using System.Drawing;
using System.Windows.Forms;

namespace Win11ClockTogglerGUI.ColorThemes
{
    public class LightTheme : Theme
    {
        //Enabled panel Foreground text color
        public override Color Foreground { get => SystemColors.WindowText; }
        //Enabled panel panel background color
        public override Color PanelBackground { get => SystemColors.ControlLight; }
        //Disabled panel foreground text color
        public override Color DisabledForeground { get => SystemColors.InactiveCaptionText; }
        //Disabled panel background text color
        public override Color DisabledPanelBackground { get => SystemColors.InactiveCaption; }
        //Form background
        public override Color Background { get => SystemColors.ControlLightLight; }
    }
}
