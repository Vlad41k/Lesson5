using System;
namespace VariantB
{
    public class FolkSong : Song
    {
        public string Country { get; set; }
        public FolkSong(string name, string style, int duration, string country)
            : base(name, style, duration)
        {
            Country = country;
        } // Конструктор
        public override void ViewInformation()
        {
            Console.WriteLine("Информация про историю развития народной музыки");
        } // Переопределение метода
        public override string ToString()
        {
            return $"Name is {Name},\tStyle is {Style},\tDuration is {Duration/60}:{Duration % 60},\tCountry is {Country}";
        } // Переопределение метода 
    }
}
