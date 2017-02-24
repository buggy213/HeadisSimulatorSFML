namespace HeadisSimulatorSFML.Engine
{
    public class Screen : IUpdatable
    {
        private bool inFocus;
        
        public bool InFocus
        {
            get
            {
                return inFocus;
            }

            set
            {
                inFocus = value;
            }
        }
        
        public virtual void Update(float deltaTime)
        {

        }

        public virtual void Draw()
        {

        }

        // Returns whether or not it was successful at exiting
        protected bool ExitScreen()
        {
            if (ScreenManager.Peek() == this)
            {
                ScreenManager.PopScreen();
                return true;
            }

            return false;
        }
    }
}
