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
}
