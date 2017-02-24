namespace HeadisSimulatorSFML.Engine
{
    public class GameLoopSettings
    {
        // 1 Tick = 1 Millisecond
        public const int TicksPerSecond = 50;

        public const int SkipTicks = 1000 / TicksPerSecond;

        public const int MaxFrameskip = 10;
    }
}
