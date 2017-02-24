namespace HeadisSimulatorSFML.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using HeadisSimulatorSFML.Engine.Audio;
    using SFML.Audio;
    
    public enum SoundType
    {
        Music,
        Sound
    }

    public static class AudioManager
    {
        private static Dictionary<SoundShader, Music[]> loadedMusic;

        private static List<SoundShader> loadedSoundShaders;

        private static Dictionary<SoundShader, Sound[]> loadedSounds;

        public static void Init()
        {
            loadedMusic = new Dictionary<SoundShader, Music[]>();
            loadedSounds = new Dictionary<SoundShader, Sound[]>();
            loadedSoundShaders = new List<SoundShader>();
        }
    }
}
