using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.General.Reflection
{
    public enum Rating
    {
        Rubbish,
        Poor,
        Average,
        Good,
        Excellent
    };

    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime DateOfpublication { get; set; }
        public Rating Rating { get; set; }
    }

    public static class BookData
    {
        public static IEnumerable<Book> books = new Book[]
        {
            new Book { Title = "Tile 1", Author = "Paul", DateOfpublication = new DateTime(1959,3, 23),Rating =Rating.Average},
            new Book { Title = "Tile 2",Author  = "Andre", DateOfpublication = new DateTime(1959,3, 23), Rating = Rating.Rubbish},
            new Book { Title = "Tile 3",Author  = "Piere", DateOfpublication = new DateTime(1959,3, 23), Rating= Rating.Poor},
            new Book { Title = "Tile 4", Author = "Patric", DateOfpublication = new DateTime(1959,3, 23),Rating=Rating.Excellent},
        };
    }
}
