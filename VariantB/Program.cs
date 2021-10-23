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
            var a  = new SoundRecording();
            a.CalculateDuration(a._sounds);
            a.FindSounds(a._sounds, 100, 200);
        }
    }
}
