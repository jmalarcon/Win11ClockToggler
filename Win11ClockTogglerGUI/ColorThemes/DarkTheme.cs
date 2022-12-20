using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win11ClockTogglerGUI.ColorThemes
{

    public class DarkTheme : Theme
    {
        public override Color Foreground { get => Color.FromArgb(227, 227, 227); }
        public override Color PanelBackground { get => Color.FromArgb(43, 43, 43); }
        public override Color DisabledForeground { get => Color.FromArgb(120, 120, 120); }
        public override Color DisabledPanelBackground { get => Color.FromArgb(38, 38, 38); }
        public override Color Background { get => Color.FromArgb(32, 32, 32); }
    }
}
