using System;

[Flags]
public enum SoundShaderOptions
{
    None = 0,
    Sound = 1,
    Shake = 2,
    Fade = 4,
    NoDuplicates = 8,
    Loop = 16
}

public struct SoundShaderSettings
{
    public string Name;
    public SoundShaderOptions Options;
    public float Volume;
    public float Pitch;
    public float[] RandomizerWeightings;
}