using System;
using System.Collections;

namespace VariantB
{
    public interface ICalculateDuration
    {
        public double CalculateDuration(Song[] sounds);
    }
    public class SongRecording : IEnumerable, ICalculateDuration
    {

        public Song[] _songs = new Song[0];
        public void ShowDisk() // Показать все песни на диске
        {
            Console.WriteLine("Песни на диске:\n");
            foreach (var item in _songs)
                Console.WriteLine(item); // Вывод информации о каждой песне
        }
        public void AddSong(Song newSong) // Записать одну песню
        {
            Array.Resize<Song>(ref _songs, _songs.Length + 1); // Изменение длины массива
            _songs[_songs.Length - 1] = newSong;
        }
        public double CalculateDuration (Song[] sounds) // Расчет продолжительности песен на диске
        {
            double SongDuration = 0;
            foreach (var item in sounds) 
                SongDuration += item.Duration;
            return SongDuration;
        }  
        public static void FindSong(Song[] sounds,int starttime, int endtime) // Поиск песен в идапазоне
        {
            Console.WriteLine("Песни в указанном диапазоне длительности: \n");
            foreach (var item in sounds)
            {
                if (item.Duration > starttime && item.Duration < endtime)
                    Console.WriteLine (item);
            }
        }
        public IEnumerator GetEnumerator()
        {
            return _songs.GetEnumerator();
        }

    }
}
