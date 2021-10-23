using System;
namespace VariantB
{
    public abstract class Sound
    {
        public string Name { get; init; }
        public string Style { get; init; }
        public int Duration { get; init; }
        public Sound(string name, string style, int duration)
        {
            Name = name;
            Style = style;
            Duration = duration;
        }   
        public override string ToString()
        {
            return $"Name is {Name},\tStyle is {Style},\tDuration is {Duration}";
        }
        public abstract void ViewInformation();
    }
}
