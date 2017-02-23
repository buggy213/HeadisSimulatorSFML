using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.System;

namespace HeadisSimulatorSFML.Engine
{
    static class GameLoop
    {
        static bool gameRunning;
        static Clock clock;

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

            // float interpolation;

            while (gameRunning)
            {
                int loops = 0;
                while (clock.Millis() > nextGameTick && loops < GameLoopSettings.MAX_FRAMESKIP)
                {
                    float deltaTime = clock.Millis() - previousUpdateTick;
                    Update(deltaTime);

                    nextGameTick += GameLoopSettings.SKIP_TICKS;
                    loops++;

                    previousUpdateTick = clock.Millis();
                }

                // interpolation = (float)(clock.Millis() + GameLoopSettings.SKIP_TICKS - nextGameTick) /
                //     (float)(GameLoopSettings.SKIP_TICKS);

                Display();
            }
        }

        public static void Update(float deltaTime)
        {
            
        }

        public static void Display()
        {
            WindowManager.UpdateWindow();
        }

        public static long Millis(this Clock clock)
        {
            return clock.ElapsedTime.AsMicroseconds() / 1000;
        }
    }

    class GameLoopSettings
    {
        // 1 Tick = 1 Millisecond
        public const int TICKS_PER_SECOND = 50;

        public const int SKIP_TICKS = 1000 / TICKS_PER_SECOND;

        public const int MAX_FRAMESKIP = 10;
    }
}
