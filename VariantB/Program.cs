using System;
// Определить иерархию музыкальных композиций. Записать на диск сборку. Подсчитать продолжительность.
// Провести перестановку композиций диска на основе принадлежности к стилю.
// Найти композицию, соответствующую заданному диапазону длины треков.
namespace VariantB
{
    class Program
    {
        static void Main(string[] args)
        {
            var PlayList  = new SongRecording(); 
            var FirstSong = new AuthorSong("Cold","Rock",174,"Neffex");
            var SecondSong = new AuthorSong("Villian", "Instrumental", 156, "Nightcore");
            var ThirdSong = new FolkSong("Мамо", "Народная", 204, "Украина");
            var FourthSong = new FolkSong("Ой, мороз", "Народная", 133, "Россия");
            PlayList.AddSong(FirstSong);
            PlayList.AddSong(SecondSong);
            PlayList.AddSong(ThirdSong);
            PlayList.AddSong(FourthSong);
            PlayList.ShowDisk();
            var SongsDuration = PlayList.CalculateDuration(PlayList._songs);
            Console.WriteLine($"\nОбщая длительность песен на диске: {SongsDuration}");
            SongRecording.FindSong(PlayList._songs, 150, 180);
            Array.Sort(PlayList._songs);
            Console.WriteLine($"\nПесни на диске после сортировки:");
            PlayList.ShowDisk();
        }
    }
}
