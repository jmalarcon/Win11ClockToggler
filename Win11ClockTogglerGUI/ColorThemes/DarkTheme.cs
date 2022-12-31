using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win11ClockTogglerGUI.ColorThemes
{
    // Color references:
    // https://learn.microsoft.com/en-us/visualstudio/extensibility/ux-guidelines/color-value-reference-for-visual-studio?view=vs-2022
    public class DarkTheme : Theme
    {
        public override Color Foreground { get => Color.FromArgb(255, 241, 241, 241); }
        public override Color PanelBackground { get => Color.FromArgb(255, 37, 37, 38); }
        public override Color DisabledForeground { get => Color.FromArgb(255, 101, 101, 101); }
        public override Color DisabledPanelBackground { get => Color.FromArgb(255, 37, 38, 38); }
        public override Color Background { get => Color.FromArgb(255, 45, 45, 48); }
    }
}
