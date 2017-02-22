using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadisSimulatorSFML.Engine
{
    class DisplaySettings
    {
        // Whether or not V-Sync is enabled
        // TODO make all of these settings changable by the user and loaded from a config file or something
        public static bool vSyncOn = true;

        public static uint requestedWidth;

        public static uint requestedHeight;

        public static bool fullScreen = true;

        public static string windowTitle = "Headis Simulator";

    }
}
