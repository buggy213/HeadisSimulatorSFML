namespace HeadisSimulatorSFML.Engine
{
    using System;
    using SFML.Graphics;
    using SFML.Window;

    public static class WindowManager
    {
        private static RenderWindow renderWindow;

        public static RenderWindow RenderWindow
        {
            get
            {
                return renderWindow;
            }
        }

        // Creates the window instance and sets settings
        public static void Init()
        {
            VideoMode videoMode = new VideoMode(DisplaySettings.RequestedWidth, DisplaySettings.RequestedHeight);
            if (DisplaySettings.FullScreen)
            {
                // See if the requested resolution is available; if not, default to the "best"
                if (!videoMode.IsValid())
                {
                    videoMode = VideoMode.FullscreenModes[0];
                }
            }

            renderWindow = new RenderWindow(
                videoMode,
                DisplaySettings.WindowTitle,
                DisplaySettings.FullScreen ? Styles.Fullscreen : Styles.Default);

            renderWindow.Closed += OnClose;

            renderWindow.SetVerticalSyncEnabled(DisplaySettings.VSyncOn);
        }

        // Process events
        public static void UpdateWindow()
        {
            renderWindow.DispatchEvents();
        }

        private static void OnClose(object sender, EventArgs e)
        {
            renderWindow.Close();
            GameLoop.Stop();
        }
    }
}
