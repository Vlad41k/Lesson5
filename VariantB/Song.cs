using System;
namespace VariantB
{
    public abstract class Song
    {
        public string Name { get; init; }
        public string Style { get; init; }
        public int Duration { get; init; }
        public Song(string name, string style, int duration)
        {
            Name = name;
            Style = style;
            Duration = duration;
        }    // Конструктор
        public override string ToString()
        {
            return $"Name is {Name},\tStyle is {Style},\tDuration is {Duration}";
        }  // Переопределение метода
        public abstract void ViewInformation(); // Обьявление абстрактной функции
    }
}
