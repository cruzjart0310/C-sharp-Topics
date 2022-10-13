using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.General.Dictionary
{
    public class Dictionary
    {
        public void TryGetValue()
        {
            Int32 result = new Int32();
            Int32 calculatedTotal = 0;

            var d1 = new Dictionary<string, int>();
            d1.Add("ten", 10);
            d1.Add("twenty", 20);
            d1.Add("thirty", 30);

            //correct way to validate a prop
            if (d1.TryGetValue("twenty", out result))
            {
                calculatedTotal = result * 5;
                Console.WriteLine($"Result: {result}");
            }
            else {
                Console.WriteLine("Key does not exist");
            }

        }
    }
}
