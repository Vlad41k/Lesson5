using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariantB
{
    class AuthorSound : Sound
    {
        public string Author { get; set; }
        public AuthorSound(string name, string style, int duration, string author)
            : base(name, style, duration)
        {
            Author = author;
        }
        public override void ViewInformation()
        {
            Console.WriteLine("Информация про историю развития авторской музыки");
        }
        public override string ToString()
        {
            return $"Name is {Name},\tStyle is {Style},\tDuration is {Duration},\tAuthor is {Author}";
        }
    }
}
