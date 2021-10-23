using System;
using System.Collections;

namespace VariantB
{
    public interface ICalculateDuration
    {
        public double CalculateDuration(Sound[] sounds);
    }
    public class SoundRecording : IEnumerable, ICalculateDuration
    {
        public Sound[] _sounds;
        public SoundRecording ()
        {
            _sounds = new Sound[]
            {
                new AuthorSound("Never give up", "Rock", 194, "Neffex"),
                new AuthorSound("Cold", "Rock", 154, "Neffex"),
                new AuthorSound("Destiny", "Rock", 201, "Nightcore"),
                new FolkSound("Ти ж мене підманула", "Народная", 177, "Украина"),
                new FolkSound("Ой, чий то кінь стоїть", "Народная", 119, "Украина"),
                new FolkSound("Ах ты, степь широкая", "Народная", 244,"Россия")
            };
        }
        public double CalculateDuration (Sound[] sounds)
        {
            double SoundDuration = 0;
            foreach (var item in sounds) 
                SoundDuration += item.Duration;
            return SoundDuration;
        }
        public void FindSounds(Sound[] sounds,int starttime, int endtime)
        {
            foreach (var item in sounds)
            {
                if (item.Duration > starttime && item.Duration < endtime)
                    Console.WriteLine (item);
            }
        }
        public IEnumerator GetEnumerator()
        {
            return _sounds.GetEnumerator();
        }

    }
}
