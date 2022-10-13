using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.General.Linq
{
    public class LinqOperation
    {
        public int OperationSequenceWhitZip()
        {
            int[] vectorA = { 0, 2, 4, 5, 6 };
            int[] vectorB = { 1, 3, 5, 7, 8 };

            int dotProduct = vectorA.Zip(vectorB, (a, b) => a * b).Sum();
            Console.WriteLine($"Dot product: {dotProduct}");

            return dotProduct;
        }

        public void GetPairs()
        {
            int[] vectorA = { 0, 2, 4, 5, 6 };
            int[] vectorB = { 1, 3, 5, 7, 8 };

            var pairs = from a in vectorA
                        from b in vectorB
                        where (a < b)
                        select (a, b);

            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.a} is less than {pair.b}");
            }
        }

        public void ExecutionLazyQuery()
        {
            //Sequence operators form first-class queries that
            //are not executed int you enumerate over theme
            int[] numbers = { 5, 4, 1, 3, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, };

            int i = 0;
            var q = from n in numbers
                    select i++;

            //Note, the local variable 'i' is not incremented
            //until each element is evaluated (as a side-effect)
            foreach (var v in q)
            {
                Console.WriteLine($"v = {v} , i={i}");
            }
        }

        public void ExecutionEagerQuery()
        {
            //methods like toList() cause the query to be 
            //excute immediately, cachig the result 
            int[] numbers = { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, };

            int i = 0;
            var q = (from n in numbers
                     select i++).ToList();

            //Note, the local variable 'i' has already been fully
            //incremented before we iterate the result
            foreach (var v in q)
            {
                Console.WriteLine($"v = {v} , i={i}");
            }
        }

        public void ExampleSkipTake()
        {
            var words = new string[]
            {
                "monday",
                "tusday",
                "wenesday",
                "thursday",
                "friday",
                "saturday",
                "sunday"
            };

            var days = from n in words
                       select n;

            days.Skip(5).Take(2).ToList().ForEach(x =>
            {
                Console.WriteLine(x);
            });

            Range range = new Range(start: 2, end: 4);

            #region IQueriable VS IEnumerable
            //IQueryable<User> query = _context.ApplicationUsers;  

            //IEnumerable<User> ltUsers = from user in _context.ApplicationUsers
            //                            select user;

            //ltUsers = ltUsers.Where(d => d.IsMarried);
            //foreach (User user in ltUsers)
            //{
            //    Console.WriteLine(user.Id);
            //}
            #endregion
        }

        public void CollectionExample()
        {
            Random random = new Random(420);
            var items = Enumerable.Range(1, 100).Select(x => x > 10);

            var sort = items.OrderBy(x => x).ToArray();
        }
    }
}
