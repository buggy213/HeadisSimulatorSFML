namespace HeadisSimulatorSFML.Engine
{
    public class DisplaySettings
    {
        // Whether or not V-Sync is enabled
        // TODO make all of these settings changable by the user and loaded from a config file or something
        public static bool VSyncOn = true;

        public static uint RequestedWidth;

        public static uint RequestedHeight;

        public static bool FullScreen = true;

        public static string WindowTitle = "Headis Simulator";
    }
}
