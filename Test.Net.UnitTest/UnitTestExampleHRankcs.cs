using NUnit.Framework;
using System;
using Test.Net.DataStructure.BubbleSort;
using Test.Net.General.Delegate;

namespace Test.Net.UnitTest
{
    public class UnitTestExampleHRank
    {

        [Test]
        public void InitTest()
        {
            //Arrange: define input
            

            //Act : execute actions
           

            //Assert : validate the results
            Console.WriteLine("Starting test!");
            Assert.IsTrue(true);
        }

        [Test]
        public void Valid_Positive_Number()
        {
            //arrange
            int number = 10;
            int number2 = 10;

            //act

            int sum = number + number2;


            //Assert
            Assert.Positive(sum);
            Assert.IsTrue(sum == 20);
            Assert.IsNotNull(sum);
        }
    }
}