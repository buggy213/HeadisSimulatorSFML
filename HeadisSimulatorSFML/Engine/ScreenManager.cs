namespace HeadisSimulatorSFML.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ScreenManager
    {
        private static Stack<Screen> screens;
        private static Screen currentScreen;

        public static Stack<Screen> Screens { get => screens; }

        public static Screen CurrentScreen { get => currentScreen; }

        public static void PushScreen(Screen screen)
        {
            currentScreen.InFocus = false;
            screen.InFocus = true;
            screens.Push(screen);
            currentScreen = screen;
        }

        public static Screen PopScreen()
        {
            Screen popScreen = screens.Pop();
            currentScreen = screens.Peek();
            currentScreen.InFocus = true;
            popScreen.InFocus = false;
            return popScreen;
        }

        public static Screen Peek()
        {
            return screens.Peek();
        }

        public static void ScreenUpdate(float deltaTime)
        {
            if (currentScreen == null)
            {
                // No screen is present, so you can't update anything
                return;
            }

            currentScreen.Update(deltaTime);
        }

        public static void ScreenDraw()
        {

        }
    }
}
