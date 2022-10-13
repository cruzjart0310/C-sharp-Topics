using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.General.ParameterValueRefence
{
    public static class Parameter
    {
 
        public static void Update(int value)
        {
            value += 5;
            Console.WriteLine($"value is: {value}") ;
        }

        public static void UpdateRef(ref int value)
        {
            value += 2;
            Console.WriteLine($"value is: {value}");
        }
    }
}
