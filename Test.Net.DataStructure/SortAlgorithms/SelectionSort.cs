using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.DataStructure.SortAlgorithms
{
    public class SelectionSort
    {
        public int[] Sort(int[] numbers)
        {
            //int[] num = new int[] { 2, 5, 10, 8, 1, 3, 7, 6, 4, 9 };

            int temp, smaller;
            int arraySize = numbers.Length;

            for (int i = 0; i < arraySize -1; i++)
            {
                smaller = i;
                for (int j = i+1; j < arraySize; j++)
                {
                    int num1 = numbers[j];
                    int num2 = numbers[smaller];
                    if (num1 < num2)
                    {
                        smaller = j;
                    }
                }

                temp = numbers[smaller];
                numbers[smaller] = numbers[i];
                numbers[i] = temp;  
            }

            return numbers;
        }
    }
}
