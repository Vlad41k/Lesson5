using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariantB
{
    class AuthorSong : Song
    {
        public string Author { get; set; }
        public AuthorSong(string name, string style, int duration, string author)
            : base(name, style, duration)
        {
            Author = author;
        } // Конструктор
        public override void ViewInformation()
        {
            Console.WriteLine("Информация про историю развития авторской музыки");
        } // Переопределение метода
        public override string ToString()
        {
            return $"Name is {Name},\tStyle is {Style},\tDuration is {Duration / 60}:{Duration % 60},\tAuthor is {Author}";
        }// Переопределение метода 
    }
}
