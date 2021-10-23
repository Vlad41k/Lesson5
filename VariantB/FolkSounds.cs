using System;
namespace VariantB
{
    public class FolkSound : Sound
    {
        public string Country { get; set; }
        public FolkSound(string name, string style, int duration, string country)
            : base(name, style, duration)
        {
            Country = country;
        }
        public override void ViewInformation()
        {
            Console.WriteLine("Информация про историю развития народной музыки");
        }
        public override string ToString()
        {
            return $"Name is {Name},\tStyle is {Style},\tDuration is {Duration},\tCountry is {Country}";
        }
    }
}
