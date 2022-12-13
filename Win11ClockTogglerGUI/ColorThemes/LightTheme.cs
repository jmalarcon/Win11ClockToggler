using System.Drawing;

namespace Win11ClockTogglerGUI.ColorThemes
{
    public class LightTheme : Theme
    {
        public override Color Foreground { get => Color.FromArgb(20, 20, 20); }
        public override Color PanelBackground { get => Color.FromArgb(189, 189, 189); }
        public override Color DisabledForeground { get => Color.FromArgb(66, 66, 66); }
        public override Color DisabledPanelBackground { get => Color.FromArgb(111, 111, 111); }
        public override Color Background { get => Color.FromArgb(158, 158, 158); }
    }
}
