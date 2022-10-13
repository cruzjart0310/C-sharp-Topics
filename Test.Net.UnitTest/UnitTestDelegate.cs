using NUnit.Framework;
using System;
using Test.Net.General.Delegate;

namespace Test.Net.UnitTest
{
    public class UnitTestDelegate
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
        public void Validate_Delegate()
        {
            DelegateExample instance = new DelegateExample();

            //instance.PrintWords();

            instance.PrintUsers();

            Assert.True(true);
        }
    }
}