namespace HeadisSimulatorSFML.Engine.Audio
{ 
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SFML.Audio;

    public class SoundShader
    {
        private SoundType type;
        private string name;
        private List<SoundBuffer> soundBuffers;
        private List<Music> music;
        
        public string Name
        {
            get
            {
                return name;
            }
        }

        public void Load(string[] paths, SoundShaderSettings settings)
        {
            name = settings.Name;
            if (settings.Options.HasFlag(SoundShaderOptions.Sound))
            {
                soundBuffers = new List<SoundBuffer>();
            }
            else
            {
                music = new List<Music>();
            }

            for (int i = 0; i < paths.Length; i++)
            {
                if (settings.Options.HasFlag(SoundShaderOptions.Sound))
                {
                    soundBuffers.Add(new SoundBuffer(paths[i]));
                }
                else
                {

                }
            }
        }

        public void Unload()
        {

        }

        public object Play()
        {
            throw new NotImplementedException();
        }
    }
}
