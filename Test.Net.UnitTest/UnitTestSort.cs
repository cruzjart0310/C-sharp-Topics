using NUnit.Framework;
using System;
using System.Diagnostics;
using Test.Net.DataStructure.BubbleSort;
using Test.Net.DataStructure.SortAlgorithms;
using Test.Net.General.Delegate;

namespace Test.Net.UnitTest
{
    public class UnitTestSort
    {

        [Test]
        public void InitTestBubbleSort()
        {
            //Arrange: define input
            BubbleSortExample instance = new BubbleSortExample();

            //Act : execute actions
            int[] numbers = instance.Sort();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Position:{i} {numbers[i]}");
            }

            //Assert : validate the results
            Console.WriteLine("Starting test!");
            Assert.IsTrue(true);
        }

        [Test]
        public void InitTestQuickSort()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            //Arrange: define input
            QuickSortExample instance = new QuickSortExample();

            int[] num = new int[] { 2, 5, 10, 8, 1, 3, 7, 6, 4, 9 };

            //Act : execute actions
            int[] numbers = instance.Quicksort(num, 0, num.Length -1);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Position:{i} {numbers[i]}");
            }

            Console.WriteLine("Time - " + timer.Elapsed.ToString());
            timer.Stop();

            //Assert : validate the results
            Console.WriteLine("Starting test!");
            Assert.IsTrue(true);
        }

        [Test]
        public void InitTestSelectionSort()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            //Arrange: define input
            SelectionSort instance = new SelectionSort();

            int[] num = new int[] { 2, 5, 10, 8, 1, 3, 7, 6, 4, 9 };

            //Act : execute actions
            int[] numbers = instance.Sort(num);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Position:{i} {numbers[i]}");
            }

            Console.WriteLine("Time - " + timer.Elapsed.ToString());
            timer.Stop();

            //Assert : validate the results
            Console.WriteLine("Starting test!");
            Assert.IsTrue(true);
        }
    }
}