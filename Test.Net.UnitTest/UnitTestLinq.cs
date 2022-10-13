using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Test.Net.General.GarbageCollector;
using Test.Net.General.Linq;
using Test.Net.General.Reflection;

namespace Test.Net.UnitTest
{
    public class TestsLinq
    {

        [Test]
        public void InitTest()
        {
            //Arrange: define input data

            //Act : execute actions

            //Assert : validate the results
            Console.WriteLine("Starting test!");
            Assert.IsTrue(true);
        }

        [Test]
        public void Validate_Secuence_Zip()
        {
            LinqOperation intance = new LinqOperation();

            int value = intance.OperationSequenceWhitZip();

            Assert.Positive(value);
        }

        [Test]
        public void Get_Pairs()
        {
            LinqOperation intance = new LinqOperation();

            intance.GetPairs();

            Assert.IsTrue(true);
        }

        [Test]
        public void Execution_Lazy_Query()
        {
            LinqOperation intance = new LinqOperation();

            intance.ExecutionLazyQuery();

            Assert.IsTrue(true);
        }

        [Test]
        public void Execution_Eager_Query()
        {
            LinqOperation intance = new LinqOperation();

            intance.ExecutionEagerQuery();

            Assert.IsTrue(true);
        }

        [Test]
        public void Execution_Skip_Take()
        {
            LinqOperation intance = new LinqOperation();

            intance.ExampleSkipTake();

            Assert.IsTrue(true);
        }

        [Test]
        public void Execution_Discard_Out_Parameter()
        {
            var inputs = new List<string> { "123", "234", "abc", "def" };

            foreach (string input in inputs)
            {
                if (int.TryParse(input, out _))
                {
                    Console.WriteLine($"'{input}': valid");
                }
                else
                {
                    Console.WriteLine($"'{input}': invalid");
                }
            }
        }
    }
}