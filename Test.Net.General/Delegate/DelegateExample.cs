using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.General.Delegate
{
    public class DelegateExample
    {
        private delegate string ShowDelegate(string cad);
        private readonly Func<string, bool> HasThree = str => str.Length == 3;

        private readonly string[] words = {
            "sky", "forest", "wood", "cloud", "falcon", "owl" , "ocean",
            "water", "bow", "tiny", "arc"
        };

        User[] users =
        {
            new (1, "John", "London", "2001-04-01"),
            new (2, "Lenny", "New York", "1997-12-11"),
            new (3, "Andrew", "Boston", "1987-02-22"),
            new (4, "Peter", "Prague", "1936-03-24"),
            new (5, "Anna", "Bratislava", "1973-11-18"),
            new (6, "Albert", "Bratislava", "1940-12-11"),
            new (7, "Adam", "Trnava", "1983-12-01"),
            new (8, "Robert", "Bratislava", "1935-05-15"),
            new (9, "Robert", "Prague", "1998-03-14"),
        };

        public void PrintWords()
        {
            IEnumerable<string> list = words.Where(HasThree);
            foreach (string word in list)
            {
                Console.WriteLine(word);
            }
        }


        public void PrintUsers()
        {
            var city = "Bratislava";

            Func<User, bool> livesIn = e => e.City == city;

            var res = users.Where(livesIn);

            foreach (var e in res)
            {
                Console.WriteLine($"{e.Id } {e.Name} {e.City} {e.Date}");
            }
        }
    }

    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public string Date { get; set; }

        public User(int id, string name, string city, string date)
        {
            Id = id;
            Name = name;
            City = city;
            Date = date;
        }
    }
}
