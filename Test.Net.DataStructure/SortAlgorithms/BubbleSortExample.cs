using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.DataStructure.BubbleSort
{
    public class BubbleSortExample
    {
        public int[] Sort()
        {
            int[] numbers = new int[]{ 2, 5, 10, 8, 1, 3, 7, 6, 4, 9 };
            bool swap = true;

            while (swap)
            {
                Console.Write($"[");
                swap = false;
                for (int i = 0; i <= numbers.Length - 1; i++)
                {
                    int firstPosition = numbers[i];
                    int nextPosition = numbers[i+1];
                        
                    if (firstPosition > nextPosition)
                    {
                        swap = true;
                        numbers[i] = nextPosition;
                        numbers[i + 1] = firstPosition;
                    }

                    Console.Write($"{numbers[i]},");
                }
                Console.Write($"]");
                Console.WriteLine();
            }

            return numbers;
        }
    }
}
