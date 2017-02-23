using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadisSimulatorSFML.Engine
{
    public class Screen : IUpdatable
    {
        bool inFocus;
        
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

        // Returns whether or not it was successful at exiting
        bool ExitScreen()
        {
            if (ScreenManager.Peek() == this)
            {
                ScreenManager.PopScreen();
                return true;
            }

            return false;
        }

        public virtual void Update(float deltaTime)
        {

        }

        public virtual void Draw()
        {

        }

    }
}
