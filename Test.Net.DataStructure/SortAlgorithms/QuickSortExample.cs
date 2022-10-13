using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.DataStructure.BubbleSort
{
    public class QuickSortExample
    {
        public int[] Quicksort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                Quicksort(array, left, pivot - 1);
                Quicksort(array, pivot + 1, right);
            }

            return array;
        }

        public int Partition(int[] array, int left, int right)
        {
            //{ 2, 5, 10, 8, 1, 3, 7, 6, 4, 9 }
            //{ 2, 5, 8, 1, 3, 7, 6, 4, 9, 10 }
            int i = left;
            int pivot = array[right];
            int temp;

            for (int j = left; j <= right; j++)
            {
                if (array[j] < pivot)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }

            temp = array[right];
            array[right] = array[i];
            array[i] = temp;
            return i;
        }
    }
}
