using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SFML.Window;
using SFML.Graphics;

namespace HeadisSimulatorSFML.Engine
{
    static class WindowManager
    {
        static RenderWindow renderWindow;

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
            VideoMode videoMode = new VideoMode(DisplaySettings.requestedWidth, DisplaySettings.requestedHeight);
            if (DisplaySettings.fullScreen)
            {
                // See if the requested resolution is available; if not, default to the "best"
                if (!videoMode.IsValid())
                {
                    videoMode = VideoMode.FullscreenModes[0];
                }

            }

            renderWindow = new RenderWindow(videoMode, DisplaySettings.windowTitle,
                DisplaySettings.fullScreen ? Styles.Fullscreen : Styles.Default);

            renderWindow.Closed += OnClose;

            renderWindow.SetVerticalSyncEnabled(DisplaySettings.vSyncOn);
        }

        // Process events
        public static void UpdateWindow()
        {
            renderWindow.DispatchEvents();
        }

        static void OnClose (object sender, EventArgs e)
        {
            renderWindow.Close();
        }
    }
}
