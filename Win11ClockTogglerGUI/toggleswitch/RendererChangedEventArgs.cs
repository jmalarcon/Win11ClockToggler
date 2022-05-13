using JCS;

namespace ToggleSwitch
{
    public class BeforeRenderingEventArgs
    {
        public ToggleSwitchRendererBase Renderer { get; set; }

        public BeforeRenderingEventArgs(ToggleSwitchRendererBase renderer)
        {
            Renderer = renderer;
        }
    }
}
