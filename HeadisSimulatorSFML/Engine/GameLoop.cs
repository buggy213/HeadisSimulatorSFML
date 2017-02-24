namespace HeadisSimulatorSFML.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SFML.System;

    public static class GameLoop
    {
        private static bool gameRunning;
        private static Clock clock;

        public static void RunGame()
        {
            Init();
            Loop();
        }

        public static void Stop()
        {
            gameRunning = false;
        }

        public static void Init()
        {
            clock = new Clock();
            clock.Restart();

            gameRunning = true;

            // Initialize all the Manager classes
            WindowManager.Init();
        }

        // The actual gameloop -- based off of the dewitters gameloop
        public static void Loop()
        {
            long nextGameTick = clock.Millis();
            long previousUpdateTick = clock.Millis();

            float interpolation;

            while (gameRunning)
            {
                int loops = 0;
                while (clock.Millis() > nextGameTick && loops < GameLoopSettings.MaxFrameskip)
                {
                    float deltaTime = clock.Millis() - previousUpdateTick;
                    Update(deltaTime);

                    nextGameTick += GameLoopSettings.SkipTicks;
                    loops++;

                    previousUpdateTick = clock.Millis();
                }

                interpolation = (clock.Millis() + GameLoopSettings.SkipTicks - nextGameTick) /
                    GameLoopSettings.SkipTicks;

                Display(interpolation);
            }
        }

        public static void Update(float deltaTime)
        {
            
        }

        public static void Display(float interpolation)
        {
            WindowManager.UpdateWindow();
        }

        public static long Millis(this Clock clock)
        {
            return clock.ElapsedTime.AsMicroseconds() / 1000;
        }
    }
}
