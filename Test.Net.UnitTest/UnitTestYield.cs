using NUnit.Framework;
using System;
using System.Collections.Generic;
using Test.Net.General.Yield;

namespace Test.Net.UnitTest
{
    public class UnitTestYield
    {

        [Test]
        public void Validate_Yield_Example()
        {
            //Arrange
            YieldExample instance = new YieldExample();
            IEnumerable<string> languajes = new List<string>()
            {
                "JavaScript", "C#", "Python", "Java"
            };

            //Act
            var itemToPrint = instance.GetItemFromList(languajes);

            foreach(var item in itemToPrint)
            {
                Console.WriteLine(item);
            }

            //Assert
            Assert.True(true);
        }
    }
}