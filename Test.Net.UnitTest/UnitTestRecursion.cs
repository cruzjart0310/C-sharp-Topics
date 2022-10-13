using NUnit.Framework;
using System;
using Test.Net.DataStructure.BubbleSort;
using Test.Net.DataStructure.Recursion;
using Test.Net.General.Delegate;
using Test.Net.Utilities;

namespace Test.Net.UnitTest
{
    public class UnitTestRecursion
    {

        [Test]
        public void InitTestFactorial()
        {
            Watcher.Init();

            //Arrange: define input
            Recursion instance = new Recursion();

            //Act : execute actions
            int value = instance.Factorial(5);

            Watcher.Stop();

            Console.WriteLine($"Value Factorial:{value}");

            //Assert : validate the results
            Assert.IsTrue(true);
        }

        //1 2 ,3 4,5 = 5X4=20X3=60X2=120X1=120
        [Test]
        public void InitTestFibonacci()
        {
            //Arrange: define input
            Recursion instance = new Recursion();

            //Act : execute actions
            int value = instance.Fib(5);

            Console.WriteLine(value);

            //Assert : validate the results
            Assert.IsTrue(true);
        }

        [Test]
        public void InitTestFibonacciMemoization()
        {
            //Arrange: define input
            Recursion instance = new Recursion();

            int[] valoresC = new int[40];

            int n = 0;
            for (int i = 0; i < 40; i++)
            {
                valoresC[n] = -1;
            }
            //Act : execute actions
            int value = instance.FibM(10);

            Console.WriteLine(value);

            //Assert : validate the results
            Assert.IsTrue(true);
        }


        [Test]
        public void InitTestFibonacciTabulacion()
        {
            //Arrange: define input
            Recursion instance = new Recursion();
            //Act : execute actions
            int value = instance.FibT(10);

            Console.WriteLine(value);

            //Assert : validate the results
            Assert.IsTrue(true);
        }
    }
}